using IniParser;
using MessTalk.SectionConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.SectionConventions {
  [TestFixture]
  public class when_a_sectiondata_name_ends_with_the_word_fragment {
    bool IsMatchedBy;

    [SetUp]
    public void Execute() {
      IsMatchedBy = new FragmentConvention().IsMatchedBy(new SectionData("Fragment"));
    }

    [Test]
    public void it_should_match_the_fragment_convention() {
      Assert.That(IsMatchedBy, Is.True);
    }
  }

  [TestFixture]
  public class when_a_sectiondata_name_does_not_end_with_the_word_fragment {
    bool IsMatchedBy;

    [SetUp]
    public void Execute() {
      IsMatchedBy = new FragmentConvention().IsMatchedBy(new SectionData("Something"));
    }

    [Test]
    public void it_should_not_match_the_fragment_convention() {
      Assert.That(IsMatchedBy, Is.False);
    }
  }
}
