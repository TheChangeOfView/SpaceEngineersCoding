public Program()
{
    Runtime.UpdateFrequency = UpdateFrequency.Update10;
}

String DISPLAY = "lcdAssTest";
String ASSEMBLER = "assemblerTest";

public void Main(string argument, UpdateType updateSource)
{
    IMyAssembler assembler = GridTerminalSystem.GetBlockWithName(ASSEMBLER) as IMyAssembler;
    List<MyProductionItem> items = new List<MyProductionItem>();
    assembler.GetQueue(items);
    if(items.Count == 0) {
        return;
    }
    String[] item = items[0].BlueprintId.ToString().Split('/');

    IMyTextSurface surf = GridTerminalSystem.GetBlockWithName(DISPLAY) as IMyTextSurface;
    surf.ContentType = ContentType.TEXT_AND_IMAGE;
    surf.FontSize = 0.675f;
    surf.Font = "Monospace";
    surf.WriteText(item[0] + "\n" + item[1]);
}