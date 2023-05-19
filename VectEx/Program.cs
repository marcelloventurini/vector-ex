using VectEx;

Rent[] rent = new Rent[10];

Console.Write("Quantos quartos serão alugados? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Aluguel {i + 1}:");
    Console.Write("Nome: ");
    string name = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Quarto: ");
    int room = int.Parse(Console.ReadLine());

    rent[i] = new Rent { Name = name, Email = email, Room = room };
}

Console.WriteLine("Quartos ocupados: ");

for (int i = 0; i < rent.Length; i++)
{
    if (rent[i] != null)
    {
        Console.WriteLine(rent[i]);
    }
}
