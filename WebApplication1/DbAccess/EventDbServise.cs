using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DbAccess
{
    public class EventDbServise : IEventDbServise
    {

        private readonly MyDbContext _context;

        public EventDbServise(MyDbContext context)
        {
            _context = context;
        }

        public void AddMemberToTeam()
        {
            //throw new NotImplementedException();
        }

        public void GetTeam(int id)
        {
            var team =
                        _context
                        .Teams
                        .Where(x => x.TeamID == id)
                        .Include(x => x.TheOrganization)
                        .Include(x => x.Memberships)
                        .SingleOrDefault();
            var membership = team.Memberships;
            
            
        }

        void IEventDbServise.GetTeam(int id)
        {
            throw new NotImplementedException();
        }
    }
}
