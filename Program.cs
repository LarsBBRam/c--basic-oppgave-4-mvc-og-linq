namespace c__basic_oppgave_4_mvc_og_linq;

class Program
{
    static void Main(string[] args)
    {
        var controller = new DigiController();

        bool showMenu = true;
        while (showMenu)
        {
            showMenu = Menu.MainMenu();
        }
    }
}

