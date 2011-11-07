using IniParser;

namespace MessTalk.SectionConventions {
  public class SectionDataInstance {
    readonly SectionData _sectionData;

    public SectionDataInstance(SectionData sectionData) {
      _sectionData = sectionData;
    }

    public bool Matches(ISectionDataConvention convention) {
      return convention.IsMatchedBy(_sectionData);
    }

    //public IConventionApplier Apply(ISectionDataConvention convention) {
    //  throw new NotImplementedException();
    //}
  }
}