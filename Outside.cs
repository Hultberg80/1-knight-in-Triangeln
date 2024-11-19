namespace OneNightAtTriangeln;

public class Outside : Location
{
    public Outside(Player player) : base(player)
    {
        Description =
            "You are now outside. You see a homeless bum with your Jacket.. Fight homeless guy or trade booze for jacket?";
             _menu = new(this);
             Console.WriteLine("fight bum or trade booze for jacket?");
    }
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case "fight":
                Console.WriteLine("You got your ass handed to you. The bum was a retired MMA champion.");
                new LadiesRoom(_player);
                break;
            case "trade booze":
                _player.Inventory.Items.Add("Jacket");
                Console.WriteLine("You got a new Item.");
                _player.Inventory.Print();
                Console.WriteLine("Seems like theres something in your pocket...");
                _player.Inventory.Items.Add("Wedding ring");
                Console.WriteLine("You got a new Item.");
                _player.Inventory.Print();
                Console.WriteLine("I remember now! Im getting married today! I must hurry!");
                new Station(_player);
                break;
        }
    }
}