using SpecflowAssistMethods;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FirstSpecflowProject.Steps
{
    [Binding]
    public class SpecflowAssistMethodsSteps
    {
        [Given(@"I entered the following data into the new account form:")]
        public void GivenIEnteredTheFollowingDataIntoTheNewAccountForm(Table table)
        {
           var account = table.CreateInstance<Account>();
            Console.WriteLine("accountName");
            Console.WriteLine(account.Name);
            Console.WriteLine("DOB");
            Console.WriteLine(account.Birthdate);
            Console.WriteLine("BANK ACCOUNT BALANCE");
            Console.WriteLine(account.BankAccountBalance);
            Console.WriteLine("Height");
            Console.WriteLine(account.HeightInInches);

        }

        [Given(@"These products exists")]
        public void GivenTheseProductsExists(Table table)
        {
            var products = table.CreateSet<Product>();
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Category);
                Console.WriteLine(product.Price);
            }
        }
        [Given(@"""The information of an employee")]
        public void GivenTheInformationOfAnEmployee(Table table)
        {
            var employees = table.CreateDynamicSet();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
                Console.WriteLine(employee.EmployeeId);
                Console.WriteLine(employee.Designation);
            }
        }


    }
}
