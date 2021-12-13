using ExercicioFixacao1Secao6;

Console.WriteLine("How many rooms will be rented?");
    int roomsRented = int.Parse(Console.ReadLine());

AluguelQuarto[] rooms = new AluguelQuarto[10];



for (int i = 0; i < roomsRented; i++)
{
    Console.WriteLine("Rent #:" + i);
    Console.WriteLine("What's the name?");
    string name = Console.ReadLine();

    Console.WriteLine("And the Email?");
    string email = Console.ReadLine();

    Console.WriteLine("And the room number?");
    int roomNumber = int.Parse(Console.ReadLine());

    rooms[roomNumber] = new AluguelQuarto(name, email, roomNumber);

}


for (int i = 0; i < 10; i++)
{

    if(rooms[i] != null)
    {
        Console.WriteLine("Busy rooms:");
        Console.WriteLine(rooms[i]);
    }
    
}
