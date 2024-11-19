using System.Globalization;

namespace OneNightAtTriangeln;

public class ToiletStall : Location
{
    public ToiletStall(Player player) : base(player)
    {
        Description = "You wake up in a toilet stall, but you have no memory of how you got here, or where you are. There is a door.";
        _menu = new(this);
        Console.WriteLine("open door or check pockets?");
    }

    public override void HandleResponse(string response)
    {
        
        switch (response)
        {
            case "open door":
                Console.WriteLine("Opening door");
                new LadiesRoom(_player);
                break;
            case "check pockets":
                _player.Inventory.Print();
                new ToiletStall(_player);
                break;
        }
    }
    
}