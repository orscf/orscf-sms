"use strict";
/* based on ORSCF StudyManagement Contract v1.8.0.0 */
Object.defineProperty(exports, "__esModule", { value: true });
exports.GetStudyTitleByIdentifierResponse = exports.GetStudyTitleByIdentifierRequest = exports.UnsubscribeStudyStateChangedEventsResponse = exports.UnsubscribeStudyStateChangedEventsRequest = exports.SubscribeStudyStateChangedEventsResponse = exports.SubscribeStudyStateChangedEventsRequest = exports.GetOAuthTokenRequestUrlResponse = exports.GetOAuthTokenRequestUrlRequest = exports.GetPermittedAuthScopesResponse = exports.GetPermittedAuthScopesRequest = exports.GetCapabilitiesResponse = exports.GetCapabilitiesRequest = exports.GetApiVersionResponse = exports.GetApiVersionRequest = exports.UpdateInstitueTitleResponse = exports.UpdateInstitueTitleRequest = exports.CreateInstituteIfMissingResponse = exports.CreateInstituteIfMissingRequest = exports.GetInstituteInfosResponse = exports.GetInstituteInfosRequest = exports.ArchiveInstituteResponse = exports.ArchiveInstituteRequest = exports.GetInstituteTitleByUidResponse = exports.GetInstituteTitleByUidRequest = exports.GetInstituteUidByTitleResponse = exports.GetInstituteUidByTitleRequest = void 0;
/**
 * Contains arguments for calling 'GetInstituteUidByTitle'.
 */
var GetInstituteUidByTitleRequest = /** @class */ (function () {
    function GetInstituteUidByTitleRequest() {
        // Required Argument for 'GetInstituteUidByTitle' (string)
        this.instituteTitle = '';
    }
    return GetInstituteUidByTitleRequest;
}());
exports.GetInstituteUidByTitleRequest = GetInstituteUidByTitleRequest;
/**
 * Contains results from calling 'GetInstituteUidByTitle'.
 */
var GetInstituteUidByTitleResponse = /** @class */ (function () {
    function GetInstituteUidByTitleResponse() {
        // Return-Value of 'GetInstituteUidByTitle' (Guid)
        this.return = '';
    }
    return GetInstituteUidByTitleResponse;
}());
exports.GetInstituteUidByTitleResponse = GetInstituteUidByTitleResponse;
/**
 * Contains arguments for calling 'GetInstituteTitleByUid'.
 */
var GetInstituteTitleByUidRequest = /** @class */ (function () {
    function GetInstituteTitleByUidRequest() {
        // Required Argument for 'GetInstituteTitleByUid' (string)
        this.instituteUid = '';
    }
    return GetInstituteTitleByUidRequest;
}());
exports.GetInstituteTitleByUidRequest = GetInstituteTitleByUidRequest;
/**
 * Contains results from calling 'GetInstituteTitleByUid'.
 */
var GetInstituteTitleByUidResponse = /** @class */ (function () {
    function GetInstituteTitleByUidResponse() {
        // Return-Value of 'GetInstituteTitleByUid' (String)
        this.return = '';
    }
    return GetInstituteTitleByUidResponse;
}());
exports.GetInstituteTitleByUidResponse = GetInstituteTitleByUidResponse;
/**
 * Contains arguments for calling 'ArchiveInstitute'.
 */
var ArchiveInstituteRequest = /** @class */ (function () {
    function ArchiveInstituteRequest() {
        // Required Argument for 'ArchiveInstitute' (string)
        this.instituteUid = '';
    }
    return ArchiveInstituteRequest;
}());
exports.ArchiveInstituteRequest = ArchiveInstituteRequest;
/**
 * Contains results from calling 'ArchiveInstitute'.
 */
var ArchiveInstituteResponse = /** @class */ (function () {
    function ArchiveInstituteResponse() {
        // Return-Value of 'ArchiveInstitute' (String)
        this.return = '';
    }
    return ArchiveInstituteResponse;
}());
exports.ArchiveInstituteResponse = ArchiveInstituteResponse;
/**
 * Contains arguments for calling 'GetInstituteInfos'.
 */
var GetInstituteInfosRequest = /** @class */ (function () {
    function GetInstituteInfosRequest() {
        // Required Argument for 'GetInstituteInfos' (string)
        this.instituteUid = '';
    }
    return GetInstituteInfosRequest;
}());
exports.GetInstituteInfosRequest = GetInstituteInfosRequest;
/**
 * Contains results from calling 'GetInstituteInfos'.
 */
var GetInstituteInfosResponse = /** @class */ (function () {
    function GetInstituteInfosResponse() {
        // Return-Value of 'GetInstituteInfos' (String)
        this.return = '';
    }
    return GetInstituteInfosResponse;
}());
exports.GetInstituteInfosResponse = GetInstituteInfosResponse;
/**
 * Contains arguments for calling 'CreateInstituteIfMissing'.
 * Method: ensures, that an institute with the given Uid exists
 * and returns true, if it has been newly created
 */
