using MedicalResearch.StudyManagement.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace MedicalResearch.StudyManagement.StoreAccess {

  public static class ApiVersion {
    public const string SemanticVersion = "2.0.0";
  }

  /// <summary> Provides CRUD access to stored DataEndpoints (based on schema version '2.0.0') </summary>
  public partial interface IDataEndpointStore : System.Data.Fuse.IRepository<DataEndpoint, String> {
  }

  /// <summary> Provides CRUD access to stored Institutes (based on schema version '2.0.0') </summary>
  public partial interface IInstituteStore : System.Data.Fuse.IRepository<Institute, Guid> {
  }

  /// <summary> Provides CRUD access to stored InstitueRelatedOAuthConfigs (based on schema version '2.0.0') </summary>
  public partial interface IInstitueRelatedOAuthConfigStore : System.Data.Fuse.IRepository<InstitueRelatedOAuthConfig, InstitueRelatedOAuthConfigIdentity> {
  }

/// <summary> Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig </summary>
public class InstitueRelatedOAuthConfigIdentity {
  public Guid InstituteUid;
  public String DataEndpointUrl;
}

  /// <summary> Provides CRUD access to stored ResearchStudies (based on schema version '2.0.0') </summary>
  public partial interface IResearchStudyStore : System.Data.Fuse.IRepository<ResearchStudy, Guid> {
  }

  /// <summary> Provides CRUD access to stored Sites (based on schema version '2.0.0') </summary>
  public partial interface ISiteStore : System.Data.Fuse.IRepository<Site, Guid> {
  }

  /// <summary> Provides CRUD access to stored InvolvedPersons (based on schema version '2.0.0') </summary>
  public partial interface IInvolvedPersonStore : System.Data.Fuse.IRepository<InvolvedPerson, Guid> {
  }

  /// <summary> Provides CRUD access to stored InvolvementRoles (based on schema version '2.0.0') </summary>
  public partial interface IInvolvementRoleStore : System.Data.Fuse.IRepository<InvolvementRole, Guid> {
  }

}
