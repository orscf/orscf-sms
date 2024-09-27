using MedicalResearch.StudyManagement.Model;
using System.Data.Fuse;
using System.Data.ModelDescription;

namespace MedicalResearch.StudyManagement.v1 {
  public static class SchemaProvider {
    public static SchemaRoot GetSchemaRoot() {
      return ModelReader.GetSchema(
          typeof(ResearchStudy).Assembly,
          new string[] { typeof(ResearchStudy).Name, typeof(Institute).Name, typeof(DataEndpoint).Name }
        );
    }
  }
}
