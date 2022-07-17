using System;

namespace Domain.Commands.Inputs
{
    public class RegisterNewCustomerCommand : CustomerCommand
    {
        public RegisterNewCustomerCommand(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override bool IsValid()
        {
           ValidationResult = new RegisterNewCustomerCommandValidation().
           return ValidationResult.IsValid;
        }
    }
}
