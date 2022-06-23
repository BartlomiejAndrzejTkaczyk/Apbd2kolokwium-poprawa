using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class FileModel
    {
        public int FileID { get; set; }
        public int TeamID { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public int FileSize { get; set; }

        // asc
        [ForeignKey("TeamID")]
        public Team TheTeam { get; set; }
    }
}
