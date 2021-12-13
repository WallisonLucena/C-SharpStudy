

namespace ExercicioFixacao1Secao6
{
    internal class AluguelQuarto
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int RoomNumber { get; private set; }

        public AluguelQuarto(string name, string email, int roomNumber)
        {
            Name = name;
            Email = email;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ": " + Name + ", " + Email;
        }
    }
}
