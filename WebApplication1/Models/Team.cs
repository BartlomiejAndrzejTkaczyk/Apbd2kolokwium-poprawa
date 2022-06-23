using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public int OrganizationID { get; set; }
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }

        // asc
        [ForeignKey("OrganizationID")]
        public virtual Organization TheOrganization { get; set; }

        public virtual ICollection<FileModel> Files { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }
    }
}
