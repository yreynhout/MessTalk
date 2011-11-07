using System.Collections.Generic;
using System.Linq;
using MessTalk.SectionConventions;
using NUnit.Framework;

namespace MessTalkSpecifications.SectionConventions {
  [TestFixture]
  public class when_looking_for_the_default_sectiondataconventions {
    List<ISectionDataConvention> FoundConventions;

    [SetUp]
    public void Execute() {
      FoundConventions = new DefaultSectionDataConventionFinder().Find().ToList();
    }

    [Test]
    public void there_should_be_7_of_them() {
      Assert.That(FoundConventions, Has.Count.EqualTo(7));
    }

    [Test]
    public void the_first_should_be_the_commandconvention() {
      Assert.That(FoundConventions[0], Is.InstanceOf<CommandConvention>());
    }

    [Test]
    public void the_second_should_be_the_eventconvention() {
      Assert.That(FoundConventions[1], Is.InstanceOf<EventConvention>());
    }

    [Test]
    public void the_third_should_be_the_faultconvention() {
      Assert.That(FoundConventions[2], Is.InstanceOf<FaultConvention>());
    }

    [Test]
    public void the_fourth_should_be_the_enumconvention() {
      Assert.That(FoundConventions[3], Is.InstanceOf<EnumConvention>());
    }

    [Test]
    public void the_fifth_should_be_the_requestconvention() {
      Assert.That(FoundConventions[4], Is.InstanceOf<RequestConvention>());
    }

    [Test]
    public void the_sixth_should_be_the_responseconvention() {
      Assert.That(FoundConventions[5], Is.InstanceOf<ResponseConvention>());
    }

    [Test]
    public void the_seventh_should_be_the_datatypeconvention() {
      Assert.That(FoundConventions[6], Is.InstanceOf<DataTypeConvention>());
    }
  }
}
