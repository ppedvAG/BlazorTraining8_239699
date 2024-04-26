using System.ComponentModel.DataAnnotations;

namespace BlazorTraining8.Components.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(10,MinimumLength =2,ErrorMessage ="zwischen 2 und 10 Länge")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        [Range(120,190,ErrorMessage ="zwischen 120 und 190cm")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        public DateTime GebDat { get; set; }
    }
}
