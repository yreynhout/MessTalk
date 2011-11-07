using IniParser;

namespace MessTalk.KeyConventions {
  public class PropertyConvention : IKeyDataConvention {
    public bool IsMatchedBy(KeyData keyData) {
      return true;
    }
  }
}
