namespace GymSystem_backend.Entities
{
    public class Member  : GymUser
    {
       // public DateTime joinDate;
        public string? Photo { get; set; } 
        public ICollection<MemberShip> MemberSubscription { get; set; } = default!;


    }
}
