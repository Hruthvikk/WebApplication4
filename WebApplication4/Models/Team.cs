using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string Email { get; set; }

        [Display(Name = "Established Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        public DateTime? EstablishedDate { get; set; }
    }
}
