using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace book_track_app.Models
{
    public class categorytype
    {

        [Key]
        public string Type { get; set; }

        [ForeignKey("Category")]
        public string Name { get; set; }

    }
}
