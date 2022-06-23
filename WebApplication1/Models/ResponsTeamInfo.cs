namespace WebApplication1.Models
{
    public class ResponsTeamInfo : Team
    {
        public string OrganizationName { get; set; }
        public ICollection<Member> members;
    }
}
