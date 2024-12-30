using System.ComponentModel.DataAnnotations;

namespace Quiz.Models.Entites
{
    public class Subjects
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        public double Grade { get; set; }
        public IEnumerable<Assigment>? Assigments { get; set; }

        public DateTime Douration { get; set; }
    }
}
