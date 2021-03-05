using SpecFlowCalculator;
using TechTalk.SpecFlow;
using FluentAssertions;
using TechTalk.SpecFlow.Assist;


namespace FirstSpecflowProject.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        private Calculator _calculator;
        private int _result;
        [Given(@"I have a Calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I apply (.*) on (.*) and (.*)")]
        public void WhenIApplyAddOnAnd(string operation,int first, int second)
        {
            _calculator.FirstNumber = first;
            _calculator.SecondNumber = second;
            _result = operation switch
            {
                "add" => _calculator.Add(),
                "subtract" => _calculator.Subtract(),
                "multiply" => _calculator.Multiply(),
                "divide" => _calculator.Divide(),
                _ => 0,
            };
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }






    }
}
