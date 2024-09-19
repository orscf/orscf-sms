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

namespace MedicalResearch.StudyManagement {

  public class InstituteEntityStore : EfRepository<InstituteEntity, Guid> {

    private InstituteEntityStore(DbContext dbContext) : base(dbContext) {
    }

    public static IRepository<Institute, Guid> CreateProxy() {

      //TODO: woher kommt eine fassade,
      //die nach außen das model (Institute) und
      //in richtung ef die InstituteEntity nutzt===

     

      return null;

    }


  }

}
