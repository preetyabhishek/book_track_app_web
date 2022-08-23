using System;
namespace book_track_app.Models
{
    public class category
    { 
             
         public string NameToken { get; set; }

        public string Description { get; set; }

    
        public string categorytypeId { get; set; }

        public categorytype Type { get; set; }
    }
}

