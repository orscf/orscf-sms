"use strict";
/* based on ORSCF StudyManagement Contract v1.8.0.0 */
Object.defineProperty(exports, "__esModule", { value: true });
exports.SmsConnector = exports.StudySetupClient = exports.StudyAccessClient = exports.SmsApiInfoClient = exports.SiteParticipationClient = exports.InstituteMgmtClient = void 0;
const axios_1 = require("axios");
/**
 * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
 */
class InstituteMgmtClient {
    constructor(rootUrlResolver, apiTokenResolver, httpPostMethod) {
        this.rootUrlResolver = rootUrlResolver;
        this.apiTokenResolver = apiTokenResolver;
        this.httpPostMethod = httpPostMethod;
    }
    getEndpointUrl() {
        let rootUrl = this.rootUrlResolver();
        if (rootUrl.endsWith('/')) {
            return rootUrl + 'instituteMgmt/';
        }
        else {
            return rootUrl + '/instituteMgmt/';
        }
    }
    /**
     * GetInstituteUidByTitle
     */
    getInstituteUidByTitle(instituteTitle) {
        let requestWrapper = {
            instituteTitle: instituteTitle
        };
        let url = this.getEndpointUrl() + 'getInstituteUidByTitle';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
    /**
     * GetInstituteTitleByUid
     */
    getInstituteTitleByUid(instituteUid) {
        let requestWrapper = {
            instituteUid: instituteUid
        };
        let url = this.getEndpointUrl() + 'getInstituteTitleByUid';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
    /**
     * ArchiveInstitute
     */
    archiveInstitute(instituteUid) {
        let requestWrapper = {
            instituteUid: instituteUid
        };
        let url = this.getEndpointUrl() + 'archiveInstitute';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
    /**
     * GetInstituteInfos
     */
    getInstituteInfos(instituteUid) {
        let requestWrapper = {
            instituteUid: instituteUid
        };
        let url = this.getEndpointUrl() + 'getInstituteInfos';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
    /**
     * ensures, that an institute with the given Uid exists and returns true, if it has been newly created
     */
    createInstituteIfMissing(instituteUid) {
        let requestWrapper = {
            instituteUid: instituteUid
        };
        let url = this.getEndpointUrl() + 'createInstituteIfMissing';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
    /**
     * updated the title of the the institute or returns false, if there is no record for the given instituteUid
     */
    updateInstitueTitle(instituteUid, newTitle) {
        let requestWrapper = {
            instituteUid: instituteUid,
            newTitle: newTitle
        };
        let url = this.getEndpointUrl() + 'updateInstitueTitle';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
}
exports.InstituteMgmtClient = InstituteMgmtClient;
/**
 * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
 */
class SiteParticipationClient {
    constructor(rootUrlResolver, apiTokenResolver, httpPostMethod) {
        this.rootUrlResolver = rootUrlResolver;
        this.apiTokenResolver = apiTokenResolver;
        this.httpPostMethod = httpPostMethod;
    }
    getEndpointUrl() {
        let rootUrl = this.rootUrlResolver();
        if (rootUrl.endsWith('/')) {
            return rootUrl + 'siteParticipation/';
        }
        else {
            return rootUrl + '/siteParticipation/';
        }
    }
}
exports.SiteParticipationClient = SiteParticipationClient;
/**
 * Provides interoperability information for the current implementation
 */
class SmsApiInfoClient {
    constructor(rootUrlResolver, apiTokenResolver, httpPostMethod) {
        this.rootUrlResolver = rootUrlResolver;
        this.apiTokenResolver = apiTokenResolver;
        this.httpPostMethod = httpPostMethod;
    }
    getEndpointUrl() {
        let rootUrl = this.rootUrlResolver();
        if (rootUrl.endsWith('/')) {
            return rootUrl + 'smsApiInfo/';
        }
        else {
            return rootUrl + '/smsApiInfo/';
        }
    }
    /**
     * returns the version of the ORSCF specification which is implemented by this API, (this can be used for backward compatibility within inhomogeneous infrastructures)
     */
    getApiVersion() {
        let requestWrapper = {};
        let url = this.getEndpointUrl() + 'getApiVersion';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
    /**
     * returns a list of API-features (there are several 'services' for different use cases, described by ORSCF) supported by this implementation. The following values are possible: 'InstituteMgmt', 'StudySetup', 'StudyAccess', 'SiteParticipation'
     */
    getCapabilities() {
        let requestWrapper = {};
        let url = this.getEndpointUrl() + 'getCapabilities';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
    /**
     * returns a list of available capabilities ("API:StudyAccess") and/or data-scopes ("Study:9B2C3F48-2941-2F8F-4D35-7D117D5C6F72") which are permitted for the CURRENT ACCESSOR and gives information about its 'authState', which can be: 0=auth needed / 1=authenticated / -1=auth expired / -2=auth invalid/disabled
     */
    getPermittedAuthScopes() {
        let requestWrapper = {};
        let url = this.getEndpointUrl() + 'getPermittedAuthScopes';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return { authState: responseWrapper.authState, return: responseWrapper.return };
        });
    }
    /**
     * OPTIONAL: If the authentication on the current service is mapped using tokens and should provide information about the source at this point, the login URL to be called up via browser (OAuth ['CIBA-Flow'](https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html)) is returned here.
     */
    getOAuthTokenRequestUrl() {
        let requestWrapper = {};
        let url = this.getEndpointUrl() + 'getOAuthTokenRequestUrl';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
}
exports.SmsApiInfoClient = SmsApiInfoClient;
/**
 * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
 */
class StudyAccessClient {
    constructor(rootUrlResolver, apiTokenResolver, httpPostMethod) {
        this.rootUrlResolver = rootUrlResolver;
        this.apiTokenResolver = apiTokenResolver;
        this.httpPostMethod = httpPostMethod;
    }
    getEndpointUrl() {
        let rootUrl = this.rootUrlResolver();
        if (rootUrl.endsWith('/')) {
            return rootUrl + 'studyAccess/';
        }
        else {
            return rootUrl + '/studyAccess/';
        }
    }
    /**
     * Subscribes the Event when the State of a Study was changed to the given "EventQueue" which is accessable via "EventQueueService" (including http notifications)
     */
    subscribeStudyStateChangedEvents(eventQueueId) {
        let requestWrapper = {
            eventQueueId: eventQueueId
        };
        let url = this.getEndpointUrl() + 'subscribeStudyStateChangedEvents';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
    /**
     * Unsubscribes the Event when the State of a Study was changed for the given "EventQueue"
     */
    unsubscribeStudyStateChangedEvents(eventQueueId) {
        let requestWrapper = {
            eventQueueId: eventQueueId
        };
        let url = this.getEndpointUrl() + 'unsubscribeStudyStateChangedEvents';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
}
exports.StudyAccessClient = StudyAccessClient;
/**
 * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
 */
class StudySetupClient {
    constructor(rootUrlResolver, apiTokenResolver, httpPostMethod) {
        this.rootUrlResolver = rootUrlResolver;
        this.apiTokenResolver = apiTokenResolver;
        this.httpPostMethod = httpPostMethod;
    }
    getEndpointUrl() {
        let rootUrl = this.rootUrlResolver();
        if (rootUrl.endsWith('/')) {
            return rootUrl + 'studySetup/';
        }
        else {
            return rootUrl + '/studySetup/';
        }
    }
    /**
     * returns null, if there is no matching record
     */
    getStudyTitleByIdentifier(studyIdentifier) {
        let requestWrapper = {
            studyIdentifier: studyIdentifier
        };
        let url = this.getEndpointUrl() + 'getStudyTitleByIdentifier';
        return this.httpPostMethod(url, requestWrapper, this.apiTokenResolver()).then((r) => {
            let responseWrapper = r;
            if (responseWrapper.fault) {
                console.warn('Request to "' + url + '" faulted: ' + responseWrapper.fault);
                throw { message: responseWrapper.fault };
            }
            return responseWrapper.return;
        });
    }
}
exports.StudySetupClient = StudySetupClient;
class SmsConnector {
    constructor(rootUrlResolver, apiTokenResolver, httpPostMethod) {
        this.rootUrlResolver = rootUrlResolver;
        this.apiTokenResolver = apiTokenResolver;
        this.httpPostMethod = httpPostMethod;
        if (this.httpPostMethod == null) {
            this.axiosHttpApi = axios_1.default.create({ baseURL: this.rootUrlResolver() });
            this.httpPostMethod = (url, requestObject, apiToken) => {
                if (!this.axiosHttpApi) {
                    this.axiosHttpApi = axios_1.default.create({ baseURL: this.rootUrlResolver() });
                }
                return this.axiosHttpApi.post(url, requestObject, {
                    headers: {
                        Authorization: apiToken
                    }
                });
            };
        }
        this.instituteMgmtClient = new InstituteMgmtClient(this.rootUrlResolver, this.apiTokenResolver, this.httpPostMethod);
        this.siteParticipationClient = new SiteParticipationClient(this.rootUrlResolver, this.apiTokenResolver, this.httpPostMethod);
        this.smsApiInfoClient = new SmsApiInfoClient(this.rootUrlResolver, this.apiTokenResolver, this.httpPostMethod);
        this.studyAccessClient = new StudyAccessClient(this.rootUrlResolver, this.apiTokenResolver, this.httpPostMethod);
        this.studySetupClient = new StudySetupClient(this.rootUrlResolver, this.apiTokenResolver, this.httpPostMethod);
    }
    getRootUrl() {
        let rootUrl = this.rootUrlResolver();
        if (rootUrl.endsWith('/')) {
            return rootUrl;
        }
        else {
            return rootUrl + '/';
        }
    }
    /**
     * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
     */
    get instituteMgmt() { return this.instituteMgmtClient; }
    /**
     * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
     */
    get siteParticipation() { return this.siteParticipationClient; }
    /**
     * Provides interoperability information for the current implementation
     */
    get smsApiInfo() { return this.smsApiInfoClient; }
    /**
     * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
     */
    get studyAccess() { return this.studyAccessClient; }
    /**
     * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
     */
    get studySetup() { return this.studySetupClient; }
}
exports.SmsConnector = SmsConnector;
//# sourceMappingURL=connector.js.map