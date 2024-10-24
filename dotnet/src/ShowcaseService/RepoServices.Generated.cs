using MedicalResearch.StudyManagement.Model;
using System;
using System.Data.Fuse;
using System.Data.Fuse.Convenience;
using System.Data.Fuse.Ef;
using System.Data.Fuse.Ef.InstanceManagement;

namespace MedicalResearch.StudyManagement.StoreAccess {

  /// <summary> Provides CRUD access to stored DataEndpoints (based on schema version '2.0.0') </summary>
  public class DataEndpointStore : ModelVsEntityRepository<DataEndpoint, MedicalResearch.StudyManagement.Persistence.DataEndpointEntity, String>, IDataEndpointStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.DataEndpointEntity, string> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.DataEndpointEntity, string>(context);
    }

    public DataEndpointStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<DataEndpoint, MedicalResearch.StudyManagement.Persistence.DataEndpointEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored Institutes (based on schema version '2.0.0') </summary>
  public class InstituteStore : ModelVsEntityRepository<Institute, MedicalResearch.StudyManagement.Persistence.InstituteEntity, Guid>, IInstituteStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.InstituteEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.InstituteEntity, Guid>(context);
    }

    public InstituteStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<Institute, MedicalResearch.StudyManagement.Persistence.InstituteEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored InstitueRelatedOAuthConfigs (based on schema version '2.0.0') </summary>
  public class InstitueRelatedOAuthConfigStore : ModelVsEntityRepository<InstitueRelatedOAuthConfig, MedicalResearch.StudyManagement.Persistence.InstitueRelatedOAuthConfigEntity, InstitueRelatedOAuthConfigIdentity>, IInstitueRelatedOAuthConfigStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.InstitueRelatedOAuthConfigEntity, InstitueRelatedOAuthConfigIdentity> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.InstitueRelatedOAuthConfigEntity, InstitueRelatedOAuthConfigIdentity>(context);
    }

    public InstitueRelatedOAuthConfigStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<InstitueRelatedOAuthConfig, MedicalResearch.StudyManagement.Persistence.InstitueRelatedOAuthConfigEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored ResearchStudies (based on schema version '2.0.0') </summary>
  public class ResearchStudyStore : ModelVsEntityRepository<ResearchStudy, MedicalResearch.StudyManagement.Persistence.ResearchStudyEntity, Guid>, IResearchStudyStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.ResearchStudyEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.ResearchStudyEntity, Guid>(context);
    }

    public ResearchStudyStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<ResearchStudy, MedicalResearch.StudyManagement.Persistence.ResearchStudyEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored Sites (based on schema version '2.0.0') </summary>
  public class SiteStore : ModelVsEntityRepository<Site, MedicalResearch.StudyManagement.Persistence.SiteEntity, Guid>, ISiteStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.SiteEntity, Guid> CreateInnerEfRepo() {
      //var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      IDbContextInstanceProvider dbContextInstanceProvider = new ShortLivingDbContextInstanceProvider<
        MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext
      >();
      return new EfRepository<
        MedicalResearch.StudyManagement.Persistence.SiteEntity, Guid
      >(dbContextInstanceProvider);
    }

    public SiteStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<Site, MedicalResearch.StudyManagement.Persistence.SiteEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored InvolvedPersons (based on schema version '2.0.0') </summary>
  public class InvolvedPersonStore : ModelVsEntityRepository<InvolvedPerson, MedicalResearch.StudyManagement.Persistence.InvolvedPersonEntity, Guid>, IInvolvedPersonStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.InvolvedPersonEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.InvolvedPersonEntity, Guid>(context);
    }

    public InvolvedPersonStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<InvolvedPerson, MedicalResearch.StudyManagement.Persistence.InvolvedPersonEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored InvolvementRoles (based on schema version '2.0.0') </summary>
  public class InvolvementRoleStore : ModelVsEntityRepository<InvolvementRole, MedicalResearch.StudyManagement.Persistence.InvolvementRoleEntity, Guid>, IInvolvementRoleStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.InvolvementRoleEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.InvolvementRoleEntity, Guid>(context);
    }

    public InvolvementRoleStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<InvolvementRole, MedicalResearch.StudyManagement.Persistence.InvolvementRoleEntity>()
    ) {
    }

  }

}
