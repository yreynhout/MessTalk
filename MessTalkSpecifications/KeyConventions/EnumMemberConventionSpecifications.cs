using IniParser;
using MessTalk.KeyConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.KeyConventions {
  [TestFixture]
  public class when_the_value_of_keydata_is_an_integer {
    bool IsMatchedBy;

    [SetUp]
    public void Execute() {
      IsMatchedBy = new EnumMemberConvention().IsMatchedBy(new KeyData("SomeMember") {Value = "1"});
    }

    [Test]
    public void it_should_match_the_enummemberconvention() {
      Assert.That(IsMatchedBy, Is.True);
    }
  }

  [TestFixture]
  public class when_the_value_of_keydata_is_not_an_integer {
    bool IsMatchedBy;

    [SetUp]
    public void Execute() {
      IsMatchedBy = new EnumMemberConvention().IsMatchedBy(new KeyData("SomeMember") { Value = "ABC" });
    }

    [Test]
    public void it_should_not_match_the_enummemberconvention() {
      Assert.That(IsMatchedBy, Is.False);
    }
  }
}
