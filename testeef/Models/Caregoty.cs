using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
    public class Category
    {
        [Key]
        public int Id {get; set;}

       // [Required(ErrorMessage ="Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage ="Este campo deve ter entre 3 e 60 caracteries")]
        [MinLength(3, ErrorMessage ="Este campo deve ter entre 3 e 60 caracteries")]
        public string Title { get; set; }

        public Category(int id, string title){
            Id = id;
            Title = title;
        }

    }
}