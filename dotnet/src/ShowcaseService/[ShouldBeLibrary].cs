using MedicalResearch.StudyManagement.StoreAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Fuse.Ef;
using MedicalResearch.StudyManagement.Model;
using MedicalResearch.StudyManagement.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Data.Fuse.Convenience;
using System.Data.Fuse;
using MedicalResearch.StudyManagement.Persistence.EF;

//////////////////////////// SHOULD BE LIBRARY ////////////////////////////

namespace System.Data.Fuse { 

  public class FuseMappingProxy<TOuterModel, TInnerEntity, TKey> : IRepository<TOuterModel, TKey> 
    where TOuterModel : class 
    where TInnerEntity : class {

    //Wahleise das eine oder das andere
    private IRepository<TInnerEntity, TKey> _TypedRepo = null;
    private IUniversalRepository _UniversalRepo = null;

    public FuseMappingProxy(IRepository<TInnerEntity, TKey> innerRepository) {
      _TypedRepo = innerRepository;
    }

    public FuseMappingProxy(IUniversalRepository innerRepository) {
      _UniversalRepo = innerRepository;
    }

    #region " TODO - Implementierung fehlt noch!!! "

    public TOuterModel AddOrUpdateEntity(TOuterModel entity) {
      throw new NotImplementedException();
    }

    public Dictionary<string, object> AddOrUpdateEntityFields(Dictionary<string, object> fields) {
      throw new NotImplementedException();
    }

    public bool ContainsKey(TKey key) {
      throw new NotImplementedException();
    }

    public int Count(ExpressionTree filter) {
      throw new NotImplementedException();
    }

    public int CountAll() {
      throw new NotImplementedException();
    }

    public int CountBySearchExpression(string searchExpression) {
      throw new NotImplementedException();
    }

    public RepositoryCapabilities GetCapabilities() {
      throw new NotImplementedException();
    }

    public TOuterModel[] GetEntities(ExpressionTree filter, string[] sortedBy, int limit = 100, int skip = 0) {
      throw new NotImplementedException();
    }

    public TOuterModel[] GetEntitiesByKey(TKey[] keysToLoad) {
      throw new NotImplementedException();
    }

    public TOuterModel[] GetEntitiesBySearchExpression(string searchExpression, string[] sortedBy, int limit = 100, int skip = 0) {
      throw new NotImplementedException();
    }

    public Dictionary<string, object>[] GetEntityFields(ExpressionTree filter, string[] includedFieldNames, string[] sortedBy, int limit = 100, int skip = 0) {
      throw new NotImplementedException();
    }

    public Dictionary<string, object>[] GetEntityFieldsByKey(TKey[] keysToLoad, string[] includedFieldNames) {
      throw new NotImplementedException();
    }

    public Dictionary<string, object>[] GetEntityFieldsBySearchExpression(string searchExpression, string[] includedFieldNames, string[] sortedBy, int limit = 100, int skip = 0) {
      throw new NotImplementedException();
    }

    public EntityRef<TKey>[] GetEntityRefs(ExpressionTree filter, string[] sortedBy, int limit = 100, int skip = 0) {
      throw new NotImplementedException();
    }

    public EntityRef<TKey>[] GetEntityRefsByKey(TKey[] keysToLoad) {
      throw new NotImplementedException();
    }

    public EntityRef<TKey>[] GetEntityRefsBySearchExpression(string searchExpression, string[] sortedBy, int limit = 100, int skip = 0) {
      throw new NotImplementedException();
    }

    public string GetOriginIdentity() {
      throw new NotImplementedException();
    }

    public TKey[] Massupdate(ExpressionTree filter, Dictionary<string, object> fields) {
      throw new NotImplementedException();
    }

    public TKey[] MassupdateByKeys(TKey[] keysToUpdate, Dictionary<string, object> fields) {
      throw new NotImplementedException();
    }

    public TKey[] MassupdateBySearchExpression(string searchExpression, Dictionary<string, object> fields) {
      throw new NotImplementedException();
    }

    public TKey TryAddEntity(TOuterModel entity) {
      throw new NotImplementedException();
    }

    public TKey[] TryDeleteEntities(TKey[] keysToDelete) {
      throw new NotImplementedException();
    }

    public TOuterModel TryUpdateEntity(TOuterModel entity) {
      throw new NotImplementedException();
    }

    public Dictionary<string, object> TryUpdateEntityFields(Dictionary<string, object> fields) {
      throw new NotImplementedException();
    }

    public bool TryUpdateKey(TKey currentKey, TKey newKey) {
      throw new NotImplementedException();
    }

    #endregion

  }

}
