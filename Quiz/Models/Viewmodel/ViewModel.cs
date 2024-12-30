using Quiz.Models.Entites;

namespace Quiz.Models.Viewmodel
{
    public class ViewModel
    {
        public int AssigmnetId { get; set; }

        public int Tid { get; set; }
        public int SubId { get; set; }
        public IEnumerable<Subjects> Subjects { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }

        public DateTime Date { get; set; }
    }
}
