using System.Collections.Generic;

namespace MessTalk.SectionConventions {
  public class DefaultSectionDataConventionFinder : ISectionDataConventionFinder {
    public IEnumerable<ISectionDataConvention> Find() {
      yield return new CommandConvention();
      yield return new EventConvention();
      yield return new FaultConvention();
      yield return new EnumConvention();
      yield return new RequestConvention();
      yield return new ResponseConvention();
      yield return new DataTypeConvention();
    }
  }
}