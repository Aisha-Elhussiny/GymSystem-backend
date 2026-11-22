using GymSystem_backend.Entities.Enum;

namespace GymSystem_backend.Entities
{
    public class Plan : BaseEntity
    {
        public plansName name ;
        public string description { get; set; } = default!;
        public int durationDays { get; set; }
        public int price { get; set; }
        public bool isActive { get; set; }




    }
}
