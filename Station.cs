namespace OneNightAtTriangeln;

public class Station : Location
{
    public Station(Player player) : base(player)
    {
        Description = "You arrive at the station 07:11. The train just left.";
        _menu = new(this);
        Console.WriteLine("grab a taxi or drink booze?");
        
    }
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case "grab a taxi":
                Console.WriteLine("You made it just in time to your wedding! Congratulations!");
                break;
            
            case "drink booze":
                new LadiesRoom(_player);
                break;
        }
    }
}