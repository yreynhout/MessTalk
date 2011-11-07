using IniParser;

namespace MessTalk.SectionConventions {
  public class DataTypeConvention : ISectionDataConvention {
    public bool IsMatchedBy(SectionData sectionData) {
      return true;
    }
  }
}
