using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace McfFeApp.WebApp.Dto
{
    public class BpkpTransaction
    {
        [StringLength(100)]
        public string? AgrrementNumber { get; set; }

        [StringLength(100)]
        public string? BpkbNumber { get; set; }

        public DateTime BpkbDate { get; set; }

        public DateTime FakturDate { get; set; }

        [StringLength(10)]
        public string? LocationId { get; set; }
        public StorageLocation? StorageLocation { get; set; }

        [StringLength(20)]
        public string? PoliceNumber { get; set; }

        public DateTime BpkbDateIn { get; set; }
    }

}
