using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace McfFeApp.WebApp.Dto
{
    public class StorageLocation
    {
        [StringLength(10)]
        public string? LocationId { get; set; }

        [StringLength(100)]
        public string? LocationName { get; set; }
    }
}
