public Program()
{
}

public void Main(string argument, UpdateType updateSource)
{
    getBlocks();
    checkStorage();
}

List<String> CARGO_MATERIAL_NAMES = new List<String>{
    "CARGO - General Storage"
};

List<String> CARGO_INGOT_NAMES = new List<String>{
    "CARGO - Ingots"
};

List<String> DISPLAY_MATERIAL_NAMES = new List<String>{
    "DISP - Fabrication Material",
    "DISP - Bridge Material"
};

List<String> DISPLAY_INGOT_NAMES = new List<String>{
    "DISP - Fabrication Ingot",
    "DISP - Bridge Ingot"
};

List<String> ASSEMBLER_MAIN_NAMES = new List<String>{
    "ASS - 2 (Primary Auto)",
    "ASS - 5 (Primary Auto)"
};

List<IMyCargoContainer> CARGO_MATERIAL = new List<IMyCargoContainer>();
List<IMyCargoContainer> CARGO_INGOT = new List<IMyCargoContainer>();
List<IMyTextSurface> DISPLAY_MATERIAL = new List<IMyTextSurface>();
List<IMyTextSurface> DISPLAY_INGOT = new List<IMyTextSurface>();
List<IMyAssembler> ASSEMBLER_MAIN = new List<IMyAssembler>();

public void getBlocks()
{
    foreach(String cargoName in CARGO_MATERIAL_NAMES)
    {
        IMyCargoContainer cargo = GridTerminalSystem.GetBlockWithName(cargoName) as IMyCargoContainer;
        CARGO_MATERIAL.Add(cargo);
    };

    foreach(String cargoName in CARGO_INGOT_NAMES)
    {
        IMyCargoContainer cargo = GridTerminalSystem.GetBlockWithName(cargoName) as IMyCargoContainer;
        CARGO_INGOT.Add(cargo);
    };

    foreach(String displayName in DISPLAY_MATERIAL_NAMES)
    {
        IMyTextSurface display = GridTerminalSystem.GetBlockWithName(displayName) as IMyTextSurface;
        DISPLAY_MATERIAL.Add(display);
    };

    foreach(String displayName in DISPLAY_INGOT_NAMES)
    {
        IMyTextSurface display = GridTerminalSystem.GetBlockWithName(displayName) as IMyTextSurface;
        DISPLAY_INGOT.Add(display);
    };

    foreach(String assemblerName in ASSEMBLER_MAIN_NAMES)
    {
        IMyAssembler assembler = GridTerminalSystem.GetBlockWithName(assemblerName) as IMyAssembler;
        ASSEMBLER_MAIN.Add(assembler);
    };
}

