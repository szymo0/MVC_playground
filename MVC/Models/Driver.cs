using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Driver
    {
        public Driver()
        {
            
        }
        [DisplayName("Imię")]
        public string Name { get; set; }
        [DisplayName("Nazwisko")]
        public string Surname { get; set; }
        [DisplayName("PESEL")]
        [RegularExpression(@"\d{1,11}",ErrorMessage = "Błędny format peslu")]
        public string Pesel { get; set; }
        [DisplayName("Żywy?!")]
        public bool IsAlive { get; set; }
    }
}