using System;
using System.Linq;
using IniParser;

namespace MessTalk.SectionConventions {
  public class EnumConvention : ISectionDataConvention {
    public bool IsMatchedBy(SectionData sectionData) {
      int parsed;
      return sectionData.Keys.All(k => Int32.TryParse(k.Value, out parsed));
    }
  }
}
