using GymSystem_backend.Entities.Enum;

namespace GymSystem_backend.Entities
{
    public class gymUser : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;   
        public int phoneNumber { get; set; }
        public DateOnly dateOfBirth;
        public gender Gender { get; set; }
        public Address Address { get; set; } = default!;
    }
}
