using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomeWork_Week_1_Project.Models
{
    public class CategoriesClass
    {
        //2- add proparties
        [Key]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Category Name is Required")]
        [DisplayName("Category Name")]
        public string? CategoryName { get; set; }
   //     [Range(1,1000000, ErrorMessage = "the {0} must be more then {1}")]
        public int ParentID { get; set; }
        public string? Discription { get; set; }

    }
}
