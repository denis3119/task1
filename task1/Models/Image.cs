using System;
using System.ComponentModel.DataAnnotations;

namespace task1.Models
{
    public class Image
    {
        [Key]
        public Guid ID { get; set; }
        public string UserId { get; set; }
        public string URL { get; set; }

        public Image(string userId, string url)
        {
            this.UserId = userId;
            URL = url;
            ID = Guid.NewGuid();
        }

    }
}