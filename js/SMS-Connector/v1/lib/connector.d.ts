/**
 * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
 */
export declare class InstituteMgmtClient {
    private rootUrlResolver;
    private apiTokenResolver;
    private httpPostMethod;
    constructor(rootUrlResolver: () => string, apiTokenResolver: () => string, httpPostMethod: (url: string, requestObject: any, apiToken: string) => Promise<any>);
    private getEndpointUrl;
    /**
     * GetInstituteUidByTitle
     */
    getInstituteUidByTitle(instituteTitle: string): Promise<string>;
    /**
     * GetInstituteTitleByUid
     */
    getInstituteTitleByUid(instituteUid: string): Promise<string>;
    /**
     * ArchiveInstitute
     */
    archiveInstitute(instituteUid: string): Promise<string>;
    /**
     * GetInstituteInfos
     */
    getInstituteInfos(instituteUid: string): Promise<string>;
    /**
     * ensures, that an institute with the given Uid exists and returns true, if it has been newly created
     */
    createInstituteIfMissing(instituteUid: string): Promise<boolean>;
    /**
     * updated the title of the the institute or returns false, if there is no record for the given instituteUid
     */
    updateInstitueTitle(instituteUid: string, newTitle: string): Promise<boolean>;
}
/**
 * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
 */
export declare class SiteParticipationClient {
    private rootUrlResolver;
    private apiTokenResolver;
    private httpPostMethod;
    constructor(rootUrlResolver: () => string, apiTokenResolver: () => string, httpPostMethod: (url: string, requestObject: any, apiToken: string) => Promise<any>);
    private getEndpointUrl;
}
/**
 * Provides interoperability information for the current implementation
 */
export declare class SmsApiInfoClient {
    private rootUrlResolver;
    private apiTokenResolver;
    private httpPostMethod;
    constructor(rootUrlResolver: () => string, apiTokenResolver: () => string, httpPostMethod: (url: string, requestObject: any, apiToken: string) => Promise<any>);
    private getEndpointUrl;
    /**
     * returns the version of the ORSCF specification which is implemented by this API, (this can be used for backward compatibility within inhomogeneous infrastructures)
     */
    getApiVersion(): Promise<string>;
    /**
     * returns a list of API-features (there are several 'services' for different use cases, described by ORSCF) supported by this implementation. The following values are possible: 'InstituteMgmt', 'StudySetup', 'StudyAccess', 'SiteParticipation'
     */
    getCapabilities(): Promise<string[]>;
    /**
     * returns a list of available capabilities ("API:StudyAccess") and/or data-scopes ("Study:9B2C3F48-2941-2F8F-4D35-7D117D5C6F72") which are permitted for the CURRENT ACCESSOR and gives information about its 'authState', which can be: 0=auth needed / 1=authenticated / -1=auth expired / -2=auth invalid/disabled
     */
    getPermittedAuthScopes(): Promise<{
        authState: number;
        return: string[];
    }>;
    /**
     * OPTIONAL: If the authentication on the current service is mapped using tokens and should provide information about the source at this point, the login URL to be called up via browser (OAuth ['CIBA-Flow'](https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html)) is returned here.
     */
    getOAuthTokenRequestUrl(): Promise<string>;
}
/**
 * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
 */
export declare class StudyAccessClient {
    private rootUrlResolver;
    private apiTokenResolver;
    private httpPostMethod;
    constructor(rootUrlResolver: () => string, apiTokenResolver: () => string, httpPostMethod: (url: string, requestObject: any, apiToken: string) => Promise<any>);
    private getEndpointUrl;
    /**
     * Subscribes the Event when the State of a Study was changed to the given "EventQueue" which is accessable via "EventQueueService" (including http notifications)
     */
    subscribeStudyStateChangedEvents(eventQueueId: string): Promise<boolean>;
    /**
     * Unsubscribes the Event when the State of a Study was changed for the given "EventQueue"
     */
    unsubscribeStudyStateChangedEvents(eventQueueId: string): Promise<boolean>;
}
/**
 * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
 */
export declare class StudySetupClient {
    private rootUrlResolver;
    private apiTokenResolver;
    private httpPostMethod;
    constructor(rootUrlResolver: () => string, apiTokenResolver: () => string, httpPostMethod: (url: string, requestObject: any, apiToken: string) => Promise<any>);
    private getEndpointUrl;
    /**
     * returns null, if there is no matching record
     */
    getStudyTitleByIdentifier(studyIdentifier: string): Promise<string>;
}
export declare class SmsConnector {
    private rootUrlResolver;
    private apiTokenResolver;
    private httpPostMethod;
    private instituteMgmtClient;
    private siteParticipationClient;
    private smsApiInfoClient;
    private studyAccessClient;
    private studySetupClient;
    private axiosHttpApi?;
    constructor(rootUrlResolver: () => string, apiTokenResolver: () => string, httpPostMethod: (url: string, requestObject: any, apiToken: string) => Promise<any>);
    private getRootUrl;
    /**
     * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
     */
    get instituteMgmt(): InstituteMgmtClient;
    /**
     * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
     */
    get siteParticipation(): SiteParticipationClient;
    /**
     * Provides interoperability information for the current implementation
     */
    get smsApiInfo(): SmsApiInfoClient;
    /**
     * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
     */
    get studyAccess(): StudyAccessClient;
    /**
     * Provides an workflow-level API for interating with a 'StudyManagementSystem' (SMS)
     */
    get studySetup(): StudySetupClient;
}
//# sourceMappingURL=connector.d.ts.map