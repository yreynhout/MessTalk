using System.Collections.Generic;

namespace MessTalk.KeyConventions {
  public interface IKeyDataConventionFinder {
    IEnumerable<IKeyDataConvention> Find();
  }
}
