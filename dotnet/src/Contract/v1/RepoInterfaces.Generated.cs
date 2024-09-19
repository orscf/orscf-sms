using MedicalResearch.StudyManagement.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace MedicalResearch.StudyManagement.StoreAccess {

  /// <summary> Provides CRUD access to stored Institutes (based on schema version '2.0.0') </summary>
  public partial interface IInstituteStore : System.Data.Fuse.IRepository<Institute, Guid> {
  }

  /// <summary> Provides CRUD access to stored ResearchStudies (based on schema version '2.0.0') </summary>
  public partial interface IResearchStudyStore : System.Data.Fuse.IRepository<ResearchStudy, Guid> {
  }

  /// <summary> Provides CRUD access to stored Sites (based on schema version '2.0.0') </summary>
  public partial interface ISiteStore : System.Data.Fuse.IRepository<Site, Guid> {
  }

  /// <summary> Provides CRUD access to stored SystemEndpoints (based on schema version '2.0.0') </summary>
  public partial interface ISystemEndpointStore : System.Data.Fuse.IRepository<SystemEndpoint, Guid> {
  }

  /// <summary> Provides CRUD access to stored InstituteRelatedSystemAssignments (based on schema version '2.0.0') </summary>
  public partial interface IInstituteRelatedSystemAssignmentStore : System.Data.Fuse.IRepository<InstituteRelatedSystemAssignment, Guid> {
  }

  /// <summary> Provides CRUD access to stored SystemConnections (based on schema version '2.0.0') </summary>
  public partial interface ISystemConnectionStore : System.Data.Fuse.IRepository<SystemConnection, Guid> {
  }

  /// <summary> Provides CRUD access to stored InvolvedPersons (based on schema version '2.0.0') </summary>
  public partial interface IInvolvedPersonStore : System.Data.Fuse.IRepository<InvolvedPerson, Guid> {
  }

  /// <summary> Provides CRUD access to stored InvolvementRoles (based on schema version '2.0.0') </summary>
  public partial interface IInvolvementRoleStore : System.Data.Fuse.IRepository<InvolvementRole, Guid> {
  }

  /// <summary> Provides CRUD access to stored StudyRelatedSystemAssignments (based on schema version '2.0.0') </summary>
  public partial interface IStudyRelatedSystemAssignmentStore : System.Data.Fuse.IRepository<StudyRelatedSystemAssignment, Guid> {
  }

  /// <summary> Provides CRUD access to stored SiteRelatedSystemAssignments (based on schema version '2.0.0') </summary>
  public partial interface ISiteRelatedSystemAssignmentStore : System.Data.Fuse.IRepository<SiteRelatedSystemAssignment, Guid> {
  }

}
