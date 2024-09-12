/**
 * Contains arguments for calling 'GetInstituteUidByTitle'.
 */
export declare class GetInstituteUidByTitleRequest {
    instituteTitle: string;
}
/**
 * Contains results from calling 'GetInstituteUidByTitle'.
 */
export declare class GetInstituteUidByTitleResponse {
    fault?: string;
    return: string;
}
/**
 * Contains arguments for calling 'GetInstituteTitleByUid'.
 */
export declare class GetInstituteTitleByUidRequest {
    instituteUid: string;
}
/**
 * Contains results from calling 'GetInstituteTitleByUid'.
 */
export declare class GetInstituteTitleByUidResponse {
    fault?: string;
    return: string;
}
/**
 * Contains arguments for calling 'ArchiveInstitute'.
 */
export declare class ArchiveInstituteRequest {
    instituteUid: string;
}
/**
 * Contains results from calling 'ArchiveInstitute'.
 */
export declare class ArchiveInstituteResponse {
    fault?: string;
    return: string;
}
/**
 * Contains arguments for calling 'GetInstituteInfos'.
 */
export declare class GetInstituteInfosRequest {
    instituteUid: string;
}
/**
 * Contains results from calling 'GetInstituteInfos'.
 */
export declare class GetInstituteInfosResponse {
    fault?: string;
    return: string;
}
/**
 * Contains arguments for calling 'CreateInstituteIfMissing'.
 * Method: ensures, that an institute with the given Uid exists
 * and returns true, if it has been newly created
 */
export declare class CreateInstituteIfMissingRequest {
    instituteUid: string;
}
/**
 * Contains results from calling 'CreateInstituteIfMissing'.
 * Method: ensures, that an institute with the given Uid exists
 * and returns true, if it has been newly created
 */
export declare class CreateInstituteIfMissingResponse {
    fault?: string;
    return: boolean;
}
/**
 * Contains arguments for calling 'UpdateInstitueTitle'.
 * Method: updated the title of the the institute or returns false,
 * if there is no record for the given instituteUid
 */
export declare class UpdateInstitueTitleRequest {
    instituteUid: string;
    newTitle: string;
}
/**
 * Contains results from calling 'UpdateInstitueTitle'.
 * Method: updated the title of the the institute or returns false,
 * if there is no record for the given instituteUid
 */
export declare class UpdateInstitueTitleResponse {
    fault?: string;
    return: boolean;
}
/**
 * Contains arguments for calling 'GetApiVersion'.
 * Method: returns the version of the ORSCF specification which is implemented by this API,
 * (this can be used for backward compatibility within inhomogeneous infrastructures)
 */
export declare class GetApiVersionRequest {
}
/**
 * Contains results from calling 'GetApiVersion'.
 * Method: returns the version of the ORSCF specification which is implemented by this API,
 * (this can be used for backward compatibility within inhomogeneous infrastructures)
 */
export declare class GetApiVersionResponse {
    fault?: string;
    return: string;
}
/**
 * Contains arguments for calling 'GetCapabilities'.
 * Method: returns a list of API-features (there are several 'services' for different use cases, described by ORSCF)
 * supported by this implementation. The following values are possible:
 * 'InstituteMgmt', 'StudySetup', 'StudyAccess', 'SiteParticipation'
 */
export declare class GetCapabilitiesRequest {
}
/**
 * Contains results from calling 'GetCapabilities'.
 * Method: returns a list of API-features (there are several 'services' for different use cases, described by ORSCF)
 * supported by this implementation. The following values are possible:
 * 'InstituteMgmt', 'StudySetup', 'StudyAccess', 'SiteParticipation'
 */
export declare class GetCapabilitiesResponse {
    fault?: string;
    return: string[];
}
/**
 * Contains arguments for calling 'GetPermittedAuthScopes'.
 * Method: returns a list of available capabilities ("API:StudyAccess") and/or
 * data-scopes ("Study:9B2C3F48-2941-2F8F-4D35-7D117D5C6F72")
 * which are permitted for the CURRENT ACCESSOR and gives information about its 'authState', which can be:
 * 0=auth needed /
 * 1=authenticated /
 * -1=auth expired /
 * -2=auth invalid/disabled
 */
export declare class GetPermittedAuthScopesRequest {
}
/**
 * Contains results from calling 'GetPermittedAuthScopes'.
 * Method: returns a list of available capabilities ("API:StudyAccess") and/or
 * data-scopes ("Study:9B2C3F48-2941-2F8F-4D35-7D117D5C6F72")
 * which are permitted for the CURRENT ACCESSOR and gives information about its 'authState', which can be:
 * 0=auth needed /
 * 1=authenticated /
 * -1=auth expired /
 * -2=auth invalid/disabled
 */
export declare class GetPermittedAuthScopesResponse {
    authState: number;
    fault?: string;
    return: string[];
}
/**
 * Contains arguments for calling 'GetOAuthTokenRequestUrl'.
 * Method: OPTIONAL: If the authentication on the current service is mapped
 * using tokens and should provide information about the source at this point,
 * the login URL to be called up via browser (OAuth ['CIBA-Flow'](https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html)) is returned here.
 */
export declare class GetOAuthTokenRequestUrlRequest {
}
/**
 * Contains results from calling 'GetOAuthTokenRequestUrl'.
 * Method: OPTIONAL: If the authentication on the current service is mapped
 * using tokens and should provide information about the source at this point,
 * the login URL to be called up via browser (OAuth ['CIBA-Flow'](https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html)) is returned here.
 */
export declare class GetOAuthTokenRequestUrlResponse {
    fault?: string;
    return: string;
}
/**
 * Contains arguments for calling 'SubscribeStudyStateChangedEvents'.
 * Method: Subscribes the Event when the State of a Study was changed
 * to the given "EventQueue" which is accessable via "EventQueueService"
 * (including http notifications)
 */
export declare class SubscribeStudyStateChangedEventsRequest {
    eventQueueId: string;
}
/**
 * Contains results from calling 'SubscribeStudyStateChangedEvents'.
 * Method: Subscribes the Event when the State of a Study was changed
 * to the given "EventQueue" which is accessable via "EventQueueService"
 * (including http notifications)
 */
export declare class SubscribeStudyStateChangedEventsResponse {
    fault?: string;
    return: boolean;
}
/**
 * Contains arguments for calling 'UnsubscribeStudyStateChangedEvents'.
 * Method: Unsubscribes the Event when the State of a Study was changed
 * for the given "EventQueue"
 */
export declare class UnsubscribeStudyStateChangedEventsRequest {
    eventQueueId: string;
}
/**
 * Contains results from calling 'UnsubscribeStudyStateChangedEvents'.
 * Method: Unsubscribes the Event when the State of a Study was changed
 * for the given "EventQueue"
 */
export declare class UnsubscribeStudyStateChangedEventsResponse {
    fault?: string;
    return: boolean;
}
/**
 * Contains arguments for calling 'GetStudyTitleByIdentifier'.
 * Method: returns null, if there is no matching record
 */
export declare class GetStudyTitleByIdentifierRequest {
    studyIdentifier: string;
}
/**
 * Contains results from calling 'GetStudyTitleByIdentifier'.
 * Method: returns null, if there is no matching record
 */
export declare class GetStudyTitleByIdentifierResponse {
    fault?: string;
    return: string;
}
//# sourceMappingURL=dtos.d.ts.map