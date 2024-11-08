using System;

namespace MedicalResearch.StudyManagement {

  /// <summary>
  /// Provides convenience for bulk-registering factories for all endpoints, for example when hosting them via asp.net core webapi
  /// </summary>
  public static class SmsShowcaseEndpointFactory {

    public delegate void GetFactoryMethodsPerEndpointCallback(Type contractType, Func<object> endpointFactory);

    public static void GetFactoryMethodsPerEndpoint(GetFactoryMethodsPerEndpointCallback callback) {
      callback.Invoke(typeof(StoreAccess.IInstituteStore), () => new StoreAccess.InstituteStore());
      callback.Invoke(typeof(StoreAccess.IResearchStudyStore), () => new StoreAccess.ResearchStudyStore());
      callback.Invoke(typeof(StoreAccess.ISiteStore), () => new StoreAccess.SiteStore());
      callback.Invoke(typeof(StoreAccess.IDataEndpointStore), () => new StoreAccess.DataEndpointStore());
      callback.Invoke(typeof(StoreAccess.IInstitueRelatedOAuthConfigStore), () => new StoreAccess.InstitueRelatedOAuthConfigStore());
      callback.Invoke(typeof(StoreAccess.IInvolvedPersonStore), () => new StoreAccess.InvolvedPersonStore());
      callback.Invoke(typeof(StoreAccess.IInvolvementRoleStore), () => new StoreAccess.InvolvementRoleStore());
    }

  }

}
