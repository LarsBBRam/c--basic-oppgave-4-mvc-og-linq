using System.Globalization;

public class CSVReader
{
    public List<Digimon> ReadCsv(string filepath)
    {
        var mons = new List<Digimon>();
        var lines = File.ReadAllLines(filepath);

        for (int i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(',');
            var mon = new Digimon
            {
                Number = int.Parse(values[0]),
                DigimonName = values[1],
                Stage = values[2],
                Type = values[3],
                Attribute = values[4],
                Memory = int.Parse(values[5]),
                EquipSlots = int.Parse(values[6]),
                Lv50HP = int.Parse(values[7]),
                Lv50SP = int.Parse(values[8]),
                Lv50Atk = int.Parse(values[9]),
                Lv50Def = int.Parse(values[10]),
                Lv50Int = int.Parse(values[11]),
                Lv50Spd = int.Parse(values[12])
            };
            mons.Add(mon);
        }
        return mons;
    }
}