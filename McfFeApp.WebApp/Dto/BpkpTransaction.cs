using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace McfFeApp.WebApp.Dto
{
    public class BpkpTransaction
    {
        [StringLength(100)]
        [DisplayName("Agrrement Number")]
        public string? AgrrementNumber { get; set; }

        [StringLength(10)]
        [DisplayName("Branch Id")]
        public string? BranchId { get; set; }

        [StringLength(100)]
        [DisplayName("No. Bpkb")]
        public string? BpkbNumber { get; set; }

        [DisplayName("Tgl. Bpkp")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BpkbDate { get; set; }

        [StringLength(100)]
        [DisplayName("No. Faktur")]
        public string? FakturNumber { get; set; }

        [DisplayName("Tanggal Faktur")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FakturDate { get; set; }

        [StringLength(10)]
        [DisplayName("Lokasi Penyimpanan")]
        public string? LocationId { get; set; }

        [DisplayName("No. Polisi")]
        [StringLength(20)]
        public string? PoliceNumber { get; set; }

        [DisplayName("Tgl. Bpkp In")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BpkbDateIn { get; set; }
    }

}
