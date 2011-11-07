using IniParser;
using MessTalk.KeyConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.KeyConventions {
  [TestFixture]
  public class any_keydata {
    bool IsMatchedBy;

    [SetUp]
    public void SetUp() {
      IsMatchedBy = new PropertyConvention().IsMatchedBy(new KeyData("SomeProp") {Value = "SomeValue"});
    }

    [Test]
    public void should_match_the_propertyconvention() {
      Assert.That(IsMatchedBy, Is.True);
    }
  }
}
