using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razor8.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255, MinimumLength = 5, ErrorMessage ="{0} phải dài tối thiểu từ {2} đến {1} kí tự")]
        [Required(ErrorMessage = "{0} không được để trống")]
        [Column(TypeName = "nvarchar")]
        [DisplayName("Tiêu đề")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage ="{0} không được để trống")]
        [DisplayName("Ngày tạo")]
        public DateTime Created { get; set; }

        [Column(TypeName = "ntext")]
        [DisplayName("Nội dung")]
        [Required(ErrorMessage ="{0} không được để trống")]
        public string Content { get; set; }
    }
}
