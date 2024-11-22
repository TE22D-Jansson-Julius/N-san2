//steg 1
List<string> leksaker = ["gummianka", "boll", "svärd", "barbie", "transformers"];

//steg 2
for (var i = 0; i < leksaker.Count; i++)
{
    Console.WriteLine(leksaker[i]);
}

// steg 3
List<string> namn = ["viggo", "Ropenis", "Simon", "Adiladis", "Sumsar"];

// Steg 4
List<int> nummer = [1, 3, 5, 7, 9];

// Steg 5
for (var i = 0; i < leksaker.Count; i++)
{
    Console.WriteLine(namn[i] + " ger " + leksaker[i] + " betyget " + nummer[i]);
}

// Steg 6 
List<string> cities = new List<string>();

// Steg 7 
while (true)
{
    Console.WriteLine("Enter a city (type 'exit' to stop):");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        break;
    }


    cities.Add(input);
}


// Steg 8

foreach (string city in cities)
{
    Console.WriteLine(city);
}
Console.ReadLine();
