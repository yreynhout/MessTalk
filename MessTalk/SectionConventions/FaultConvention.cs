using IniParser;

namespace MessTalk.SectionConventions {
  public class FaultConvention : ISectionDataConvention {
    public bool IsMatchedBy(SectionData sectionData) {
      return sectionData.SectionName.EndsWith("Fault");
    }
  }
}
