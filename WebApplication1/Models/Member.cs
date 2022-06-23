using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public int OrganizationID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname{ get; set; }
        public string? MemberNickName{ get; set; }

        // asc

        public virtual ICollection<Membership> Memberships { get; set; }
        [ForeignKey("OrganizationID")]
        public virtual Organization TheOrganization{ get; set; }
    }
}
