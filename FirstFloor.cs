namespace OneNightAtTriangeln;

public class FirstFloor : Location
{
    public FirstFloor(Player player) : base(player)
    {
        Description =
            "You are on the first floor. You see the exit, but the door is locked. There is a handle to the fire alarm...";
        _menu = new(this);
        Console.WriteLine("exit or pull handle?");
    }
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case "exit":
                Console.WriteLine("The alarm goes off. Police arrives. ");
                break;
            case "pull handle":
                Console.WriteLine("The fire alarm goes off. Door opens!");
                new Outside(_player);
                break;
        }
    }
}