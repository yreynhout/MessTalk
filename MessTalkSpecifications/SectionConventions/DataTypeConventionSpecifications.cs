using IniParser;
using MessTalk.SectionConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.SectionConventions {
  //TODO: Find a better way to formulate this specification
  [TestFixture]
  public class any_sectiondata {
    bool IsMatchedBy;

    [SetUp]
    public void Execute() {
      IsMatchedBy = new DataTypeConvention().IsMatchedBy(new SectionData("Anything"));
    }

    [Test]
    public void should_match_the_datatypeconvention() {
      Assert.That(IsMatchedBy, Is.True);
    }
  }
}
