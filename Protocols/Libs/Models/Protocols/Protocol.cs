using System.ComponentModel.DataAnnotations;

namespace Protocols.Libs.Models.Protocols
{
    public class Protocol
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Device { get; set; }

        [StringLength(255)]
        public string Address { get; set; }
    }
}
