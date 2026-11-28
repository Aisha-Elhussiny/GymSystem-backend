namespace GymSystem_backend.Entities
{
    public class Address
    {
        public string street { get; set; } = default!;
        public string city { get; set; } = default!;
        public int buildingNumber { get; set; }
    }
}
