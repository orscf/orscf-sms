using System;
using Microsoft.EntityFrameworkCore;
using MedicalResearch.StudyManagement.Persistence;

namespace MedicalResearch.StudyManagement.Persistence.EF {

  /// <summary> EntityFramework DbContext (based on schema version '2.0.0') </summary>
  public partial class StudyManagementDbContext : DbContext{

    public const String SchemaVersion = "2.0.0";

    public DbSet<DataEndpointEntity> DataEndpoints { get; set; }

    public DbSet<InstituteEntity> Institutes { get; set; }

    public DbSet<InstitueRelatedOAuthConfigEntity> InstitueRelatedOAuthConfigs { get; set; }

    /// <summary> ResearchStudy: entity, which relates to <see href="https://www.hl7.org/fhir/researchstudy.html">HL7.ResearchStudy</see> </summary>
    public DbSet<ResearchStudyEntity> ResearchStudies { get; set; }

    public DbSet<SiteEntity> Sites { get; set; }

    public DbSet<InvolvedPersonEntity> InvolvedPersons { get; set; }

    public DbSet<InvolvementRoleEntity> InvolvementRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);

#region Mapping

      //////////////////////////////////////////////////////////////////////////////////////
      // DataEndpoint
      //////////////////////////////////////////////////////////////////////////////////////

      var cfgDataEndpoint = modelBuilder.Entity<DataEndpointEntity>();
      cfgDataEndpoint.ToTable("SmsDataEndpoints");
      cfgDataEndpoint.HasKey((e) => e.Url);

      // LOOKUP: >>> Institute
      cfgDataEndpoint
        .HasOne((lcl) => lcl.OwnerInstitute )
        .WithMany((rem) => rem.OwnedDataEndpoints )
        .HasForeignKey(nameof(DataEndpointEntity.OwnerInstituteUid))
        .OnDelete(DeleteBehavior.Restrict);

      //////////////////////////////////////////////////////////////////////////////////////
      // Institute
      //////////////////////////////////////////////////////////////////////////////////////

      var cfgInstitute = modelBuilder.Entity<InstituteEntity>();
      cfgInstitute.ToTable("SmsInstitutes");
      cfgInstitute.HasKey((e) => e.InstituteUid);

      //////////////////////////////////////////////////////////////////////////////////////
      // InstitueRelatedOAuthConfig
      //////////////////////////////////////////////////////////////////////////////////////

      var cfgInstitueRelatedOAuthConfig = modelBuilder.Entity<InstitueRelatedOAuthConfigEntity>();
      cfgInstitueRelatedOAuthConfig.ToTable("SmsInstitueRelatedOAuthConfigs");
      cfgInstitueRelatedOAuthConfig.HasKey((e) => new {e.InstituteUid, e.DataEndpointUrl});

      // LOOKUP: >>> Institute
      cfgInstitueRelatedOAuthConfig
        .HasOne((lcl) => lcl.ForInstitute )
        .WithMany((rem) => rem.OAuthConfigs )
        .HasForeignKey(nameof(InstitueRelatedOAuthConfigEntity.InstituteUid))
        .OnDelete(DeleteBehavior.Restrict);

      // LOOKUP: >>> DataEndpoint
      cfgInstitueRelatedOAuthConfig
        .HasOne((lcl) => lcl.ForEndpoint )
        .WithMany()
        .HasForeignKey(nameof(InstitueRelatedOAuthConfigEntity.DataEndpointUrl))
        .OnDelete(DeleteBehavior.Restrict);

      //////////////////////////////////////////////////////////////////////////////////////
      // ResearchStudy
      //////////////////////////////////////////////////////////////////////////////////////

      var cfgResearchStudy = modelBuilder.Entity<ResearchStudyEntity>();
      cfgResearchStudy.ToTable("SmsResearchStudies");
      cfgResearchStudy.HasKey((e) => e.ResearchStudyUid);

      // LOOKUP: >>> Institute
      cfgResearchStudy
        .HasOne((lcl) => lcl.InitiatorInstitute )
        .WithMany((rem) => rem.InitiatedStudies )
        .HasForeignKey(nameof(ResearchStudyEntity.InitiatorInstituteUid))
        .OnDelete(DeleteBehavior.Restrict);

