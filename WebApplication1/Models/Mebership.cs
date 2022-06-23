using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Membership
    {
        public int MemberID { get; set; }
        public int TeamID { get; set; }
        public DateTime MebershipDate { get; set; }

        // asc
        [ForeignKey("MemberID")]
        public virtual Member TheMember { get; set; }
        [ForeignKey("TeamID")]
        public virtual Team TheTeam{ get; set; }
    }
}
