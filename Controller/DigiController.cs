public class DigiController
{
    private CSVReader csvReader;

    public DigiController()
    {
        csvReader = new CSVReader();
    }
    public void DisplayAllDigisAndInfo()
    {

        var allDigisAndInfo = csvReader.ReadCsv(@"Datasets\DigiDB_digimonlist.csv");

        Console.WriteLine("All the digimon in the data base, with stats at level 50:");
        Console.WriteLine("Number   -   Digimon   -   Stage  -  Type  -  Attribute  -  Memory  -  Equip Slots  -  Lv 50 HP  -  Lv50 SP  -  Lv50 Atk  -  Lv50 Def  -  Lv50 Int  -  Lv50 Spd");
        foreach (var digi in allDigisAndInfo)
        {
            Console.WriteLine($" #{digi.Number} -  {digi.DigimonName} - {digi.Stage} - {digi.Type} - {digi.Attribute} - {digi.Memory} - {digi.EquipSlots} - {digi.Lv50HP} - {digi.Lv50SP} - {digi.Lv50Atk} - {digi.Lv50Def} - {digi.Lv50Int} - {digi.Lv50Spd}");
        }
    }

    // public void DisplayStatsByAscOrDesc(string orderChoice)
    // {
    //     if (orderChoice == "asc")
    //         DisplayDigisBystatsAscending(Console.ReadLine().Trim().ToLower().Replace(" ", ""));
    //     else if (orderChoice == "desc")
    //     {
    //         DisplayDigisBystatsDescending(Console.ReadLine().ToLower().Trim().Replace(" ", ""));
    //     }
    //     else
    //     {
    //         Console.WriteLine("Incorrect input, only 'asc' or 'desc' accepted.");
    //     }


    // }
    public void DisplayDigisBystatsAscending(string statChoice)
    {
        if (string.IsNullOrWhiteSpace(statChoice) && statChoice != "atk" && statChoice != "hp" && statChoice != "def" && statChoice != "sp" && statChoice != "int" && statChoice != "spd")
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        var digis = csvReader.ReadCsv(@"./Datasets/DigiDB_digimonlist.csv");
        if (statChoice == "atk")
        {
            var digisByStat = digis.OrderBy(d => d.Lv50Atk).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50Atk}");
            }
        }
        else if (statChoice == "def")
        {
            var digisByStat = digis.OrderBy(d => d.Lv50Def).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50Def}");
            }
        }
        else if (statChoice == "hp")
        {
            var digisByStat = digis.OrderBy(d => d.Lv50HP).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50HP}");
            }
        }
        else if (statChoice == "sp")
        {
            var digisByStat = digis.OrderBy(d => d.Lv50SP).ToList();

            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50SP}");
            }
        }
        else if (statChoice == "int")
        {
            var digisByStat = digis.OrderBy(d => d.Lv50Int).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50Int}");
            }
        }
        else if (statChoice == "spd")
        {
            var digisByStat = digis.OrderBy(d => d.Lv50Spd).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50Spd}");
            }
        }
        else
        {
            Console.WriteLine("Only write atk, def, int, spd, or hp.");

        }
    }
    public void DisplayDigisBystatsDescending(string statChoice)
    {
        if (string.IsNullOrWhiteSpace(statChoice) && statChoice != "atk" && statChoice != "hp" && statChoice != "def" && statChoice != "sp" && statChoice != "int" && statChoice != "spd")
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        var digis = csvReader.ReadCsv(@"./Datasets/DigiDB_digimonlist.csv");
        if (statChoice == "atk")
        {
            var digisByStat = digis.OrderByDescending(d => d.Lv50Atk).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50Atk}");
            }
        }
        else if (statChoice == "def")
        {
            var digisByStat = digis.OrderByDescending(d => d.Lv50Def).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50Def}");
            }
        }
        else if (statChoice == "hp")
        {
            var digisByStat = digis.OrderByDescending(d => d.Lv50HP).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50HP}");
            }
        }
        else if (statChoice == "sp")
        {
            var digisByStat = digis.OrderByDescending(d => d.Lv50SP).ToList();

            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50SP}");
            }
        }
        else if (statChoice == "int")
        {
            var digisByStat = digis.OrderByDescending(d => d.Lv50Int).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50Int}");
            }
        }
        else if (statChoice == "spd")
        {
            var digisByStat = digis.OrderByDescending(d => d.Lv50Spd).ToList();
            foreach (var digi in digisByStat)
            {
                Console.WriteLine($"#{digi.Number}  -  {digi.DigimonName}   -  {statChoice}:  {digi.Lv50Spd}");
            }
        }
        else
        {
            Console.WriteLine("Only write atk, def, int, spd, or hp.");

        }


    }
}