      //////////////////////////////////////////////////////////////////////////////////////
      // Site
      //////////////////////////////////////////////////////////////////////////////////////

      var cfgSite = modelBuilder.Entity<SiteEntity>();
      cfgSite.ToTable("SmsSites");
      cfgSite.HasKey((e) => e.SiteUid);

      // LOOKUP: >>> Institute
      cfgSite
        .HasOne((lcl) => lcl.RepresentingInstitute )
        .WithMany((rem) => rem.RepresentedSites )
        .HasForeignKey(nameof(SiteEntity.RepresentingInstituteUid))
        .OnDelete(DeleteBehavior.Restrict);

      // PRINCIPAL: >>> ResearchStudy
      cfgSite
        .HasOne((lcl) => lcl.Study )
        .WithMany((rem) => rem.Sites )
        .HasForeignKey(nameof(SiteEntity.ResearchStudyUid))
        .OnDelete(DeleteBehavior.Cascade);

      //////////////////////////////////////////////////////////////////////////////////////
      // InvolvedPerson
      //////////////////////////////////////////////////////////////////////////////////////

      var cfgInvolvedPerson = modelBuilder.Entity<InvolvedPersonEntity>();
      cfgInvolvedPerson.ToTable("SmsInvolvedPersons");
      cfgInvolvedPerson.HasKey((e) => e.InvolvedPersonUid);

      //////////////////////////////////////////////////////////////////////////////////////
      // InvolvementRole
      //////////////////////////////////////////////////////////////////////////////////////

      var cfgInvolvementRole = modelBuilder.Entity<InvolvementRoleEntity>();
      cfgInvolvementRole.ToTable("SmsInvolvementRoles");
      cfgInvolvementRole.HasKey((e) => e.InvolvedPersonRoleUid);

      // LOOKUP: >>> InvolvedPerson
      cfgInvolvementRole
        .HasOne((lcl) => lcl.InvolvedPerson )
        .WithMany((rem) => rem.InvolvementRoles )
        .HasForeignKey(nameof(InvolvementRoleEntity.InvolvedPersonUid))
        .OnDelete(DeleteBehavior.Restrict);

      // PRINCIPAL: >>> ResearchStudy
      cfgInvolvementRole
        .HasOne((lcl) => lcl.ResearchStudy )
        .WithMany((rem) => rem.InvolvementRoles )
        .HasForeignKey(nameof(InvolvementRoleEntity.ResearchStudyUid))
        .OnDelete(DeleteBehavior.Cascade);

      // LOOKUP: >>> Site
      cfgInvolvementRole
        .HasOne((lcl) => lcl.DedicatedToSite )
        .WithMany((rem) => rem.SiteDedicatedInvolvementRoles )
        .HasForeignKey(nameof(InvolvementRoleEntity.DedicatedToSiteUid))
        .OnDelete(DeleteBehavior.Restrict);

#endregion

      this.OnModelCreatingCustom(modelBuilder);
    }

    partial void OnModelCreatingCustom(ModelBuilder modelBuilder);

    protected override void OnConfiguring(DbContextOptionsBuilder options) {

      //reqires separate nuget-package Microsoft.EntityFrameworkCore.SqlServer
      options.UseSqlServer(_ConnectionString);

      //reqires separate nuget-package Microsoft.EntityFrameworkCore.Proxies
      options.UseLazyLoadingProxies();

      this.OnConfiguringCustom(options);
    }

    partial void OnConfiguringCustom(DbContextOptionsBuilder options);

    public static void Migrate() {
      if (!_Migrated) {
        StudyManagementDbContext c = new StudyManagementDbContext();
        c.Database.Migrate();
        _Migrated = true;
        c.Dispose();
      }
    }

   private static bool _Migrated = false;

    private static String _ConnectionString = "Server=(localdb)\\MsSqlLocalDb;Database=StudyManagementDbContext;Integrated Security=True;Persist Security Info=True;MultipleActiveResultSets=True;";
    public static String ConnectionString {
      set{ _ConnectionString = value;  }
    }

  }

}
