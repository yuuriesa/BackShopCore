namespace BackShopCore.Models
{
    public class Customer
    {
        //private properties
        private string _firstName;
        private string _lastName;
        private DateOnly _dateOnly;

        //public properties
        public int CustomerId { get; private set; }
        public string FirstName => _firstName;
        public string LastName => _lastName;
        public DateOnly DateOfBirth => _dateOnly;
        public bool IsValid { get; private set; }

        //constructors
        private Customer()
        {

        }
        private Customer
        (
            int customerId,
            string firstName,
            string lastName,
            DateOnly dateOnly
        )
        {
            CustomerId = customerId;
            _firstName = firstName;
            _lastName = lastName;
            _dateOnly = dateOnly;
        }

        //public methods
        public static Customer SetExistingInfo
        (
            int customerId,
            string firstName,
            string lastName,
            DateOnly dateOnly
        )
        {
            Customer customer = new Customer
            (
                customerId: customerId,
                firstName: firstName,
                lastName: lastName,
                dateOnly: dateOnly
            );

            customer.Validate();

            return customer;
        }

        //private methods

        private void Validate()
        {

        }
    }
}