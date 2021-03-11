using ContextInjection;
using System;
using TechTalk.SpecFlow;

namespace FirstSpecflowProject.Steps
{
    [Binding]
    public class SpecFlowContextInjectionSteps
    {
        private readonly Person _person;
      public SpecFlowContextInjectionSteps(Person person)
        {
            _person = person;
        }
       
        [Given(@"Person having firstname as (.*)")]
        public void GivenPersonHavingFirstnameAsAnjali(string firstname)
        {
            _person.FirstName = firstname;
        }

        [Given(@"lastname as (.*)")]
        public void GivenLastnameAsShah(string lastname)
        {
            _person.LastName = lastname;
        }


    }
}
