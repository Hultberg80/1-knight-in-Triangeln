namespace OneNightAtTriangeln;

public class Escallator : Location
{
    public Escallator(Player player) : base(player)
    {
        Description = "You are on the escallator. there is a green button on your right.";
        _menu = new(this);
        Console.WriteLine("walk down, walk up or press button?");
    }
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case "walk down":
                new FirstFloor(_player);
                break;
            case "walk up":
                new SecondFloor(_player);
                break;
            case "press button":
                Console.WriteLine("You shouldnt have done that. The alarm goes off, the police enters and puts you down.");
                break;
        }
    }
}