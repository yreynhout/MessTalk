using IniParser;
using MessTalk.KeyConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.KeyConventions {
  [TestFixture]
  public class when_a_keydata_name_ends_with_the_underscore_prefixed_word_implements {
    bool IsMatchedBy;

    [SetUp]
    public void Execute() {
      IsMatchedBy = new ImplementsConvention().IsMatchedBy(new KeyData("_Implements"));
    }

    [Test]
    public void it_should_match_the_implementsconvention() {
      Assert.That(IsMatchedBy, Is.True);
    }
  }

  [TestFixture]
  public class when_a_keydata_name_does_not_end_with_the_underscore_prefixed_word_implements {
    bool IsMatchedBy;

    [SetUp]
    public void Execute() {
      IsMatchedBy = new ImplementsConvention().IsMatchedBy(new KeyData("Something"));
    }

    [Test]
    public void it_should_not_match_the_implementsconvention() {
      Assert.That(IsMatchedBy, Is.False);
    }
  }
}
