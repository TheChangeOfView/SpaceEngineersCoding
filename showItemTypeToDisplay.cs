public Program()
{
    Runtime.UpdateFrequency = UpdateFrequency.Update10;
}

String DISPLAY = "lcdTest";
String CARGO = "cargoTest";

public void Main(string argument, UpdateType updateSource)
{
    IMyCargoContainer cargo = GridTerminalSystem.GetBlockWithName(CARGO) as IMyCargoContainer;
    List<MyInventoryItem> items = new List<MyInventoryItem>();
    cargo.GetInventory().GetItems(items);
    if(items.Count == 0) {
        return;
    }
    String[] item = items[0].Type.ToString().Split('/');

    IMyTextSurface surf = GridTerminalSystem.GetBlockWithName(DISPLAY) as IMyTextSurface;
    surf.ContentType = ContentType.TEXT_AND_IMAGE;
    surf.FontSize = 0.675f;
    surf.Font = "Monospace";
    surf.WriteText(item[0] + "\n" + item[1]);
}