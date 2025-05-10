using System.ComponentModel.DataAnnotations;
namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "Ad alanı zorunlu")]
        public string? Name { get; set; }

        [Required(ErrorMessage="telefon alanı zorunlu")]
        public string? Phone { get; set; }

        [Required(ErrorMessage="Email alanı zorunlu")]
        [EmailAddress(ErrorMessage="Hatalı E mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage="Katılım durumu zorunlu")]
        public bool? WillAttend { get; set; }//bool türünün default değeri false  ? iaşreti yazmazsak required hiç bir zaman çalışmaz
    }
}