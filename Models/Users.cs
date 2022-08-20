namespace WebService.Models {
    public class Users {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Address? ShippingAddress { get; set; }
        public Address? BillingAddress { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public UserStatus Status { get; set; }

        public bool isValid() =>
            !string.IsNullOrEmpty(FirstName)
            && !string.IsNullOrEmpty(LastName);
    }

    public enum UserStatus {
        Active,
        Inactive
    }
}