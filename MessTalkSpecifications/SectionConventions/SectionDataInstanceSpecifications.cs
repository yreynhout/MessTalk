using IniParser;
using MessTalk.SectionConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.SectionConventions {
  [TestFixture]
  public class when_a_sectiondatainstance_matches_a_sectiondataconvention {
    bool Matches;

    [SetUp]
    public void Execute() {
      Matches = new SectionDataInstance(new SectionData("Something")).Matches(new AlwaysMatchesConvention());
    }

    [Test]
    public void it_should_return_true() {
      Assert.That(Matches, Is.True);
    }

    
    class AlwaysMatchesConvention: ISectionDataConvention {
      public bool IsMatchedBy(SectionData sectionData) {
        return true;
      }
    }
  }

  [TestFixture]
  public class when_a_sectiondatainstance_does_not_match_a_sectiondataconvention {
    bool Matches;

    [SetUp]
    public void Execute() {
      Matches = new SectionDataInstance(new SectionData("Something")).Matches(new NeverMatchesConvention());
    }

    [Test]
    public void it_should_return_false() {
      Assert.That(Matches, Is.False);
    }

    class NeverMatchesConvention: ISectionDataConvention {
      public bool IsMatchedBy(SectionData sectionData) {
        return false;
      }
    }
  }
}
