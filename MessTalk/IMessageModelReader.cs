using IniParser;

namespace MessTalk {
  public interface IMessageModelReader {
    MessageModel ReadFrom(IniData data);
  }
}
