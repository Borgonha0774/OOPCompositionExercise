

namespace OOPCompositionExercise.Entities
{
    internal class Client
    {
        public string  Name { get; set; }
        public string Email { get; set; }
        public DateTime BirtDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birtDate)
        {
            Name = name;
            Email = email;
            BirtDate = birtDate;
        }
    }
}
