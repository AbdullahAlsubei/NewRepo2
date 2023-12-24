using System.ComponentModel.DataAnnotations;

namespace HomeWork_Week_1_Project.Models
{
    public class ItemsPropartiesClass
    {
        [Key]
        public int PropartyID { get; set; }
        public string? PropartyName { get; set; }
        public string? PropartyValue { get; set; }
        public int ItemID { get; set; }
    }
}
