using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.UserInterface.Fx;

namespace CommandPattern.UserInterface
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _service;

        public AddCustomerCommand(CustomerService service)
        {
            _service = service;
        }

        public void Execute()
        {
            _service.AddCustomer();
        }
    }
}
