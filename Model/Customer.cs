using System.ComponentModel.DataAnnotations;

namespace WebAppPractice.Model
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, StringLength(12)]
        public string Name { get; set; }
    }
}