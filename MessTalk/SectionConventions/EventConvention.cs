using IniParser;

namespace MessTalk.SectionConventions {
  public class EventConvention : ISectionDataConvention {
    public bool IsMatchedBy(SectionData sectionData) {
      return sectionData.SectionName.EndsWith("Event");
    }
  }
}
