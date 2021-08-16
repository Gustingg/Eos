using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eos.Models
{
    [Index(propertyNames: nameof(Username), IsUnique = true)]
    [Index(propertyNames: nameof(Email), IsUnique = true)]
    public class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Usuário vazio, por favor preencha o campo.")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Mínimo de 3 caracteres.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Senha vazia, por favor preencha o campo.")]
        [StringLength(64, MinimumLength = 6, ErrorMessage = "Mínimo de 6 caracteres.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Usuário vazio, por favor preencha o campo.")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Avatar { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }

        public bool ActiveStat { get; set; }


        public List<Post> Posts { get; set; }
    }
}
