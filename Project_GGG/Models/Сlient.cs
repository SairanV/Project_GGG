using System.ComponentModel.DataAnnotations;

namespace Project_GGG.Models
{
    public class Сlient
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public string ImagePath { get; set; }
        public string AltImage { get; set; }
        public string ImagePathHover { get; set; }
    }
}
