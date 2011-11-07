using System;
using IniParser;

namespace MessTalk.KeyConventions {
  public class EnumMemberConvention : IKeyDataConvention {
    public bool IsMatchedBy(KeyData keyData) {
      int parsed;
      return Int32.TryParse(keyData.Value, out parsed);
    }
  }
}
