using System.Collections.Generic;

namespace MessTalk.KeyConventions {
  public class EnumKeyDataConventionFinder : IKeyDataConventionFinder {
    public IEnumerable<IKeyDataConvention> Find() {
      yield return new EnumMemberConvention();
    }
  }
}