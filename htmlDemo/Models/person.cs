using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace htmlDemo.Controllers
{
    public class person
    {
        [Required(ErrorMessage ="不能为空")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="名称长度为5到20之间")]
        public string  name { get; set; }
        [RegularExpression(@"\d+",ErrorMessage ="密码必须是数字")]
        public string  pwd { get; set; }
    }
}