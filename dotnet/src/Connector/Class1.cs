using MedicalResearch.StudyManagement.v1;
using Newtonsoft.Json;
using System;
using System.Net;

namespace MedicalResearch.StudyManagement {

  public partial class SmsApiConnector {

    //public SmsApiConnector(string url, string apiToken) {

    //  if (!url.EndsWith("/")) {
    //    url = url + "/";
    //  }

    //  _InstituteMgmtClient = new InstituteMgmtClient(url + "instituteMgmt/", apiToken);
    //  _SiteParticipationClient = new SiteParticipationClient(url + "siteParticipation/", apiToken);
    //  _SmsApiInfoClient = new SmsApiInfoClient(url + "smsApiInfo/", apiToken);
    //  _StudyAccessClient = new StudyAccessClient(url + "studyAccess/", apiToken);
    //  _StudySetupClient = new StudySetupClient(url + "studySetup/", apiToken);

    //}

    //private IInstituteMgmtService _InstituteMgmtClient = null;
    ///// <summary> Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS) </summary>
    //public IInstituteMgmtService InstituteMgmt {
    //  get {
    //    return _InstituteMgmtClient;
    //  }
    //}

    //private SiteParticipationClient _SiteParticipationClient = null;
    ///// <summary> Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS) </summary>
    //public ISiteParticipationService SiteParticipation {
    //  get {
    //    return _SiteParticipationClient;
    //  }
    //}

    //private SmsApiInfoClient _SmsApiInfoClient = null;
    ///// <summary> Provides interoperability information for the current implementation </summary>
    //public ISmsApiInfoService SmsApiInfo {
    //  get {
    //    return _SmsApiInfoClient;
    //  }
    //}

    //private StudyAccessClient _StudyAccessClient = null;
    ///// <summary> Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS) </summary>
    //public IStudyAccessService StudyAccess {
    //  get {
    //    return _StudyAccessClient;
    //  }
    //}

    //private StudySetupClient _StudySetupClient = null;
    ///// <summary> Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS) </summary>
    //public IStudySetupService StudySetup {
    //  get {
    //    return _StudySetupClient;
    //  }
    //}

  }

}