using System.Collections.Generic;

namespace MessTalk.KeyConventions {
  public class DefaultKeyDataConventionFinder : IKeyDataConventionFinder {
    public IEnumerable<IKeyDataConvention> Find() {
      yield return new ImplementsConvention();
      yield return new PropertyConvention();
    }
  }
}
