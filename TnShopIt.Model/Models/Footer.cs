using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TnShopIt.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]//Khóa chính của bảng
        public string ID { set; get; }

        [Required]//Điều kiện bắt buộc phải nhật dữ liệu
        public string Content { set; get; }
    }
}