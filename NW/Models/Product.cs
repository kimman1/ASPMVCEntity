using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace NW.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50), Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Mô tả sản phẩm")]
        public string Description { get; set; }
        [Required, Display(Name = "Giá")]
        public decimal Price { get; set; }
        [Display(Name = "Màu")]
        public string Color { get; set; }
        [Display(Name = "Nhà sản xuất")]
        public string Producer { get; set; }
        [Required, Display(Name = "Ảnh đại diện")]
        public string Image { get; set; }
        [Display(Name = "Người tạo")]
        public string Creator { get; set; }
        
        [Required, Display(Name = "Danh mục")]
        public int CategoryId { get; set; }
        public virtual Category Category  { get; set; }
    }
}