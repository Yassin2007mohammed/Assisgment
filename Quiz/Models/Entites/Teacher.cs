using System.ComponentModel.DataAnnotations;

namespace Quiz.Models.Entites
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Email { get; set; }

        public string Spelization { get; set; }
        public IEnumerable<Assigment>? Assigments { get; set; }

    }
}
