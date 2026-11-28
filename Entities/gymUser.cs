using GymSystem_backend.Entities.Enum;

namespace GymSystem_backend.Entities
{
    public class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;   
        public int Phone { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; } = default!;
    }
}
