using MedicalResearch.StudyManagement.Model;
using System;
using System.Data.Fuse;
using System.Data.Fuse.Convenience;
using System.Data.Fuse.Ef;

namespace MedicalResearch.StudyManagement.StoreAccess {

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
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.SiteEntity, Guid>(context);
    }

    public SiteStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<Site, MedicalResearch.StudyManagement.Persistence.SiteEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored SystemEndpoints (based on schema version '2.0.0') </summary>
  public class SystemEndpointStore : ModelVsEntityRepository<SystemEndpoint, MedicalResearch.StudyManagement.Persistence.SystemEndpointEntity, Guid>, ISystemEndpointStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.SystemEndpointEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.SystemEndpointEntity, Guid>(context);
    }

    public SystemEndpointStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<SystemEndpoint, MedicalResearch.StudyManagement.Persistence.SystemEndpointEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored InstituteRelatedSystemAssignments (based on schema version '2.0.0') </summary>
  public class InstituteRelatedSystemAssignmentStore : ModelVsEntityRepository<InstituteRelatedSystemAssignment, MedicalResearch.StudyManagement.Persistence.InstituteRelatedSystemAssignmentEntity, Guid>, IInstituteRelatedSystemAssignmentStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.InstituteRelatedSystemAssignmentEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.InstituteRelatedSystemAssignmentEntity, Guid>(context);
    }

    public InstituteRelatedSystemAssignmentStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<InstituteRelatedSystemAssignment, MedicalResearch.StudyManagement.Persistence.InstituteRelatedSystemAssignmentEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored SystemConnections (based on schema version '2.0.0') </summary>
  public class SystemConnectionStore : ModelVsEntityRepository<SystemConnection, MedicalResearch.StudyManagement.Persistence.SystemConnectionEntity, Guid>, ISystemConnectionStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.SystemConnectionEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.SystemConnectionEntity, Guid>(context);
    }

    public SystemConnectionStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<SystemConnection, MedicalResearch.StudyManagement.Persistence.SystemConnectionEntity>()
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

  /// <summary> Provides CRUD access to stored StudyRelatedSystemAssignments (based on schema version '2.0.0') </summary>
  public class StudyRelatedSystemAssignmentStore : ModelVsEntityRepository<StudyRelatedSystemAssignment, MedicalResearch.StudyManagement.Persistence.StudyRelatedSystemAssignmentEntity, Guid>, IStudyRelatedSystemAssignmentStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.StudyRelatedSystemAssignmentEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.StudyRelatedSystemAssignmentEntity, Guid>(context);
    }

    public StudyRelatedSystemAssignmentStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<StudyRelatedSystemAssignment, MedicalResearch.StudyManagement.Persistence.StudyRelatedSystemAssignmentEntity>()
    ) {
    }

  }

  /// <summary> Provides CRUD access to stored SiteRelatedSystemAssignments (based on schema version '2.0.0') </summary>
  public class SiteRelatedSystemAssignmentStore : ModelVsEntityRepository<SiteRelatedSystemAssignment, MedicalResearch.StudyManagement.Persistence.SiteRelatedSystemAssignmentEntity, Guid>, ISiteRelatedSystemAssignmentStore {

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.SiteRelatedSystemAssignmentEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.SiteRelatedSystemAssignmentEntity, Guid>(context);
    }

    public SiteRelatedSystemAssignmentStore() : base(
      CreateInnerEfRepo(), new ModelVsEntityParams<SiteRelatedSystemAssignment, MedicalResearch.StudyManagement.Persistence.SiteRelatedSystemAssignmentEntity>()
    ) {
    }

  }

}
