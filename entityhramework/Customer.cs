using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entityhramework
{
    class Customer
    {
        [Key]
        public int Cid { get; set; }
        [Required]
        public string Cname { get; set; }
            [MaxLength(250)]
            public
    }
}
