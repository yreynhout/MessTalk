using System.Collections.Generic;
using System.Linq;
using MessTalk.KeyConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.KeyConventions {
  [TestFixture]
  public class when_looking_for_default_keydataconventions {
    List<IKeyDataConvention> FoundConventions;

    [SetUp]
    public void Execute() {
      FoundConventions = new DefaultKeyDataConventionFinder().Find().ToList();
    }

    [Test]
    public void there_should_be_2_of_them() {
      Assert.That(FoundConventions, Has.Count.EqualTo(2));
    }

    [Test]
    public void the_first_should_be_the_implementsconvention() {
      Assert.That(FoundConventions[0], Is.InstanceOf<ImplementsConvention>());
    }
    
    [Test]
    public void the_second_should_be_the_propertyconvention() {
      Assert.That(FoundConventions[1], Is.InstanceOf<PropertyConvention>());
    }
  }
}
