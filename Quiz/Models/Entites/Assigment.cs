using System.ComponentModel.DataAnnotations;

namespace Quiz.Models.Entites
{
    public class Assigment
    {
        [Key] 
        public int AssigmentId { get; set; } 

        public int subid { get; set; }
        public Subjects Subjects { get; set; }

        public int Tid { get; set; }
        public Teacher Teacher { get; set; }
        public DateTime Date { get; set; }



    }
}
