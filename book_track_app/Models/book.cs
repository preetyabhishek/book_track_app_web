using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace book_track_app.Models
{
    public class book
    { 
        [Key]
        [Required]
        public string ISBN { get; set; }


        public string Title { get; set; }

        
        public string Author { get; set; }

        [ForeignKey("Category")]
        public string CategoryId { get; set; }

        
    }

 }

