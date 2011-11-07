using IniParser;

namespace MessTalk.KeyConventions {
  public interface IKeyDataConvention {
    bool IsMatchedBy(KeyData keyData);
  }
}
