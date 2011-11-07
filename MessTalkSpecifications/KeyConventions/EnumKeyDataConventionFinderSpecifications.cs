using System.Collections.Generic;
using System.Linq;
using MessTalk.KeyConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.KeyConventions {
  [TestFixture]
  public class when_looking_for_enumkeydataconventions {
    List<IKeyDataConvention> FoundConventions;

    [SetUp]
    public void Execute() {
      FoundConventions = new EnumKeyDataConventionFinder().Find().ToList();
    }

    [Test]
    public void there_should_only_be_one() {
      Assert.That(FoundConventions, Has.Count.EqualTo(1));
    }

    [Test]
    public void it_should_be_the_enummemberconvention() {
      Assert.That(FoundConventions[0], Is.InstanceOf<EnumMemberConvention>());
    }
  }
}
