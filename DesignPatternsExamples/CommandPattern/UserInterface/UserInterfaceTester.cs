using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.UserInterface.Fx;

namespace CommandPattern.UserInterface
{
    static class UserInterfaceTester
    {
        internal static void Test()
        {
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            
            button.Click();

            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add((new BlackAndWhiteCommand()));
            
            composite.Execute();
        }
    }
}
