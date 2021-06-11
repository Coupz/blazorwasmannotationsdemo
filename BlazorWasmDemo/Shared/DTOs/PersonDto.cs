using System.ComponentModel.DataAnnotations;

namespace BlazorWasmDemo.Shared.DTOs
{
    public class PersonDto
    {
        [Required(ErrorMessage = "May the force be with you")]
        [DataType(DataType.Text)]
        [StringLength(5, MinimumLength = 3)]
        public string Firstname { get; set; }


        [Required(ErrorMessage = "May the dark side be with you")]
        [DataType(DataType.Text)]
        [StringLength(7, MinimumLength = 6)]
        public string Lastname { get; set; }
    }
}