var CreateInstituteIfMissingRequest = /** @class */ (function () {
    function CreateInstituteIfMissingRequest() {
        // Required Argument for 'CreateInstituteIfMissing' (string)
        this.instituteUid = '';
    }
    return CreateInstituteIfMissingRequest;
}());
exports.CreateInstituteIfMissingRequest = CreateInstituteIfMissingRequest;
/**
 * Contains results from calling 'CreateInstituteIfMissing'.
 * Method: ensures, that an institute with the given Uid exists
 * and returns true, if it has been newly created
 */
var CreateInstituteIfMissingResponse = /** @class */ (function () {
    function CreateInstituteIfMissingResponse() {
        // Return-Value of 'CreateInstituteIfMissing' (Boolean)
        this.return = false;
    }
    return CreateInstituteIfMissingResponse;
}());
exports.CreateInstituteIfMissingResponse = CreateInstituteIfMissingResponse;
/**
 * Contains arguments for calling 'UpdateInstitueTitle'.
 * Method: updated the title of the the institute or returns false,
 * if there is no record for the given instituteUid
 */
var UpdateInstitueTitleRequest = /** @class */ (function () {
    function UpdateInstitueTitleRequest() {
        // Required Argument for 'UpdateInstitueTitle' (string)
        this.instituteUid = '';
        // Required Argument for 'UpdateInstitueTitle' (string)
        this.newTitle = '';
    }
    return UpdateInstitueTitleRequest;
}());
exports.UpdateInstitueTitleRequest = UpdateInstitueTitleRequest;
/**
 * Contains results from calling 'UpdateInstitueTitle'.
 * Method: updated the title of the the institute or returns false,
 * if there is no record for the given instituteUid
 */
var UpdateInstitueTitleResponse = /** @class */ (function () {
    function UpdateInstitueTitleResponse() {
        // Return-Value of 'UpdateInstitueTitle' (Boolean)
        this.return = false;
    }
    return UpdateInstitueTitleResponse;
}());
exports.UpdateInstitueTitleResponse = UpdateInstitueTitleResponse;
/**
 * Contains arguments for calling 'GetApiVersion'.
 * Method: returns the version of the ORSCF specification which is implemented by this API,
 * (this can be used for backward compatibility within inhomogeneous infrastructures)
 */
var GetApiVersionRequest = /** @class */ (function () {
    function GetApiVersionRequest() {
    }
    return GetApiVersionRequest;
}());
exports.GetApiVersionRequest = GetApiVersionRequest;
/**
 * Contains results from calling 'GetApiVersion'.
 * Method: returns the version of the ORSCF specification which is implemented by this API,
 * (this can be used for backward compatibility within inhomogeneous infrastructures)
 */
var GetApiVersionResponse = /** @class */ (function () {
    function GetApiVersionResponse() {
        // Return-Value of 'GetApiVersion' (String)
        this.return = '';
    }
    return GetApiVersionResponse;
}());
exports.GetApiVersionResponse = GetApiVersionResponse;
/**
 * Contains arguments for calling 'GetCapabilities'.
 * Method: returns a list of API-features (there are several 'services' for different use cases, described by ORSCF)
 * supported by this implementation. The following values are possible:
 * 'InstituteMgmt', 'StudySetup', 'StudyAccess', 'SiteParticipation'
 */
var GetCapabilitiesRequest = /** @class */ (function () {
    function GetCapabilitiesRequest() {
    }
    return GetCapabilitiesRequest;
}());
exports.GetCapabilitiesRequest = GetCapabilitiesRequest;
/**
 * Contains results from calling 'GetCapabilities'.
 * Method: returns a list of API-features (there are several 'services' for different use cases, described by ORSCF)
 * supported by this implementation. The following values are possible:
 * 'InstituteMgmt', 'StudySetup', 'StudyAccess', 'SiteParticipation'
 */
var GetCapabilitiesResponse = /** @class */ (function () {
    function GetCapabilitiesResponse() {
        // Return-Value of 'GetCapabilities' (String[])
        this.return = [];
    }
    return GetCapabilitiesResponse;
}());
exports.GetCapabilitiesResponse = GetCapabilitiesResponse;
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
var GetPermittedAuthScopesRequest = /** @class */ (function () {
    function GetPermittedAuthScopesRequest() {
    }
    return GetPermittedAuthScopesRequest;
}());
exports.GetPermittedAuthScopesRequest = GetPermittedAuthScopesRequest;
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
var GetPermittedAuthScopesResponse = /** @class */ (function () {
    function GetPermittedAuthScopesResponse() {
        // Out-Argument of 'GetPermittedAuthScopes' (number)
        this.authState = 0;
        // Return-Value of 'GetPermittedAuthScopes' (String[])
        this.return = [];
    }
    return GetPermittedAuthScopesResponse;
}());
exports.GetPermittedAuthScopesResponse = GetPermittedAuthScopesResponse;
/**
 * Contains arguments for calling 'GetOAuthTokenRequestUrl'.
 * Method: OPTIONAL: If the authentication on the current service is mapped
 * using tokens and should provide information about the source at this point,
 * the login URL to be called up via browser (OAuth ['CIBA-Flow'](https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html)) is returned here.
 */
