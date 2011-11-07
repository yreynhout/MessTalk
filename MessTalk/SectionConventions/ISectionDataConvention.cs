using System;
using IniParser;

namespace MessTalk.SectionConventions {
  public interface ISectionDataConvention {
    bool IsMatchedBy(SectionData sectionData);
  }

  //public interface IConventionApplier {
  //  void To(MessageModel model);
  //}

  //public class ConventionBasedSectionDataProcessor {
  //  public void ProcessSectionData(SectionData sectionData) {
  //    ISectionDataConvention convention;
  //    var instance = new SectionDataInstance(sectionData);
  //    if(instance.Matches(convention)) {
  //      instance.Apply(convention).To(_messageModel);
  //    }
  //  }
  //}
}
