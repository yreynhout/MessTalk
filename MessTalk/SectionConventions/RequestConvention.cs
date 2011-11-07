using IniParser;

namespace MessTalk.SectionConventions {
  public class RequestConvention : ISectionDataConvention {
    public bool IsMatchedBy(SectionData sectionData) {
      return sectionData.SectionName.EndsWith("Request");
    }
  }
}
