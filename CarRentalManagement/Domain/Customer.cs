namespace CarRentalManagement.Domain
{
    public class Customer: BaseDoimanModel
    {
        string? DrivingLicense { get; set; }
        string? Address { get; set; }
        string? ContactNumber { get; set; }
        string?EmailAddress { get; set; }   
    }
}
