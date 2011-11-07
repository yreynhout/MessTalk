using IniParser;
using MessTalk.KeyConventions;
using MessTalk.SectionConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.SectionConventions {
  [TestFixture]
  public class when_all_the_keydata_values_of_the_sectiondata_are_integers {
    bool IsMatchedBy;

    [Test]
    public void Execute() {
      var sectionData = new SectionData("FontSize");
      sectionData.Keys.AddKey("Large", "1");
      sectionData.Keys.AddKey("Small", "2");
      sectionData.Keys.AddKey("Normal", "0");
      IsMatchedBy = new EnumConvention().IsMatchedBy(sectionData);
    }

    [Test]
    public void it_should_match_the_enum_convention() {
      Assert.That(IsMatchedBy, Is.True);
    }
  }

  [TestFixture]
  public class when_one_of_the_keydata_values_of_the_sectiondata_is_not_an_integer {
    bool IsMatchedBy;

    [Test]
    public void Execute() {
      var sectionData = new SectionData("FontSize");
      sectionData.Keys.AddKey("Large", "1");
      sectionData.Keys.AddKey("Small", "2");
      sectionData.Keys.AddKey("Normal", "abc");
      IsMatchedBy = new EnumConvention().IsMatchedBy(sectionData);
    }

    [Test]
    public void it_should_not_match_the_enum_convention() {
      Assert.That(IsMatchedBy, Is.False);
    }
  }
}
