namespace BackShopCore.Models
{
    public class Customer
    {
        //private properties
        private string _firstName;
        private string _lastName;
        private DateOnly _dateOfBirth;

        //public properties
        public int CustomerId { get; private set; }
        public string FirstName => _firstName;
        public string LastName => _lastName;
        public DateOnly DateOfBirth => _dateOfBirth;
        public bool IsValid { get; private set; }
        public string ErrorMessageIfIsNotValid { get; private set; }

        //constructors
        private Customer()
        {

        }
        private Customer
        (
            int customerId,
            string firstName,
            string lastName,
            DateOnly dateOfBirth
        )
        {
            CustomerId = customerId;
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;

            Validate();
        }

        //public methods
        public static Customer SetExistingInfo
        (
            int customerId,
            string firstName,
            string lastName,
            DateOnly dateOfBirth
        )
        {
            Customer customer = new Customer
            (
                customerId: customerId,
                firstName: firstName,
                lastName: lastName,
                dateOfBirth: dateOfBirth
            );

            customer.Validate();

            return customer;
        }

        //private methods

        private void Validate()
        {
            DateTime dateNow = DateTime.Now;

            if (_firstName.Length > 40 && _lastName.Length > 40)
            {
                ErrorMessageIfIsNotValid = "Must have a maximum of 40 characters";
                IsValid = false;
            }

            if (_dateOfBirth.ToDateTime(TimeOnly.MinValue).ToUniversalTime().Date > dateNow.Date)
            {
                IsValid = false;
                ErrorMessageIfIsNotValid = "You cannot put the date with the day after today.";
            }

            if (ErrorMessageIfIsNotValid == string.Empty)
            {
                IsValid = true;
            }
        }
    }
}