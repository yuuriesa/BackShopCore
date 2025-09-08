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

        //public methods

        //private methods
    }
}