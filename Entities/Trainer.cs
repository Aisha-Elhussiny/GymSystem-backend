using GymSystem_backend.Entities.Enum;

namespace GymSystem_backend.Entities
{
    public class Trainer : GymUser
    {
        
        public Specialities Speciality { get; set; }
        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
