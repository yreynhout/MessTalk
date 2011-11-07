using IniParser;

namespace MessTalk.SectionConventions {
  public class FragmentConvention : ISectionDataConvention {
    public bool IsMatchedBy(SectionData sectionData) {
      return sectionData.SectionName.EndsWith("Fragment");
    }
  }
}
