using System.ComponentModel.DataAnnotations.Schema;

namespace GymSystem_backend.Entities
{
    public class MemberShip : BaseEntity
    {
        public int MemberId { get; set; }
        public Member Member { get; set; } 
        public int PlanId { get; set; }
        public Plan Plan { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "UpComing" : EndDate > DateTime.Now ? "Active" :"Expired"  ;


    }
}