public void checkStorage()
{
    List<String> COMPONENT_NAMES = new List<String>{
        "BulletproofGlass",
        "Computer",
        "Construction",
        "Detector",
        "Display",
        "Explosives",
        "Girder",
        "Gravity",
        "InteriorPlate",
        "LargeTube",
        "Medical",
        "MetalGrid",
        "Motor",
        "PowerCell",
        "RadioCommunication",
        "Reactor",
        "SmallTube",
        "SolarCell",
        "SteelPlate",
        "Superconductor",
        "Thrust"
    };

    List<double> AMOUNT_COMPONENT = new List<double>{
        /*AMOUNT_COMPONENT_GLASS            */ 0.0,
        /*AMOUNT_COMPONENT_COMPUTER         */ 0.0,
        /*AMOUNT_COMPONENT_COMPONENTS       */ 0.0,
        /*AMOUNT_COMPONENT_DETECTOR         */ 0.0,
        /*AMOUNT_COMPONENT_DISPLAY          */ 0.0,
        /*AMOUNT_COMPONENT_EXPLOSIVES       */ 0.0,
        /*AMOUNT_COMPONENT_GIRDER           */ 0.0,
        /*AMOUNT_COMPONENT_GRAVITY          */ 0.0,
        /*AMOUNT_COMPONENT_INTERIORPLATE    */ 0.0,
        /*AMOUNT_COMPONENT_LARGETUBE        */ 0.0,
        /*AMOUNT_COMPONENT_MEDICAL          */ 0.0,
        /*AMOUNT_COMPONENT_METALGRID        */ 0.0,
        /*AMOUNT_COMPONENT_MOTOR            */ 0.0,
        /*AMOUNT_COMPONENT_POWER            */ 0.0,
        /*AMOUNT_COMPONENT_RADIO            */ 0.0,
        /*AMOUNT_COMPONENT_REACTOR          */ 0.0,
        /*AMOUNT_COMPONENT_SMALLTUBE        */ 0.0,
        /*AMOUNT_COMPONENT_SOLAR            */ 0.0,
        /*AMOUNT_COMPONENT_STEELPLATE       */ 0.0,
        /*AMOUNT_COMPONENT_SUPERCONDUCTOR   */ 0.0,
        /*AMOUNT_COMPONENT_THRUSTE          */ 0.0
    };

    List<double> AMOUNT_INGOT = new List<double>{
        /*AMOUNT_INGOT_COBALT               */ 0.0,
        /*AMOUNT_INGOT_GOLD                 */ 0.0,
        /*AMOUNT_INGOT_GRAVEL               */ 0.0,
        /*AMOUNT_INGOT_IRON                 */ 0.0,
        /*AMOUNT_INGOT_MAGNESIUM            */ 0.0,
        /*AMOUNT_INGOT_NICKEL               */ 0.0,
        /*AMOUNT_INGOT_PLATINUM             */ 0.0,
        /*AMOUNT_INGOT_SILICON              */ 0.0,
        /*AMOUNT_INGOT_SILVER               */ 0.0,
        /*AMOUNT_INGOT_URANIUM              */ 0.0
    };

    List<int> MIN_COMPONENT = new List<int>{
        /* MIN_COMPONENT_GLASS              */ 200,
        /* MIN_COMPONENT_COMPUTER           */ 150,
        /* MIN_COMPONENT_COMPONENTS         */ 10000,
        /* MIN_COMPONENT_DETECTOR           */ 0,
        /* MIN_COMPONENT_DISPLAY            */ 200,
        /* MIN_COMPONENT_EXPLOSIVES         */ 0,
        /* MIN_COMPONENT_GIRDER             */ 0,
        /* MIN_COMPONENT_GRAVITY            */ 0,
        /* MIN_COMPONENT_INTERIORPLATE      */ 5000,
        /* MIN_COMPONENT_LARGETUBE          */ 1000,
        /* MIN_COMPONENT_MEDICAL            */ 0,
        /* MIN_COMPONENT_METALGRID          */ 7000,
        /* MIN_COMPONENT_MOTOR              */ 500,
        /* MIN_COMPONENT_POWER              */ 0,
        /* MIN_COMPONENT_RADIO              */ 0,
        /* MIN_COMPONENT_REACTOR            */ 0,
        /* MIN_COMPONENT_SMALLTUBE          */ 2500,
        /* MIN_COMPONENT_SOLAR              */ 0,
        /* MIN_COMPONENT_STEELPLATE         */ 5000,
        /* MIN_COMPONENT_SUPERCONDUCTOR     */ 0,
        /* MIN_COMPONENT_THRUSTER           */ 0
    };

    List<int> MAX_COMPONENT = new List<int>{
        /* MAX_COMPONENT_GLASS              */ 1000,
        /* MAX_COMPONENT_COMPUTER           */ 500,
        /* MAX_COMPONENT_COMPONENTS         */ 20000,
        /* MAX_COMPONENT_DETECTOR           */ 0,
        /* MAX_COMPONENT_DISPLAY            */ 1000,
        /* MAX_COMPONENT_EXPLOSIVES         */ 0,
        /* MAX_COMPONENT_GIRDER             */ 0,
        /* MAX_COMPONENT_GRAVITY            */ 0,
        /* MAX_COMPONENT_INTERIORPLATE      */ 10000,
        /* MAX_COMPONENT_LARGETUBE          */ 2500,
        /* MAX_COMPONENT_MEDICAL            */ 0,
        /* MAX_COMPONENT_METALGRID          */ 10000,
        /* MAX_COMPONENT_MOTOR              */ 2000,
        /* MAX_COMPONENT_POWER              */ 0,
        /* MAX_COMPONENT_RADIO              */ 0,
        /* MAX_COMPONENT_REACTOR            */ 0,
        /* MAX_COMPONENT_SMALLTUBE          */ 5000,
        /* MAX_COMPONENT_SOLAR              */ 0,
        /* MAX_COMPONENT_STEELPLATE         */ 10000,
        /* MAX_COMPONENT_SUPERCONDUCTOR     */ 0,
        /* MAX_COMPONENT_THRUSTER           */ 0
    };

    List<MyItemType> TYPE_COMPONENT = new List<MyItemType>{
        /*TYPE_COMPONENT_GLASS              */ new MyItemType("MyObjectBuilder_Component","BulletproofGlass"),
        /*TYPE_COMPONENT_COMPUTER           */ new MyItemType("MyObjectBuilder_Component","Computer"),
        /*TYPE_COMPONENT_COMPONENTS         */ new MyItemType("MyObjectBuilder_Component","Construction"),
        /*TYPE_COMPONENT_DETECTOR           */ new MyItemType("MyObjectBuilder_Component","Detector"),
        /*TYPE_COMPONENT_DISPLAY            */ new MyItemType("MyObjectBuilder_Component","Display"),
        /*TYPE_COMPONENT_EXPLOSIVES         */ new MyItemType("MyObjectBuilder_Component","Explosives"),
        /*TYPE_COMPONENT_GIRDER             */ new MyItemType("MyObjectBuilder_Component","Girder"),
        /*TYPE_COMPONENT_GRAVITY            */ new MyItemType("MyObjectBuilder_Component","Gravity"),
        /*TYPE_COMPONENT_INTERIORPLATE      */ new MyItemType("MyObjectBuilder_Component","InteriorPlate"),
        /*TYPE_COMPONENT_LARGETUBE          */ new MyItemType("MyObjectBuilder_Component","LargeTube"),
        /*TYPE_COMPONENT_MEDICAL            */ new MyItemType("MyObjectBuilder_Component","Medical"),
        /*TYPE_COMPONENT_METALGRID          */ new MyItemType("MyObjectBuilder_Component","MetalGrid"),
        /*TYPE_COMPONENT_MOTOR              */ new MyItemType("MyObjectBuilder_Component","Motor"),
        /*TYPE_COMPONENT_POWER              */ new MyItemType("MyObjectBuilder_Component","PowerCell"),
        /*TYPE_COMPONENT_RADIO              */ new MyItemType("MyObjectBuilder_Component","RadioCommunication"),
        /*TYPE_COMPONENT_REACTOR            */ new MyItemType("MyObjectBuilder_Component","Reactor"),
        /*TYPE_COMPONENT_SMALLTUBE          */ new MyItemType("MyObjectBuilder_Component","SmallTube"),
        /*TYPE_COMPONENT_SOLAR              */ new MyItemType("MyObjectBuilder_Component","SolarCell"),
        /*TYPE_COMPONENT_STEELPLATE         */ new MyItemType("MyObjectBuilder_Component","SteelPlate"),
        /*TYPE_COMPONENT_SUPERCONDUCTOR     */ new MyItemType("MyObjectBuilder_Component","Superconductor"),
        /*TYPE_COMPONENT_THRUSTER           */ new MyItemType("MyObjectBuilder_Component","Thrust")
    };

    List<MyItemType> TYPE_INGOT = new List<MyItemType>{
        /*TYPE_INGOT_COBALT                 */ new MyItemType("MyObjectBuilder_Ingot","Cobalt"),
        /*TYPE_INGOT_GOLD                   */ new MyItemType("MyObjectBuilder_Ingot","Gold"),
        /*TYPE_INGOT_GRAVEL                 */ new MyItemType("MyObjectBuilder_Ingot","Stone"),
        /*TYPE_INGOT_IRON                   */ new MyItemType("MyObjectBuilder_Ingot","Iron"),
        /*TYPE_INGOT_MAGNESIUM              */ new MyItemType("MyObjectBuilder_Ingot","Magnesium"),
        /*TYPE_INGOT_NICKEL                 */ new MyItemType("MyObjectBuilder_Ingot","Nickel"),
        /*TYPE_INGOT_PLATINUM               */ new MyItemType("MyObjectBuilder_Ingot","Platinum"),
        /*TYPE_INGOT_SILICON                */ new MyItemType("MyObjectBuilder_Ingot","Silicon"),
        /*TYPE_INGOT_SILVER                 */ new MyItemType("MyObjectBuilder_Ingot","Silver"),
        /*TYPE_INGOT_URANIUM                */ new MyItemType("MyObjectBuilder_Ingot","Uranium")
    };

    List<MyDefinitionId> BP_COMPONENT = new List<MyDefinitionId>{
        /*BP_COMPONENT_GLASS                */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/BulletproofGlass"),
        /*BP_COMPONENT_COMPUTER             */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Computer"),
        /*BP_COMPONENT_COMPONENTS           */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Construction"),
        /*BP_COMPONENT_DETECTOR             */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Detector"),
        /*BP_COMPONENT_DISPLAY              */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Display"),
        /*BP_COMPONENT_EXPLOSIVES           */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Explosives"),
        /*BP_COMPONENT_GIRDER               */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Girder"),
        /*BP_COMPONENT_GRAVITY              */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Gravity"),
        /*BP_COMPONENT_INTERIORPLATE        */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/InteriorPlate"),
        /*BP_COMPONENT_LARGETUBE            */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/LargeTube"),
        /*BP_COMPONENT_MEDICAL              */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Medical"),
        /*BP_COMPONENT_METALGRID            */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/MetalGrid"),
        /*BP_COMPONENT_MOTOR                */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Motor"),
        /*BP_COMPONENT_POWER                */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/PowerCell"),
        /*BP_COMPONENT_RADIO                */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/RadioCommunication"),
        /*BP_COMPONENT_REACTOR              */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Reactor"),
        /*BP_COMPONENT_SMALLTUBE            */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/SmallTube"),
        /*BP_COMPONENT_SOLAR                */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/SolarCell"),
        /*BP_COMPONENT_STEELPLATE           */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/SteelPlate"),
        /*BP_COMPONENT_SUPERCONDUCTOR       */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Superconductor"),
        /*BP_COMPONENT_THRUSTER             */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Thrust")
    };

    // --- DISPLAY STORAGE CONTENT ---

    // get material storage content
    foreach(IMyCargoContainer cargo in CARGO_MATERIAL)
    {
        IMyInventory inventory = cargo.GetInventory();

        AMOUNT_COMPONENT[0]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[0] ).SerializeString());
        AMOUNT_COMPONENT[1]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[1] ).SerializeString());
        AMOUNT_COMPONENT[2]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[2] ).SerializeString());
        AMOUNT_COMPONENT[3]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[3] ).SerializeString());
        AMOUNT_COMPONENT[4]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[4] ).SerializeString());
        AMOUNT_COMPONENT[5]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[5] ).SerializeString());
        AMOUNT_COMPONENT[6]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[6] ).SerializeString());
        AMOUNT_COMPONENT[7]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[7] ).SerializeString());
        AMOUNT_COMPONENT[8]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[8] ).SerializeString());
        AMOUNT_COMPONENT[9]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[9] ).SerializeString());
        AMOUNT_COMPONENT[10] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[10]).SerializeString());
        AMOUNT_COMPONENT[11] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[11]).SerializeString());
        AMOUNT_COMPONENT[12] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[12]).SerializeString());
        AMOUNT_COMPONENT[13] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[13]).SerializeString());
        AMOUNT_COMPONENT[14] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[14]).SerializeString());
        AMOUNT_COMPONENT[15] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[15]).SerializeString());
        AMOUNT_COMPONENT[16] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[16]).SerializeString());
        AMOUNT_COMPONENT[17] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[17]).SerializeString());
        AMOUNT_COMPONENT[18] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[18]).SerializeString());
        AMOUNT_COMPONENT[19] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[19]).SerializeString());
        AMOUNT_COMPONENT[20] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[20]).SerializeString());
    };

    // get ingot storage content
    foreach(IMyCargoContainer cargo in CARGO_INGOT)
    {
        IMyInventory inventory = cargo.GetInventory();

        AMOUNT_INGOT[0] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[0]).SerializeString());
        AMOUNT_INGOT[1] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[1]).SerializeString());
        AMOUNT_INGOT[2] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[2]).SerializeString());
        AMOUNT_INGOT[3] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[3]).SerializeString());
        AMOUNT_INGOT[4] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[4]).SerializeString());
        AMOUNT_INGOT[5] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[5]).SerializeString());
        AMOUNT_INGOT[6] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[6]).SerializeString());
        AMOUNT_INGOT[7] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[7]).SerializeString());
        AMOUNT_INGOT[8] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[8]).SerializeString());
        AMOUNT_INGOT[9] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[9]).SerializeString());
    };

    // print material to displays
    foreach(IMyTextSurface display in DISPLAY_MATERIAL)
    {
        display.ContentType = ContentType.TEXT_AND_IMAGE;
        display.FontSize = 0.6f;

        display.WriteText("--MATERIAL--------------------------------\n", false);
        display.WriteText("\n", true);
        display.WriteText(String.Format("Bulletproof Glass:  ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[0] , MAX_COMPONENT[0] , AMOUNT_COMPONENT[0] ), true);
        display.WriteText(String.Format("Computer:           ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[1] , MAX_COMPONENT[1] , AMOUNT_COMPONENT[1] ), true);
        display.WriteText(String.Format("Construction Comp.: ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[2] , MAX_COMPONENT[2] , AMOUNT_COMPONENT[2] ), true);
        display.WriteText(String.Format("Detector Comp.:     ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[3] , MAX_COMPONENT[3] , AMOUNT_COMPONENT[3] ), true);
        display.WriteText(String.Format("Display:            ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[4] , MAX_COMPONENT[4] , AMOUNT_COMPONENT[4] ), true);
        display.WriteText(String.Format("Explosives:         ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[5] , MAX_COMPONENT[5] , AMOUNT_COMPONENT[5] ), true);
        display.WriteText(String.Format("Girder:             ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[6] , MAX_COMPONENT[6] , AMOUNT_COMPONENT[6] ), true);
        display.WriteText(String.Format("Gravity Comp.:      ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[7] , MAX_COMPONENT[7] , AMOUNT_COMPONENT[7] ), true);
        display.WriteText(String.Format("Interior Plate:     ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[8] , MAX_COMPONENT[8] , AMOUNT_COMPONENT[8] ), true);
        display.WriteText(String.Format("Large Tube:         ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[9] , MAX_COMPONENT[9] , AMOUNT_COMPONENT[9] ), true);
        display.WriteText(String.Format("Medical Comp.:      ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[10], MAX_COMPONENT[10], AMOUNT_COMPONENT[10]), true);
        display.WriteText(String.Format("Metal Grid:         ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[11], MAX_COMPONENT[11], AMOUNT_COMPONENT[11]), true);
        display.WriteText(String.Format("Motor:              ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[12], MAX_COMPONENT[12], AMOUNT_COMPONENT[12]), true);
        display.WriteText(String.Format("Power Cell:         ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[13], MAX_COMPONENT[13], AMOUNT_COMPONENT[13]), true);
        display.WriteText(String.Format("Radiocomm. Comp.:   ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[14], MAX_COMPONENT[14], AMOUNT_COMPONENT[14]), true);
        display.WriteText(String.Format("Reactor Comp.:      ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[15], MAX_COMPONENT[15], AMOUNT_COMPONENT[15]), true);
        display.WriteText(String.Format("Small Tube:         ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[16], MAX_COMPONENT[16], AMOUNT_COMPONENT[16]), true);
        display.WriteText(String.Format("Solar Cell:         ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[17], MAX_COMPONENT[17], AMOUNT_COMPONENT[17]), true);
        display.WriteText(String.Format("Steel Plate:        ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[18], MAX_COMPONENT[18], AMOUNT_COMPONENT[18]), true);
        display.WriteText(String.Format("Superconductor:     ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[19], MAX_COMPONENT[19], AMOUNT_COMPONENT[19]), true);
        display.WriteText(String.Format("Thruster Comp.:     ( {0,5:####0} / {1,5:####0}) {2,5:#####0}\n", MIN_COMPONENT[20], MAX_COMPONENT[20], AMOUNT_COMPONENT[20]), true);
    };

    // print ingot to displays
    foreach(IMyTextSurface display in DISPLAY_INGOT)
    {
        display.ContentType = ContentType.TEXT_AND_IMAGE;
        display.FontSize = 0.6f;

        display.WriteText("--INGOT-----------------------------------\n", false);
        display.WriteText("\n", true);
        display.WriteText(String.Format("Cobalt:                    {0,15:##############0.00}\n", AMOUNT_INGOT[0]), true);
        display.WriteText(String.Format("Gold:                      {0,15:##############0.00}\n", AMOUNT_INGOT[1]), true);
        display.WriteText(String.Format("Gravel:                    {0,15:##############0.00}\n", AMOUNT_INGOT[2]), true);
        display.WriteText(String.Format("Iron:                      {0,15:##############0.00}\n", AMOUNT_INGOT[3]), true);
        display.WriteText(String.Format("Magnesium:                 {0,15:##############0.00}\n", AMOUNT_INGOT[4]), true);
        display.WriteText(String.Format("Nickel:                    {0,15:##############0.00}\n", AMOUNT_INGOT[5]), true);
        display.WriteText(String.Format("Platinum:                  {0,15:##############0.00}\n", AMOUNT_INGOT[6]), true);
        display.WriteText(String.Format("Silicon:                   {0,15:##############0.00}\n", AMOUNT_INGOT[7]), true);
        display.WriteText(String.Format("Silver:                    {0,15:##############0.00}\n", AMOUNT_INGOT[8]), true);
        display.WriteText(String.Format("Uranium:                   {0,15:##############0.00}\n", AMOUNT_INGOT[9]), true);
    };

    /*for(int i=0; i < TYPE_COMPONENT.Count; i++)
    {
        if((0 != MIN_COMPONENT[i]) && (MIN_COMPONENT[i] < AMOUNT_COMPONENT[i]))
        {
            int producingAmount = checkQueue(COMPONENT_NAMES[i]);
            int producingDifference = (MAX_COMPONENT[i] - MIN_COMPONENT[i]) - producingAmount;

            Echo(COMPONENT_NAMES[i] + " " + producingDifference.ToString());
        }
        else
        {
            continue;
        }
    };*/
}

/*public void createAssemblerJob(decimal amount)
{

}*/

public int checkQueue(String searchedItem)
{
    int itemAmount = 0;
    foreach(IMyAssembler assembler in ASSEMBLER_MAIN){
        List<MyProductionItem> items = new List<MyProductionItem>();
        assembler.GetQueue(items);
        foreach(MyProductionItem item in items)
        {
            String[] itemName = item.BlueprintId.ToString().Split('/');
            if(itemName[1] == searchedItem)
            {
                itemAmount += Convert.ToInt32(item.Amount.RawValue);
            }
            else
            {
                continue;
            }
        };
    };

    return itemAmount;
}