var GetOAuthTokenRequestUrlRequest = /** @class */ (function () {
    function GetOAuthTokenRequestUrlRequest() {
    }
    return GetOAuthTokenRequestUrlRequest;
}());
exports.GetOAuthTokenRequestUrlRequest = GetOAuthTokenRequestUrlRequest;
/**
 * Contains results from calling 'GetOAuthTokenRequestUrl'.
 * Method: OPTIONAL: If the authentication on the current service is mapped
 * using tokens and should provide information about the source at this point,
 * the login URL to be called up via browser (OAuth ['CIBA-Flow'](https://openid.net/specs/openid-client-initiated-backchannel-authentication-core-1_0.html)) is returned here.
 */
var GetOAuthTokenRequestUrlResponse = /** @class */ (function () {
    function GetOAuthTokenRequestUrlResponse() {
        // Return-Value of 'GetOAuthTokenRequestUrl' (String)
        this.return = '';
    }
    return GetOAuthTokenRequestUrlResponse;
}());
exports.GetOAuthTokenRequestUrlResponse = GetOAuthTokenRequestUrlResponse;
/**
 * Contains arguments for calling 'SubscribeStudyStateChangedEvents'.
 * Method: Subscribes the Event when the State of a Study was changed
 * to the given "EventQueue" which is accessable via "EventQueueService"
 * (including http notifications)
 */
var SubscribeStudyStateChangedEventsRequest = /** @class */ (function () {
    function SubscribeStudyStateChangedEventsRequest() {
        // Required Argument for 'SubscribeStudyStateChangedEvents' (string)
        this.eventQueueId = '';
    }
    return SubscribeStudyStateChangedEventsRequest;
}());
exports.SubscribeStudyStateChangedEventsRequest = SubscribeStudyStateChangedEventsRequest;
/**
 * Contains results from calling 'SubscribeStudyStateChangedEvents'.
 * Method: Subscribes the Event when the State of a Study was changed
 * to the given "EventQueue" which is accessable via "EventQueueService"
 * (including http notifications)
 */
var SubscribeStudyStateChangedEventsResponse = /** @class */ (function () {
    function SubscribeStudyStateChangedEventsResponse() {
        // Return-Value of 'SubscribeStudyStateChangedEvents' (Boolean)
        this.return = false;
    }
    return SubscribeStudyStateChangedEventsResponse;
}());
exports.SubscribeStudyStateChangedEventsResponse = SubscribeStudyStateChangedEventsResponse;
/**
 * Contains arguments for calling 'UnsubscribeStudyStateChangedEvents'.
 * Method: Unsubscribes the Event when the State of a Study was changed
 * for the given "EventQueue"
 */
var UnsubscribeStudyStateChangedEventsRequest = /** @class */ (function () {
    function UnsubscribeStudyStateChangedEventsRequest() {
        // Required Argument for 'UnsubscribeStudyStateChangedEvents' (string)
        this.eventQueueId = '';
    }
    return UnsubscribeStudyStateChangedEventsRequest;
}());
exports.UnsubscribeStudyStateChangedEventsRequest = UnsubscribeStudyStateChangedEventsRequest;
/**
 * Contains results from calling 'UnsubscribeStudyStateChangedEvents'.
 * Method: Unsubscribes the Event when the State of a Study was changed
 * for the given "EventQueue"
 */
var UnsubscribeStudyStateChangedEventsResponse = /** @class */ (function () {
    function UnsubscribeStudyStateChangedEventsResponse() {
        // Return-Value of 'UnsubscribeStudyStateChangedEvents' (Boolean)
        this.return = false;
    }
    return UnsubscribeStudyStateChangedEventsResponse;
}());
exports.UnsubscribeStudyStateChangedEventsResponse = UnsubscribeStudyStateChangedEventsResponse;
/**
 * Contains arguments for calling 'GetStudyTitleByIdentifier'.
 * Method: returns null, if there is no matching record
 */
var GetStudyTitleByIdentifierRequest = /** @class */ (function () {
    function GetStudyTitleByIdentifierRequest() {
        // Required Argument for 'GetStudyTitleByIdentifier' (string)
        this.studyIdentifier = '';
    }
    return GetStudyTitleByIdentifierRequest;
}());
exports.GetStudyTitleByIdentifierRequest = GetStudyTitleByIdentifierRequest;
/**
 * Contains results from calling 'GetStudyTitleByIdentifier'.
 * Method: returns null, if there is no matching record
 */
var GetStudyTitleByIdentifierResponse = /** @class */ (function () {
    function GetStudyTitleByIdentifierResponse() {
        // Return-Value of 'GetStudyTitleByIdentifier' (String)
        this.return = '';
    }
    return GetStudyTitleByIdentifierResponse;
}());
exports.GetStudyTitleByIdentifierResponse = GetStudyTitleByIdentifierResponse;
//# sourceMappingURL=dtos.js.map