namespace OneNightAtTriangeln;

public class SecondFloor : Location
{
    public SecondFloor(Player player) : base(player)
    {
        Description =
            "You are on the second floor in Triangelen. There is an escallator, an entrance to the ladies and mens room.";
            _menu = new(this);
            Console.WriteLine("enter escallator or enter ladies room?");
    }

    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case "enter escallator":
                new Escallator(_player);
                break;
            case "enter ladies room":
                new LadiesRoom(_player);
                break;
        }
    }
}