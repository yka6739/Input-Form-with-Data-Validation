using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form.Shared
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Name Field is Required.........")]
        public string FatherName { get; set; }
        [Required]
        public string MotherName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Pincode { get; set; }
    }
}
