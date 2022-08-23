using System;
namespace book_track_app.Models
{
    public class book
    {
        public book();
      
           public string ISBN { get; set; }

            
            public string Title { get; set; }

            
            public string Author { get; set; }

            /*[ForeignKey("Category")]
            [Display(Name = "Category")]
            [Required]*/
            public string CategoryId { get; set; }
          }
    }
