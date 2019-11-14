using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _01.個人表單.Models {
    public class Infos {
        [Key]
        public int id { get; set; }
        
        [Required(ErrorMessage ="姓名為必填")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "文字範圍是2-50個字")]
        public string Name { get; set; }

        [Required(ErrorMessage = "電話為必填")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "email為必填")]
        [DataType(DataType.EmailAddress, ErrorMessage = "123456")]
        public string Email { get; set; }

        public bool Gender { get; set; }
    }
}