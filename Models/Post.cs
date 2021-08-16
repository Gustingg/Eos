using System;
using System.ComponentModel.DataAnnotations;

namespace Eos.Models
{
    public class Post
    {
        public int PostID { get; set; }

        [Required(ErrorMessage = "Post vazio, por favor, exponha seu sentimentos ao mundo.")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Mínimo 5 caracteres.")]
        [DataType(DataType.MultilineText)]
        public string PostContent { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
