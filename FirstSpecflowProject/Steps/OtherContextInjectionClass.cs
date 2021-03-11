using ContextInjection;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace FirstSpecflowProject.Steps
{
    [Binding]
    public class OtherContextInjectionClass
    {
        private readonly Person _person;
       public  OtherContextInjectionClass(Person person)
        {
            _person = person;
        }
       
        [Then(@"The first name should be (.*)")]
        public void ThenTheFirstNameShouldBeAnjali(string firstname)
        {
            _person.FirstName.Trim().Should().Be(firstname.Trim());
        }

        [Then(@"the last name should be(.*)")]
        public void ThenTheLastNameShouldBeShah(string lastname)
        {
            _person.LastName.Trim().Should().Be(lastname.Trim());
        }

    }
}
