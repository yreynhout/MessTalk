using System.Collections.Generic;

namespace MessTalk.SectionConventions {
  public interface ISectionDataConventionFinder {
    IEnumerable<ISectionDataConvention> Find();
  }
}
