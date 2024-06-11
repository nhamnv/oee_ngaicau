using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity
{
    [Table("Data_Menu")]
    public class Data_Menu
    {
        [Key]
        public int MenuID { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Name { get; set; }
        [Range(0, int.MinValue)]
        public int? ParentID { get; set; }
        public int? OrderNo { get; set; }
        public bool? IsShowMenu { get; set; }
        public string? Url { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }



        // Addination
        public Data_Menu? ParentMenu { get; set; }

        public ICollection<Data_Menu> ChildMenus { get; set; } = new List<Data_Menu>();
    }
}
