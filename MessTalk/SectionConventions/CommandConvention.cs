using IniParser;

namespace MessTalk.SectionConventions {
  public class CommandConvention : ISectionDataConvention {
    public bool IsMatchedBy(SectionData sectionData) {
      return sectionData.SectionName.EndsWith("Command");
    }
  }
}
