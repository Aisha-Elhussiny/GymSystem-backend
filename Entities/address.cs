namespace GymSystem_backend.Entities
{
    public class Address
    {
        public string Country { get; set; } = default!;
        public string Street { get; set; } = default!;
        public int BuildingNumber { get; set; }
    }
}
