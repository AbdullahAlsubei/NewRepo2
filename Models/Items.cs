using System.ComponentModel.DataAnnotations;

namespace HomeWork_Week_1_Project.Models
{
    public class ItemsClass
    {
        [Key]
        public int ItemId { get; set; }
        public string? ItemName { get; set; }    
        public int? CategoryID { get; set; }
    }
}
