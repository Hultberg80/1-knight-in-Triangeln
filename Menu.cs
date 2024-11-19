namespace OneNightAtTriangeln;

public class Menu
{
    Location _location;
    public Menu(Location location)
    {
        this._location = location;
        PrintOptions();
    }

    public void PrintOptions()
    {
        Console.WriteLine(_location.Description);
        Console.WriteLine("What do you want to do?");
        askUser();
    }

    private void askUser()
    {
        var response = Console.ReadLine();
        if (response != null)
        {
            _location.HandleResponse(response);
        }
    }
}