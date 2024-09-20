using MedicalResearch.StudyManagement.Model;
using System;
using System.Data.Fuse;
using System.Data.Fuse.Ef;

namespace MedicalResearch.StudyManagement.StoreAccess {

  /// <summary> Provides CRUD access to stored Institutes (based on schema version '2.0.0') </summary>
  public class InstituteStore : FuseMappingProxy<Institute, MedicalResearch.StudyManagement.Persistence.InstituteEntity, Guid>, IInstituteStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.InstituteEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.InstituteEntity, Guid>(context);
    }

    public InstituteStore() : base(CreateInnerEfRepo()) {
    }

  }

  /// <summary> Provides CRUD access to stored ResearchStudies (based on schema version '2.0.0') </summary>
  public class ResearchStudyStore : FuseMappingProxy<ResearchStudy, MedicalResearch.StudyManagement.Persistence.ResearchStudyEntity, Guid>, IResearchStudyStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.ResearchStudyEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.ResearchStudyEntity, Guid>(context);
    }

    public ResearchStudyStore() : base(CreateInnerEfRepo()) {
    }

  }

  /// <summary> Provides CRUD access to stored Sites (based on schema version '2.0.0') </summary>
  public class SiteStore : FuseMappingProxy<Site, MedicalResearch.StudyManagement.Persistence.SiteEntity, Guid>, ISiteStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.SiteEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.SiteEntity, Guid>(context);
    }

    public SiteStore() : base(CreateInnerEfRepo()) {
    }

  }

  /// <summary> Provides CRUD access to stored SystemEndpoints (based on schema version '2.0.0') </summary>
  public class SystemEndpointStore : FuseMappingProxy<SystemEndpoint, MedicalResearch.StudyManagement.Persistence.SystemEndpointEntity, Guid>, ISystemEndpointStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.SystemEndpointEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.SystemEndpointEntity, Guid>(context);
    }

    public SystemEndpointStore() : base(CreateInnerEfRepo()) {
    }

  }

  /// <summary> Provides CRUD access to stored InstituteRelatedSystemAssignments (based on schema version '2.0.0') </summary>
  public class InstituteRelatedSystemAssignmentStore : FuseMappingProxy<InstituteRelatedSystemAssignment, MedicalResearch.StudyManagement.Persistence.InstituteRelatedSystemAssignmentEntity, Guid>, IInstituteRelatedSystemAssignmentStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.InstituteRelatedSystemAssignmentEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.InstituteRelatedSystemAssignmentEntity, Guid>(context);
    }

    public InstituteRelatedSystemAssignmentStore() : base(CreateInnerEfRepo()) {
    }

  }

  /// <summary> Provides CRUD access to stored SystemConnections (based on schema version '2.0.0') </summary>
  public class SystemConnectionStore : FuseMappingProxy<SystemConnection, MedicalResearch.StudyManagement.Persistence.SystemConnectionEntity, Guid>, ISystemConnectionStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.SystemConnectionEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.SystemConnectionEntity, Guid>(context);
    }

    public SystemConnectionStore() : base(CreateInnerEfRepo()) {
    }

  }

  /// <summary> Provides CRUD access to stored InvolvedPersons (based on schema version '2.0.0') </summary>
  public class InvolvedPersonStore : FuseMappingProxy<InvolvedPerson, MedicalResearch.StudyManagement.Persistence.InvolvedPersonEntity, Guid>, IInvolvedPersonStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.InvolvedPersonEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.InvolvedPersonEntity, Guid>(context);
    }

    public InvolvedPersonStore() : base(CreateInnerEfRepo()) {
    }

  }

  /// <summary> Provides CRUD access to stored InvolvementRoles (based on schema version '2.0.0') </summary>
  public class InvolvementRoleStore : FuseMappingProxy<InvolvementRole, MedicalResearch.StudyManagement.Persistence.InvolvementRoleEntity, Guid>, IInvolvementRoleStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.InvolvementRoleEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.InvolvementRoleEntity, Guid>(context);
    }

    public InvolvementRoleStore() : base(CreateInnerEfRepo()) {
    }

  }

  /// <summary> Provides CRUD access to stored StudyRelatedSystemAssignments (based on schema version '2.0.0') </summary>
  public class StudyRelatedSystemAssignmentStore : FuseMappingProxy<StudyRelatedSystemAssignment, MedicalResearch.StudyManagement.Persistence.StudyRelatedSystemAssignmentEntity, Guid>, IStudyRelatedSystemAssignmentStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.StudyRelatedSystemAssignmentEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.StudyRelatedSystemAssignmentEntity, Guid>(context);
    }

    public StudyRelatedSystemAssignmentStore() : base(CreateInnerEfRepo()) {
    }

  }

  /// <summary> Provides CRUD access to stored SiteRelatedSystemAssignments (based on schema version '2.0.0') </summary>
  public class SiteRelatedSystemAssignmentStore : FuseMappingProxy<SiteRelatedSystemAssignment, MedicalResearch.StudyManagement.Persistence.SiteRelatedSystemAssignmentEntity, Guid>, ISiteRelatedSystemAssignmentStore {

    //diese klasse hat den zweck, nach außen einen sauberes und vor allem dediziertes
    //inteface, anstatt des generischen 'IRepository<>' anbieten zu können

    private static EfRepository<MedicalResearch.StudyManagement.Persistence.SiteRelatedSystemAssignmentEntity, Guid> CreateInnerEfRepo() {
      var context = new MedicalResearch.StudyManagement.Persistence.EF.StudyManagementDbContext();
      return new EfRepository<MedicalResearch.StudyManagement.Persistence.SiteRelatedSystemAssignmentEntity, Guid>(context);
    }

    public SiteRelatedSystemAssignmentStore() : base(CreateInnerEfRepo()) {
    }

  }

}
