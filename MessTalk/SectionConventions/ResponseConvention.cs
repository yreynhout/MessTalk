using IniParser;

namespace MessTalk.SectionConventions {
  public class ResponseConvention : ISectionDataConvention {
    public bool IsMatchedBy(SectionData sectionData) {
      return sectionData.SectionName.EndsWith("Response");
    }
  }
}
