using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity
{
    [Table("Data_Error")]
    public class Data_Error
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(1000)]
        public required string ErrorName { get; set; }
        [StringLength(500)]
        public required string ErrorCode { get; set; }
        public int MachineGroupID { get; set; }
        public int ParentID { get; set; }
        // -----------
        [StringLength(2000)]
        public string? Note { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }





        #region Thuộc tính thêm để show cha con
        public string MachineGroupName { get; set; } = string.Empty;

        public string ErrorNameNested { get; set; } = string.Empty;
        public int L { get; set; }
        public string ChildPath { get; set; } = string.Empty;
        public string SearchPattern { get; set; } = string.Empty;

        #endregion
    }
}
