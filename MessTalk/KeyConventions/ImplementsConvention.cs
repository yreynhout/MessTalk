using IniParser;

namespace MessTalk.KeyConventions {
  public class ImplementsConvention : IKeyDataConvention {
    public bool IsMatchedBy(KeyData keyData) {
      return keyData.KeyName.Equals("_Implements");
    }
  }
}
