using System;
namespace book_track_app.Models
{
    public class category
    {
        public category();
             
            public string NameToken { get; set; }

        public string Description { get; set; }

        /*[ForeignKey("categorytype")]
        [Display(Name = "category type")]
        [Required]*/
        public string categorytypeId { get; set; }

        public categorytype Type { get; set; }
    }
}

