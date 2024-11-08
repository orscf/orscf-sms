using System;

namespace MedicalResearch.StudyManagement {

  /// <summary>
  /// Provides convenience for bulk-registering controllers for all endpoints, for example when hosting them via asp.net core webapi
  /// </summary>
  public static class SmsEndpointRegister {

    /// <summary></summary>
    /// <param name="contractType"></param>
    /// <param name="preferredRoute"> WITHOUT the version-prefix and WITHOUT leading or trailing slash!</param>
    public delegate void GetContractsPerEndpointCallback(Type contractType, string preferredRoute);

    public static void GetContractsPerEndpoint(GetContractsPerEndpointCallback callback) {
      callback.Invoke(typeof(StoreAccess.IInstituteStore), "store/Institute");
      callback.Invoke(typeof(StoreAccess.IResearchStudyStore), "store/ResearchStudy");
      callback.Invoke(typeof(StoreAccess.ISiteStore), "store/Site");
      callback.Invoke(typeof(StoreAccess.IDataEndpointStore), "store/DataEndpoint");
      callback.Invoke(typeof(StoreAccess.IInstitueRelatedOAuthConfigStore), "store/InstitueRelatedOAuthConfig");
      callback.Invoke(typeof(StoreAccess.IInvolvedPersonStore), "store/InvolvedPerson");
      callback.Invoke(typeof(StoreAccess.IInvolvementRoleStore), "store/InvolvementRole");
    }

  }

}
