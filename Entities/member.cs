namespace GymSystem_backend.Entities
{
    public class Member  : gymUser
    {
        public DateTime joinDate;
        public string photo { get; set; } = default!;


    }
}
