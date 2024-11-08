# DataEndpointStore
Provides CRUD access to stored DataEndpoints (based on schema version '2.0.0')

### Methods:



## .GetOriginIdentity
Returns an string, representing the "Identity" of the current origin.
This can be used to discriminate multiple source repos.
(usually it should be related to a SCOPE like {DbServer}+{DbName/Schema}+{EntityName})
NOTE: This is an technical disciminator and it is not required, that it is an human-readable
"frieldly-name". It can just be an Hash or Uid, so its NOT RECOMMENDED to use it as display label!
no parameters
**return value:** String



## .GetCapabilities
Returns an property bag which holds information about the implemented/supported capabilities of this IRepository.
no parameters
**return value:** [RepositoryCapabilities](#RepositoryCapabilities)



## .GetEntityRefs
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityRefsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityRefsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|String[] *(array)*|**IN**-Param (required)|
**return value:** String[] *(array)*



## .GetEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [DataEndpoint](#DataEndpoint)[] *(array)*



## .GetEntitiesBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [DataEndpoint](#DataEndpoint)[] *(array)*



## .GetEntitiesByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|String[] *(array)*|**IN**-Param (required)|
**return value:** [DataEndpoint](#DataEndpoint)[] *(array)*



## .GetEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|String[] *(array)*|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required)|
**return value:** String[] *(array)*



## .CountAll
no parameters
**return value:** Int32



## .Count
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
**return value:** Int32



## .CountBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
**return value:** Int32



## .ContainsKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|key|String|**IN**-Param (required)|
**return value:** Boolean



## .AddOrUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .AddOrUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[DataEndpoint](#DataEndpoint)|**IN**-Param (required)|
**return value:** [DataEndpoint](#DataEndpoint)



## .TryUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .TryUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[DataEndpoint](#DataEndpoint)|**IN**-Param (required)|
**return value:** [DataEndpoint](#DataEndpoint)



## .TryAddEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[DataEndpoint](#DataEndpoint)|**IN**-Param (required)|
**return value:** String



## .MassupdateByKeys
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToUpdate|String[] *(array)*|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** String[] *(array)*



## .Massupdate
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** String[] *(array)*



## .MassupdateBySearchExpression
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** String[] *(array)*



## .TryDeleteEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToDelete|String[] *(array)*|**IN**-Param (required)|
**return value:** String[] *(array)*



## .TryUpdateKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|currentKey|String|**IN**-Param (required)|
|newKey|String|**IN**-Param (required)|
**return value:** Boolean
# InstituteStore
Provides CRUD access to stored Institutes (based on schema version '2.0.0')

### Methods:



## .GetOriginIdentity
Returns an string, representing the "Identity" of the current origin.
This can be used to discriminate multiple source repos.
(usually it should be related to a SCOPE like {DbServer}+{DbName/Schema}+{EntityName})
NOTE: This is an technical disciminator and it is not required, that it is an human-readable
"frieldly-name". It can just be an Hash or Uid, so its NOT RECOMMENDED to use it as display label!
no parameters
**return value:** String



## .GetCapabilities
Returns an property bag which holds information about the implemented/supported capabilities of this IRepository.
no parameters
**return value:** [RepositoryCapabilities](#RepositoryCapabilities)



## .GetEntityRefs
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .GetEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [Institute](#Institute)[] *(array)*



## .GetEntitiesBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [Institute](#Institute)[] *(array)*



## .GetEntitiesByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** [Institute](#Institute)[] *(array)*



## .GetEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required)|
**return value:** String[] *(array)*



## .CountAll
no parameters
**return value:** Int32



## .Count
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
**return value:** Int32



## .CountBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
**return value:** Int32



## .ContainsKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|key|Guid|**IN**-Param (required)|
**return value:** Boolean



## .AddOrUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .AddOrUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[Institute](#Institute)|**IN**-Param (required)|
**return value:** [Institute](#Institute)



## .TryUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .TryUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[Institute](#Institute)|**IN**-Param (required)|
**return value:** [Institute](#Institute)



## .TryAddEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[Institute](#Institute)|**IN**-Param (required)|
**return value:** Guid



## .MassupdateByKeys
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToUpdate|Guid[] *(array)*|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .Massupdate
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .MassupdateBySearchExpression
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryDeleteEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToDelete|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryUpdateKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|currentKey|Guid|**IN**-Param (required)|
|newKey|Guid|**IN**-Param (required)|
**return value:** Boolean
# InstitueRelatedOAuthConfigStore
Provides CRUD access to stored InstitueRelatedOAuthConfigs (based on schema version '2.0.0')

### Methods:



## .GetOriginIdentity
Returns an string, representing the "Identity" of the current origin.
This can be used to discriminate multiple source repos.
(usually it should be related to a SCOPE like {DbServer}+{DbName/Schema}+{EntityName})
NOTE: This is an technical disciminator and it is not required, that it is an human-readable
"frieldly-name". It can just be an Hash or Uid, so its NOT RECOMMENDED to use it as display label!
no parameters
**return value:** String



## .GetCapabilities
Returns an property bag which holds information about the implemented/supported capabilities of this IRepository.
no parameters
**return value:** [RepositoryCapabilities](#RepositoryCapabilities)



## .GetEntityRefs
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*



## .GetEntityRefsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*



## .GetEntityRefsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|[InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*|**IN**-Param (required): Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig|
**return value:** [InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*



## .GetEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [InstitueRelatedOAuthConfig](#InstitueRelatedOAuthConfig)[] *(array)*



## .GetEntitiesBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [InstitueRelatedOAuthConfig](#InstitueRelatedOAuthConfig)[] *(array)*



## .GetEntitiesByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|[InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*|**IN**-Param (required): Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig|
**return value:** [InstitueRelatedOAuthConfig](#InstitueRelatedOAuthConfig)[] *(array)*



## .GetEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|[InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*|**IN**-Param (required): Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig|
|includedFieldNames|String[] *(array)*|**IN**-Param (required)|
**return value:** String[] *(array)*



## .CountAll
no parameters
**return value:** Int32



## .Count
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
**return value:** Int32



## .CountBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
**return value:** Int32



## .ContainsKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|key|[InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)|**IN**-Param (required): Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig|
**return value:** Boolean



## .AddOrUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .AddOrUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[InstitueRelatedOAuthConfig](#InstitueRelatedOAuthConfig)|**IN**-Param (required)|
**return value:** [InstitueRelatedOAuthConfig](#InstitueRelatedOAuthConfig)



## .TryUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .TryUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[InstitueRelatedOAuthConfig](#InstitueRelatedOAuthConfig)|**IN**-Param (required)|
**return value:** [InstitueRelatedOAuthConfig](#InstitueRelatedOAuthConfig)



## .TryAddEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[InstitueRelatedOAuthConfig](#InstitueRelatedOAuthConfig)|**IN**-Param (required)|
**return value:** [InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)



## .MassupdateByKeys
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToUpdate|[InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*|**IN**-Param (required): Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** [InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*



## .Massupdate
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** [InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*



## .MassupdateBySearchExpression
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** [InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*



## .TryDeleteEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToDelete|[InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*|**IN**-Param (required): Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig|
**return value:** [InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)[] *(array)*



## .TryUpdateKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|currentKey|[InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)|**IN**-Param (required): Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig|
|newKey|[InstitueRelatedOAuthConfigIdentity](#InstitueRelatedOAuthConfigIdentity)|**IN**-Param (required): Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig|
**return value:** Boolean
# nstitueRelatedOAuthConfigIdentity
Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig

### Methods:



## .GetType
no parameters
**return value:** Type



## .ToString
no parameters
**return value:** String



## .Equals
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|obj|Object|**IN**-Param (required)|
**return value:** Boolean



## .GetHashCode
no parameters
**return value:** Int32
# ResearchStudyStore
Provides CRUD access to stored ResearchStudies (based on schema version '2.0.0')

### Methods:



## .GetOriginIdentity
Returns an string, representing the "Identity" of the current origin.
This can be used to discriminate multiple source repos.
(usually it should be related to a SCOPE like {DbServer}+{DbName/Schema}+{EntityName})
NOTE: This is an technical disciminator and it is not required, that it is an human-readable
"frieldly-name". It can just be an Hash or Uid, so its NOT RECOMMENDED to use it as display label!
no parameters
**return value:** String



## .GetCapabilities
Returns an property bag which holds information about the implemented/supported capabilities of this IRepository.
no parameters
**return value:** [RepositoryCapabilities](#RepositoryCapabilities)



## .GetEntityRefs
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .GetEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [ResearchStudy](#ResearchStudy)[] *(array)*



## .GetEntitiesBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [ResearchStudy](#ResearchStudy)[] *(array)*



## .GetEntitiesByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** [ResearchStudy](#ResearchStudy)[] *(array)*



## .GetEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required)|
**return value:** String[] *(array)*



## .CountAll
no parameters
**return value:** Int32



## .Count
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
**return value:** Int32



## .CountBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
**return value:** Int32



## .ContainsKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|key|Guid|**IN**-Param (required)|
**return value:** Boolean



## .AddOrUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .AddOrUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[ResearchStudy](#ResearchStudy)|**IN**-Param (required): entity, which relates to <see href="https://www.hl7.org/fhir/researchstudy.html">HL7.ResearchStudy</see>|
**return value:** [ResearchStudy](#ResearchStudy)



## .TryUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .TryUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[ResearchStudy](#ResearchStudy)|**IN**-Param (required): entity, which relates to <see href="https://www.hl7.org/fhir/researchstudy.html">HL7.ResearchStudy</see>|
**return value:** [ResearchStudy](#ResearchStudy)



## .TryAddEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[ResearchStudy](#ResearchStudy)|**IN**-Param (required): entity, which relates to <see href="https://www.hl7.org/fhir/researchstudy.html">HL7.ResearchStudy</see>|
**return value:** Guid



## .MassupdateByKeys
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToUpdate|Guid[] *(array)*|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .Massupdate
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .MassupdateBySearchExpression
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryDeleteEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToDelete|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryUpdateKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|currentKey|Guid|**IN**-Param (required)|
|newKey|Guid|**IN**-Param (required)|
**return value:** Boolean
# SiteStore
Provides CRUD access to stored Sites (based on schema version '2.0.0')

### Methods:



## .GetOriginIdentity
Returns an string, representing the "Identity" of the current origin.
This can be used to discriminate multiple source repos.
(usually it should be related to a SCOPE like {DbServer}+{DbName/Schema}+{EntityName})
NOTE: This is an technical disciminator and it is not required, that it is an human-readable
"frieldly-name". It can just be an Hash or Uid, so its NOT RECOMMENDED to use it as display label!
no parameters
**return value:** String



## .GetCapabilities
Returns an property bag which holds information about the implemented/supported capabilities of this IRepository.
no parameters
**return value:** [RepositoryCapabilities](#RepositoryCapabilities)



## .GetEntityRefs
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .GetEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [Site](#Site)[] *(array)*



## .GetEntitiesBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [Site](#Site)[] *(array)*



## .GetEntitiesByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** [Site](#Site)[] *(array)*



## .GetEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required)|
**return value:** String[] *(array)*



## .CountAll
no parameters
**return value:** Int32



## .Count
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
**return value:** Int32



## .CountBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
**return value:** Int32



## .ContainsKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|key|Guid|**IN**-Param (required)|
**return value:** Boolean



## .AddOrUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .AddOrUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[Site](#Site)|**IN**-Param (required)|
**return value:** [Site](#Site)



## .TryUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .TryUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[Site](#Site)|**IN**-Param (required)|
**return value:** [Site](#Site)



## .TryAddEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[Site](#Site)|**IN**-Param (required)|
**return value:** Guid



## .MassupdateByKeys
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToUpdate|Guid[] *(array)*|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .Massupdate
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .MassupdateBySearchExpression
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryDeleteEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToDelete|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryUpdateKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|currentKey|Guid|**IN**-Param (required)|
|newKey|Guid|**IN**-Param (required)|
**return value:** Boolean
# InvolvedPersonStore
Provides CRUD access to stored InvolvedPersons (based on schema version '2.0.0')

### Methods:



## .GetOriginIdentity
Returns an string, representing the "Identity" of the current origin.
This can be used to discriminate multiple source repos.
(usually it should be related to a SCOPE like {DbServer}+{DbName/Schema}+{EntityName})
NOTE: This is an technical disciminator and it is not required, that it is an human-readable
"frieldly-name". It can just be an Hash or Uid, so its NOT RECOMMENDED to use it as display label!
no parameters
**return value:** String



## .GetCapabilities
Returns an property bag which holds information about the implemented/supported capabilities of this IRepository.
no parameters
**return value:** [RepositoryCapabilities](#RepositoryCapabilities)



## .GetEntityRefs
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .GetEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [InvolvedPerson](#InvolvedPerson)[] *(array)*



## .GetEntitiesBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [InvolvedPerson](#InvolvedPerson)[] *(array)*



## .GetEntitiesByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** [InvolvedPerson](#InvolvedPerson)[] *(array)*



## .GetEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required)|
**return value:** String[] *(array)*



## .CountAll
no parameters
**return value:** Int32



## .Count
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
**return value:** Int32



## .CountBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
**return value:** Int32



## .ContainsKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|key|Guid|**IN**-Param (required)|
**return value:** Boolean



## .AddOrUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .AddOrUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[InvolvedPerson](#InvolvedPerson)|**IN**-Param (required)|
**return value:** [InvolvedPerson](#InvolvedPerson)



## .TryUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .TryUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[InvolvedPerson](#InvolvedPerson)|**IN**-Param (required)|
**return value:** [InvolvedPerson](#InvolvedPerson)



## .TryAddEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[InvolvedPerson](#InvolvedPerson)|**IN**-Param (required)|
**return value:** Guid



## .MassupdateByKeys
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToUpdate|Guid[] *(array)*|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .Massupdate
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .MassupdateBySearchExpression
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryDeleteEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToDelete|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryUpdateKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|currentKey|Guid|**IN**-Param (required)|
|newKey|Guid|**IN**-Param (required)|
**return value:** Boolean
# InvolvementRoleStore
Provides CRUD access to stored InvolvementRoles (based on schema version '2.0.0')

### Methods:



## .GetOriginIdentity
Returns an string, representing the "Identity" of the current origin.
This can be used to discriminate multiple source repos.
(usually it should be related to a SCOPE like {DbServer}+{DbName/Schema}+{EntityName})
NOTE: This is an technical disciminator and it is not required, that it is an human-readable
"frieldly-name". It can just be an Hash or Uid, so its NOT RECOMMENDED to use it as display label!
no parameters
**return value:** String



## .GetCapabilities
Returns an property bag which holds information about the implemented/supported capabilities of this IRepository.
no parameters
**return value:** [RepositoryCapabilities](#RepositoryCapabilities)



## .GetEntityRefs
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** Guid[] *(array)*



## .GetEntityRefsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .GetEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [InvolvementRole](#InvolvementRole)[] *(array)*



## .GetEntitiesBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** [InvolvementRole](#InvolvementRole)[] *(array)*



## .GetEntitiesByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
**return value:** [InvolvementRole](#InvolvementRole)[] *(array)*



## .GetEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required): An array of field names to be loaded|
|sortedBy|String[] *(array)*|**IN**-Param (required): An array of field names to be used for sorting the results (before 'limit' and 'skip' is processed). Use the character "^" as prefix for DESC sorting. Sample: ['^Age','Lastname']|
|limit|Int32?|**IN**-Param (optional)|
|skip|Int32?|**IN**-Param (optional)|
**return value:** String[] *(array)*



## .GetEntityFieldsByKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToLoad|Guid[] *(array)*|**IN**-Param (required)|
|includedFieldNames|String[] *(array)*|**IN**-Param (required)|
**return value:** String[] *(array)*



## .CountAll
no parameters
**return value:** Int32



## .Count
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
**return value:** Int32



## .CountBySearchExpression
NOTE: this method can only be used, if the 'SupportsStringBaseSearchExpressions'-Capability is given for this repository!
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
**return value:** Int32



## .ContainsKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|key|Guid|**IN**-Param (required)|
**return value:** Boolean



## .AddOrUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .AddOrUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[InvolvementRole](#InvolvementRole)|**IN**-Param (required)|
**return value:** [InvolvementRole](#InvolvementRole)



## .TryUpdateEntityFields
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** *Dict*<String,Object>



## .TryUpdateEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[InvolvementRole](#InvolvementRole)|**IN**-Param (required)|
**return value:** [InvolvementRole](#InvolvementRole)



## .TryAddEntity
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|entity|[InvolvementRole](#InvolvementRole)|**IN**-Param (required)|
**return value:** Guid



## .MassupdateByKeys
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToUpdate|Guid[] *(array)*|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .Massupdate
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|filter|[ExpressionTree](#ExpressionTree)|**IN**-Param (required): (from 'FUSE-fx.RepositoryContract')|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .MassupdateBySearchExpression
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|searchExpression|String|**IN**-Param (required)|
|fields|*Dict*<String,Object>|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryDeleteEntities
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|keysToDelete|Guid[] *(array)*|**IN**-Param (required)|
**return value:** Guid[] *(array)*



## .TryUpdateKey
#### Parameters:
|Name|Type|Description|
|----|----|-----------|
|currentKey|Guid|**IN**-Param (required)|
|newKey|Guid|**IN**-Param (required)|
**return value:** Boolean



# Models:



## DataEndpoint
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|Url|String|(required)|
|Label|String|(required)|
|OwnerInstituteUid|Guid|(required)|
|PublicResolvable|Boolean|(required)|
|EndpointType|String|(required)|
|OAuthUrl|String|(required)|



## InstitueRelatedOAuthConfig
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|InstituteUid|Guid|(required)|
|DataEndpointUrl|String|(required)|
|OAuthClientId|String|(required)|
|OAuthClientSecret|String|(required)|
|OAuthScopesRequired|String|(required)|



## Institute
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|InstituteUid|Guid|(required): An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more!|
|DisplayLabel|String|(required): An DisplayLabel which is dedicated for the usage within the frontend of study managent software. Note that this short name representation hat the caracter of an internal shortcurt and could be ambiguous. The usage for legal-relevant/official communication or documents is not recommended, as well as the usage for technical identification of this record. *this field has a max length of 100|
|IsArchived|Boolean|(required)|
|PrivateSdrUrl|String|(optional): *this field is optional (use null as value)|
|PrivateWdrUrl|String|(optional): *this field is optional (use null as value)|
|PrivateVdrUrl|String|(optional): *this field is optional (use null as value)|
|PrivateBdrUrl|String|(optional): *this field is optional (use null as value)|



## InvolvedPerson
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|InvolvedPersonUid|Guid|(required): An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more!|
|DisplayLabel|String|(optional): *this field is optional (use null as value)|
|EmailAddress|Guid|(optional): *this field is optional|
|IsArchived|Boolean|(required)|



## InvolvementRole
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|InvolvedPersonRoleUid|Guid|(required): An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more!|
|ResearchStudyUid|Guid|(required)|
|Role|String|(optional): *this field is optional (use null as value)|
|InvolvedFrom|DateTime|(optional): *this field is optional|
|InvolvedUntil|DateTime|(optional): *this field is optional|
|DedicatedToSiteUid|Guid|(optional): null indicated a site independent global role *this field is optional|
|InvolvedPersonUid|Guid|(required)|



## ResearchStudy
entity, which relates to [HL7.ResearchStudy](https://www.hl7.org/fhir/researchstudy.html)
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|ResearchStudyUid|Guid|(required): An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more!|
|DisplayLabel|String|(required): An DisplayLabel which is dedicated for the usage within the frontend of study managent software. Note that this short name representation hat the caracter of an internal shortcurt and could be ambiguous. The usage for legal-relevant/official communication or documents is not recommended, as well as the usage for technical identification of this record. *this field has a max length of 100|
|InitiatorInstituteUid|Guid|(required)|
|StudyWorkflowName|String|(required)|
|StudyWorkflowVersion|String|(required)|
|Phase|String|(optional): AS DECLARED BY <see href="https://www.hl7.org/fhir/valueset-research-study-phase.html">HL7.ResearchStudyPhase</see>: n-a | early-phase-1 | phase-1 | phase-1-phase-2 | phase-2 | phase-2-phase-3 | phase-3 | phase-4 *this field is optional (use null as value)|
|StartDate|DateTime|(optional): a estimated date in future is possible *this field is optional|
|TerminationDate|DateTime|(optional): a estimated date in future is possible *this field is optional|
|SubjectIdentifierTitle|String|(required): A title which informs about the sematic of the SubjectIdentifer (which concrete value is used): "Randomization-Number", "Screening-Number", ...|
|Status|String|(required): AS DECLARED BY <see href="https://www.hl7.org/fhir/valueset-research-study-status.html">HL7.ResearchStudyStatus</see>: active | administratively-completed | approved | closed-to-accrual | closed-to-accrual-and-intervention | completed | disapproved | in-review | temporarily-closed-to-accrual | temporarily-closed-to-accrual-and-intervention | withdrawn|
|TerminatedReason|String|(optional): *this field is optional (use null as value)|
|IsArchived|Boolean|(required)|
|InitiatorRelatedProjectNumber|String|(optional): *this field is optional (use null as value)|
|SdrUrl|String|(optional): usually provided by the Sponsor *this field is optional (use null as value)|
|ImsUrl|String|(optional): usually provided by the Sponsor *this field is optional (use null as value)|
|WdrUrl|String|(optional): usually provided by the Sponsor *this field is optional (use null as value)|
|VdrUrl|String|(optional): usually provided by the Sponsor *this field is optional (use null as value)|
|BdrUrl|String|(optional): usually provided by the Sponsor *this field is optional (use null as value)|



## Site
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|SiteUid|Guid|(required): An <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> which can be generated by any origin system and is used to address this ORSCF conform data record in decentralized environments. Note that this Identity must not be changed any more!|
|RepresentingInstituteUid|Guid|(required): <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> of the institute, which is representing this site|
|ResearchStudyUid|Guid|(required): <see href="https://de.wikipedia.org/wiki/Universally_Unique_Identifier">Universally Unique Identifier</see> of the related record|
|EnrollmentDate|DateTime|(optional): a estimated date in future is possible *this field is optional|
|TerminationDate|DateTime|(optional): a estimated date in future is possible *this field is optional|
|TerminatedReason|String|(optional): *this field is optional (use null as value)|
|StudyRelatedSiteIdentifer|String|(required): Offical 'SiteIdentifier' which is unique within the scope of the related study|
|DisplayLabel|String|(required): An DisplayLabel which is dedicated for the usage within the frontend of study managent software. Note that this short name representation hat the caracter of an internal shortcurt and could be ambiguous. The usage for legal-relevant/official communication or documents is not recommended, as well as the usage for technical identification of this record.|
|Status|String|(required): AS DECLARED BY HL7|
|SiteRelatedProjectNumber|String|(optional): *this field is optional (use null as value)|
|DedicatedSdrUrl|String|(optional): *this field is optional (use null as value)|
|DedicatedVdrUrl|String|(optional): *this field is optional (use null as value)|
|DedicatedBdrUrl|String|(optional): *this field is optional (use null as value)|



## InstitueRelatedOAuthConfigIdentity
Composite Key, which represents the primary identity of a InstitueRelatedOAuthConfig
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|(none)|||



## ExpressionTree
(from 'FUSE-fx.RepositoryContract')
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|MatchAll|Boolean|(optional): true: AND-Relation | false: OR-Relation|
|Negate|Boolean|(optional): Negates the result|
|Predicates|*List*<[FieldPredicate](#FieldPredicate)>|(optional): Can contain ATOMIC predicates (FieldName~Value). NOTE: If there is more than one predicate with the same FieldName in combination with MatchAll=true, then this will lead to an subordinated OR-Expression dedicated to this field.|
|SubTree|*List*<[ExpressionTree](#ExpressionTree)>|(optional)|



## FieldPredicate
(from 'FUSE-fx.RepositoryContract')
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|FieldName|String|(optional)|
|Operator|String|(optional): Wellknown operators like '==' '!=' (see 'FieldOperators'-Contants).|
|Value|Object|(optional): The value to match! (NOTE: in th special case of using the 'in' operator, the given 'value' to match must NOT be scalar! Instead it must be an ARRAY. A match is given if a field equals to at least one value within that array.)|



## RepositoryCapabilities
(from 'FUSE-fx.RepositoryContract')
An property bag which holds information about the implemented/supported
capabilities of an IRepository.
#### Fields:
|Name|Type|Description|
|----|----|-----------|
|CanReadContent|Boolean|(optional): Indicates, that this repository offers access to load entities(classes) or some their entity fields (if this is false, then only EntityRefs are accessable)|
|CanUpdateContent|Boolean|(optional)|
|CanAddNewEntities|Boolean|(optional)|
|CanDeleteEntities|Boolean|(optional)|
|SupportsMassupdate|Boolean|(optional)|
|SupportsKeyUpdate|Boolean|(optional)|
|SupportsStringBasedSearchExpressions|Boolean|(optional)|
|RequiresExternalKeys|Boolean|(optional): Indicates, that entities can only be added to this repository, if ther key fields are pre-initialized by the caller. If false, then the persistence-technology behind the repository implementation will auto-generate a new key by its own.|
