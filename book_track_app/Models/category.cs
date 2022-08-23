using System;
using System.ComponentModel.DataAnnotations;

namespace book_track_app.Models
{
    public class category
    { 
         [Key]
         [Required]
         public string NameToken { get; set; }

        public string Description { get; set; }
    
        public string categorytypeId { get; set; }
    }
}

