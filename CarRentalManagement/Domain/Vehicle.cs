namespace CarRentalManagement.Domain
{
    public class Vehicle: BaseDoimanModel
    {
        public int Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        }
}
