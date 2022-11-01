//small screen: 42 char
//wide screen: 75 char

public Program()
{
    //Runtime.UpdateFrequency = UpdateFrequency.Update10;
    getBlocks();
}

public void Main(string argument, UpdateType updateSource)
{
    checkComponentStorage();
    checkAmmoStorage();
    checkMaterialStorage();
}

// ### GLOBALS ###

Dictionary<String, String> specialChar = new Dictionary<String, String>{
    {"BArrowRightWhite", ""},
    {"BArrowRightGreen", ""},
    {"BArrowRightBlue", ""},
    {"BArrowRightYellow", ""},
    {"ArrowRightWhite", ""},
    {"ArrowRightGreen", ""},
    {"ArrowRightBlue", ""},
    {"ArrowRightYellow", ""}
};

List<IMyCargoContainer> CARGO_COMPONENT = new List<IMyCargoContainer>();
List<IMyCargoContainer> CARGO_INGOT = new List<IMyCargoContainer>();
List<IMyCargoContainer> CARGO_ORE = new List<IMyCargoContainer>();
List<IMyCargoContainer> CARGO_AMMO = new List<IMyCargoContainer>();
List<IMyTextSurface> DISPLAY_COMPONENT = new List<IMyTextSurface>();
List<IMyTextSurface> DISPLAY_AMMO = new List<IMyTextSurface>();
List<IMyTextSurface> DISPLAY_MATERIAL = new List<IMyTextSurface>();
List<IMyAssembler> ASSEMBLER_MAIN = new List<IMyAssembler>();

// ###############

public void getBlocks() {

    List<String> CARGO_COMPONENT_NAMES = new List<String>{
        "CARGO - General Storage"
    };

    List<String> CARGO_INGOT_NAMES = new List<String>{
        "CARGO - Ingot"
    };

    List<String> CARGO_ORE_NAMES = new List<String>{
        "CARGO - Ore"
    };

    List<String> CARGO_AMMO_NAMES = new List<String>{
        "CARGO - Ammo"
    };

    List<String> DISPLAY_COMPONENT_NAMES = new List<String>{
        "DISP - Fabrication Component",
        "DISP - Bridge Component"
    };

    List<String> DISPLAY_AMMO_NAMES = new List<String>{
        "DISP - Fabrication Ammunition",
        "DISP - Bridge Ammunition"
    };

    List<String> DISPLAY_MATERIAL_NAMES = new List<String>{
        "DISP - Fabrication Material",
        "DISP - Bridge Material"
    };

    List<String> ASSEMBLER_MAIN_NAMES = new List<String>{
        "ASS - 2 (Primary Auto)",
        "ASS - 5 (Primary Auto)"
    };

    foreach(String cargoName in CARGO_COMPONENT_NAMES) {

        IMyCargoContainer cargo = GridTerminalSystem.GetBlockWithName(cargoName) as IMyCargoContainer;
        if(cargo != null && false == CARGO_COMPONENT.Contains(cargo))
        {
            CARGO_COMPONENT.Add(cargo);
        }
    };

    foreach(String cargoName in CARGO_INGOT_NAMES) {

        IMyCargoContainer cargo = GridTerminalSystem.GetBlockWithName(cargoName) as IMyCargoContainer;
        if(cargo != null && false == CARGO_INGOT.Contains(cargo))
        {
            CARGO_INGOT.Add(cargo);
        }
    };

    foreach(String cargoName in CARGO_ORE_NAMES) {

        IMyCargoContainer cargo = GridTerminalSystem.GetBlockWithName(cargoName) as IMyCargoContainer;
        if(cargo != null && false == CARGO_ORE.Contains(cargo))
        {
            CARGO_ORE.Add(cargo);
        }
    };

    foreach(String cargoName in CARGO_AMMO_NAMES) {

        IMyCargoContainer cargo = GridTerminalSystem.GetBlockWithName(cargoName) as IMyCargoContainer;
        if(cargo != null && false == CARGO_AMMO.Contains(cargo))
        {
            CARGO_AMMO.Add(cargo);
        }
    };

    foreach(String displayName in DISPLAY_COMPONENT_NAMES) {

        IMyTextSurface display = GridTerminalSystem.GetBlockWithName(displayName) as IMyTextSurface;
        if(display != null && false == DISPLAY_COMPONENT.Contains(display))
        {
            DISPLAY_COMPONENT.Add(display);
        }
    };

    foreach(String displayName in DISPLAY_AMMO_NAMES) {

        IMyTextSurface display = GridTerminalSystem.GetBlockWithName(displayName) as IMyTextSurface;
        if(display != null && false == DISPLAY_AMMO.Contains(display))
        {
            DISPLAY_AMMO.Add(display);
        }
    };

    foreach(String displayName in DISPLAY_MATERIAL_NAMES) {

        IMyTextSurface display = GridTerminalSystem.GetBlockWithName(displayName) as IMyTextSurface;
        if(display != null && false == DISPLAY_MATERIAL.Contains(display))
        {
            DISPLAY_MATERIAL.Add(display);
        }
    };

    foreach(String assemblerName in ASSEMBLER_MAIN_NAMES) {

        IMyAssembler assembler = GridTerminalSystem.GetBlockWithName(assemblerName) as IMyAssembler;
        if(assembler != null && false == ASSEMBLER_MAIN.Contains(assembler))
        {
            ASSEMBLER_MAIN.Add(assembler);
        }
    };
}

public void checkComponentStorage() {

    List<String> NAMES_COMPONENT = new List<String> { // list of all component names for assembler queue checking
        /* BULLETPROOF GLASS              */ "BulletproofGlass",
        /* COMPUTER                       */ "ComputerComponent",
        /* CONSTRUCTION COMPONENTS        */ "ConstructionComponent",
        /* DETECTOR COMPONENTS            */ "DetectorComponent",
        /* DISPLAY                        */ "Display",
        /* EXPLOSIVES                     */ "ExplosivesComponent",
        /* GIRDER                         */ "GirderComponent",
        /* GRAVITY GENERATOR COMPONENTS   */ "GravityGeneratorComponent",
        /* INTERIOR PLATE                 */ "InteriorPlate",
        /* LARGE STEEL TUBE               */ "LargeTube",
        /* MEDICAL COMPONENTS             */ "MedicalComponent",
        /* METAL GRID                     */ "MetalGrid",
        /* MOTOR                          */ "MotorComponent",
        /* POWER CELL                     */ "PowerCell",
        /* RADIO-COMMUNICATION COMPONENTS */ "RadioCommunicationComponent",
        /* REACTOR COMPONENTS             */ "ReactorComponent",
        /* SMALL STEEL TUBE               */ "SmallTube",
        /* SOLAR CELL                     */ "SolarCell",
        /* STEEL PLATE                    */ "SteelPlate",
        /* SUPERCONDUCTOR                 */ "Superconductor",
        /* THRUSTER COMPONENTS            */ "ThrustComponent"
    };

    List<double> AMOUNT_COMPONENT = new List<double> { // list of amount of all components
        /* BULLETPROOF GLASS              */ 0d,
        /* COMPUTER                       */ 0d,
        /* CONSTRUCTION COMPONENTS        */ 0d,
        /* DETECTOR COMPONENTS            */ 0d,
        /* DISPLAY                        */ 0d,
        /* EXPLOSIVES                     */ 0d,
        /* GIRDER                         */ 0d,
        /* GRAVITY GENERATOR COMPONENTS   */ 0d,
        /* INTERIOR PLATE                 */ 0d,
        /* LARGE STEEL TUBE               */ 0d,
        /* MEDICAL COMPONENTS             */ 0d,
        /* METAL GRID                     */ 0d,
        /* MOTOR                          */ 0d,
        /* POWER CELL                     */ 0d,
        /* RADIO-COMMUNICATION COMPONENTS */ 0d,
        /* REACTOR COMPONENTS             */ 0d,
        /* SMALL STEEL TUBE               */ 0d,
        /* SOLAR CELL                     */ 0d,
        /* STEEL PLATE                    */ 0d,
        /* SUPERCONDUCTOR                 */ 0d,
        /* THRUSTER COMPONENTS            */ 0d
    };

    List<int> MIN_COMPONENT = new List<int> { // min component amount before assembler start producing
        /* BULLETPROOF GLASS              */ 200,
        /* COMPUTER                       */ 150,
        /* CONSTRUCTION COMPONENTS        */ 10000,
        /* DETECTOR COMPONENTS            */ 0,
        /* DISPLAY                        */ 200,
        /* EXPLOSIVES                     */ 0,
        /* GIRDER                         */ 0,
        /* GRAVITY GENERATOR COMPONENTS   */ 0,
        /* INTERIOR PLATE                 */ 5000,
        /* LARGE STEEL TUBE               */ 1000,
        /* MEDICAL COMPONENTS             */ 0,
        /* METAL GRID                     */ 7000,
        /* MOTOR                          */ 500,
        /* POWER CELL                     */ 0,
        /* RADIO-COMMUNICATION COMPONENTS */ 0,
        /* REACTOR COMPONENTS             */ 0,
        /* SMALL STEEL TUBE               */ 2500,
        /* SOLAR CELL                     */ 0,
        /* STEEL PLATE                    */ 5000,
        /* SUPERCONDUCTOR                 */ 0,
        /* THRUSTER COMPONENTS            */ 0
    };

    List<int> MAX_COMPONENT = new List<int> { // max component amount which assembler targets when producing
        /* BULLETPROOF GLASS              */ 1000,
        /* COMPUTER                       */ 500,
        /* CONSTRUCTION COMPONENTS        */ 20000,
        /* DETECTOR COMPONENTS            */ 0,
        /* DISPLAY                        */ 1000,
        /* EXPLOSIVES                     */ 0,
        /* GIRDER                         */ 0,
        /* GRAVITY GENERATOR COMPONENTS   */ 0,
        /* INTERIOR PLATE                 */ 10000,
        /* LARGE STEEL TUBE               */ 2500,
        /* MEDICAL COMPONENTS             */ 0,
        /* METAL GRID                     */ 10000,
        /* MOTOR                          */ 2000,
        /* POWER CELL                     */ 0,
        /* RADIO-COMMUNICATION COMPONENTS */ 0,
        /* REACTOR COMPONENTS             */ 0,
        /* SMALL STEEL TUBE               */ 5000,
        /* SOLAR CELL                     */ 0,
        /* STEEL PLATE                    */ 10000,
        /* SUPERCONDUCTOR                 */ 0,
        /* THRUSTER COMPONENTS            */ 0
    };

    List<String> ARROW_COMPONENT = new List<String> { // list of status arrows
        /* BULLETPROOF GLASS              */ "",
        /* COMPUTER                       */ "",
        /* CONSTRUCTION COMPONENTS        */ "",
        /* DETECTOR COMPONENTS            */ "",
        /* DISPLAY                        */ "",
        /* EXPLOSIVES                     */ "",
        /* GIRDER                         */ "",
        /* GRAVITY GENERATOR COMPONENTS   */ "",
        /* INTERIOR PLATE                 */ "",
        /* LARGE STEEL TUBE               */ "",
        /* MEDICAL COMPONENTS             */ "",
        /* METAL GRID                     */ "",
        /* MOTOR                          */ "",
        /* POWER CELL                     */ "",
        /* RADIO-COMMUNICATION COMPONENTS */ "",
        /* REACTOR COMPONENTS             */ "",
        /* SMALL STEEL TUBE               */ "",
        /* SOLAR CELL                     */ "",
        /* STEEL PLATE                    */ "",
        /* SUPERCONDUCTOR                 */ "",
        /* THRUSTER COMPONENTS            */ ""
    };

    List<MyItemType> TYPE_COMPONENT = new List<MyItemType> { // list of all component types to check in inventory
        /* BULLETPROOF GLASS              */ new MyItemType("MyObjectBuilder_Component","BulletproofGlass"),
        /* COMPUTER                       */ new MyItemType("MyObjectBuilder_Component","Computer"),
        /* CONSTRUCTION COMPONENTS        */ new MyItemType("MyObjectBuilder_Component","Construction"),
        /* DETECTOR COMPONENTS            */ new MyItemType("MyObjectBuilder_Component","Detector"),
        /* DISPLAY                        */ new MyItemType("MyObjectBuilder_Component","Display"),
        /* EXPLOSIVES                     */ new MyItemType("MyObjectBuilder_Component","Explosives"),
        /* GIRDER                         */ new MyItemType("MyObjectBuilder_Component","Girder"),
        /* GRAVITY GENERATOR COMPONENTS   */ new MyItemType("MyObjectBuilder_Component","Gravity"),
        /* INTERIOR PLATE                 */ new MyItemType("MyObjectBuilder_Component","InteriorPlate"),
        /* LARGE STEEL TUBE               */ new MyItemType("MyObjectBuilder_Component","LargeTube"),
        /* MEDICAL COMPONENTS             */ new MyItemType("MyObjectBuilder_Component","Medical"),
        /* METAL GRID                     */ new MyItemType("MyObjectBuilder_Component","MetalGrid"),
        /* MOTOR                          */ new MyItemType("MyObjectBuilder_Component","Motor"),
        /* POWER CELL                     */ new MyItemType("MyObjectBuilder_Component","PowerCell"),
        /* RADIO-COMMUNICATION COMPONENTS */ new MyItemType("MyObjectBuilder_Component","RadioCommunication"),
        /* REACTOR COMPONENTS             */ new MyItemType("MyObjectBuilder_Component","Reactor"),
        /* SMALL STEEL TUBE               */ new MyItemType("MyObjectBuilder_Component","SmallTube"),
        /* SOLAR CELL                     */ new MyItemType("MyObjectBuilder_Component","SolarCell"),
        /* STEEL PLATE                    */ new MyItemType("MyObjectBuilder_Component","SteelPlate"),
        /* SUPERCONDUCTOR                 */ new MyItemType("MyObjectBuilder_Component","Superconductor"),
        /* THRUSTER COMPONENTS            */ new MyItemType("MyObjectBuilder_Component","Thrust")
    };

    List<MyDefinitionId> BP_COMPONENT = new List<MyDefinitionId> { // list of all blueprints to build in assembler
        /* BULLETPROOF GLASS              */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/BulletproofGlass"),
        /* COMPUTER                       */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/ComputerComponent"),
        /* CONSTRUCTION COMPONENTS        */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/ConstructionComponent"),
        /* DETECTOR COMPONENTS            */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/DetectorComponent"),
        /* DISPLAY                        */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Display"),
        /* EXPLOSIVES                     */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/ExplosivesComponent"),
        /* GIRDER                         */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/GirderComponent"),
        /* GRAVITY GENERATOR COMPONENTS   */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/GravityGeneratorComponent"),
        /* INTERIOR PLATE                 */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/InteriorPlate"),
        /* LARGE STEEL TUBE               */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/LargeTube"),
        /* MEDICAL COMPONENTS             */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/MedicalComponent"),
        /* METAL GRID                     */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/MetalGrid"),
        /* MOTOR                          */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/MotorComponent"),
        /* POWER CELL                     */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/PowerCell"),
        /* RADIO-COMMUNICATION COMPONENTS */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/RadioCommunicationComponent"),
        /* REACTOR COMPONENTS             */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/ReactorComponent"),
        /* SMALL STEEL TUBE               */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/SmallTube"),
        /* SOLAR CELL                     */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/SolarCell"),
        /* STEEL PLATE                    */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/SteelPlate"),
        /* SUPERCONDUCTOR                 */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Superconductor"),
        /* THRUSTER COMPONENTS            */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/ThrustComponent")
    };

    foreach(IMyCargoContainer cargo in CARGO_COMPONENT) { // check inventory for components

        IMyInventory inventory = cargo.GetInventory();

        /* BULLETPROOF GLASS              */ AMOUNT_COMPONENT[0]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[0] ).SerializeString());
        /* COMPUTER                       */ AMOUNT_COMPONENT[1]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[1] ).SerializeString());
        /* CONSTRUCTION COMPONENTS        */ AMOUNT_COMPONENT[2]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[2] ).SerializeString());
        /* DETECTOR COMPONENTS            */ AMOUNT_COMPONENT[3]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[3] ).SerializeString());
        /* DISPLAY                        */ AMOUNT_COMPONENT[4]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[4] ).SerializeString());
        /* EXPLOSIVES                     */ AMOUNT_COMPONENT[5]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[5] ).SerializeString());
        /* GIRDER                         */ AMOUNT_COMPONENT[6]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[6] ).SerializeString());
        /* GRAVITY GENERATOR COMPONENTS   */ AMOUNT_COMPONENT[7]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[7] ).SerializeString());
        /* INTERIOR PLATE                 */ AMOUNT_COMPONENT[8]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[8] ).SerializeString());
        /* LARGE STEEL TUBE               */ AMOUNT_COMPONENT[9]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[9] ).SerializeString());
        /* MEDICAL COMPONENTS             */ AMOUNT_COMPONENT[10] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[10]).SerializeString());
        /* METAL GRID                     */ AMOUNT_COMPONENT[11] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[11]).SerializeString());
        /* MOTOR                          */ AMOUNT_COMPONENT[12] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[12]).SerializeString());
        /* POWER CELL                     */ AMOUNT_COMPONENT[13] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[13]).SerializeString());
        /* RADIO-COMMUNICATION COMPONENTS */ AMOUNT_COMPONENT[14] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[14]).SerializeString());
        /* REACTOR COMPONENTS             */ AMOUNT_COMPONENT[15] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[15]).SerializeString());
        /* SMALL STEEL TUBE               */ AMOUNT_COMPONENT[16] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[16]).SerializeString());
        /* SOLAR CELL                     */ AMOUNT_COMPONENT[17] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[17]).SerializeString());
        /* STEEL PLATE                    */ AMOUNT_COMPONENT[18] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[18]).SerializeString());
        /* SUPERCONDUCTOR                 */ AMOUNT_COMPONENT[19] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[19]).SerializeString());
        /* THRUSTER COMPONENTS            */ AMOUNT_COMPONENT[20] += Convert.ToDouble(inventory.GetItemAmount(TYPE_COMPONENT[20]).SerializeString());
    }

    for(int i=0; i < TYPE_COMPONENT.Count; i++) { // get assembler jobs if not enough inventory

        if(0d != MIN_COMPONENT[i] && MIN_COMPONENT[i] > AMOUNT_COMPONENT[i]) {

            double producingAmount = checkAssemblerQueue(NAMES_COMPONENT[i]);
            double producingDifference = (MIN_COMPONENT[i] - AMOUNT_COMPONENT[i]) + (MAX_COMPONENT[i] - MIN_COMPONENT[i]) - producingAmount;

            if(producingDifference > 0d && (producingAmount + AMOUNT_COMPONENT[i]) < MIN_COMPONENT[i]) {
                ARROW_COMPONENT[i] = specialChar["ArrowRightBlue"];
                createAssemblerJob(producingDifference, BP_COMPONENT[i]);
            }
            else if(producingAmount != 0) {
                ARROW_COMPONENT[i] = specialChar["ArrowRightBlue"];
            }
        }
        else if (0d != MIN_COMPONENT[i] && MIN_COMPONENT[i] < AMOUNT_COMPONENT[i]) {
            ARROW_COMPONENT[i] = specialChar["ArrowRightGreen"];
        }
        else {
            ARROW_COMPONENT[i] = specialChar["ArrowRightYellow"];
            continue;
        }
    }

    foreach(IMyTextSurface display in DISPLAY_COMPONENT) { // print to display

        display.ContentType = ContentType.TEXT_AND_IMAGE;
        display.FontSize = 0.675f;
        display.Font = "Monospace";

        display.WriteText("--MATERIAL-----------------------------------------------------------------\n", false);
        display.WriteText("\n", true);
        display.WriteText("  Component                                    Storage        Min / Wanted\n\n", true);
        display.WriteText(String.Format("{0} Bulletproof Glass:              {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[0] , AMOUNT_COMPONENT[0] , MIN_COMPONENT[0] , MAX_COMPONENT[0] ), true);
        display.WriteText(String.Format("{0} Computer:                       {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[1] , AMOUNT_COMPONENT[1] , MIN_COMPONENT[1] , MAX_COMPONENT[1] ), true);
        display.WriteText(String.Format("{0} Construction Component:         {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[2] , AMOUNT_COMPONENT[2] , MIN_COMPONENT[2] , MAX_COMPONENT[2] ), true);
        display.WriteText(String.Format("{0} Detector Component:             {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[3] , AMOUNT_COMPONENT[3] , MIN_COMPONENT[3] , MAX_COMPONENT[3] ), true);
        display.WriteText(String.Format("{0} Display:                        {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[4] , AMOUNT_COMPONENT[4] , MIN_COMPONENT[4] , MAX_COMPONENT[4] ), true);
        display.WriteText(String.Format("{0} Explosives:                     {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[5] , AMOUNT_COMPONENT[5] , MIN_COMPONENT[5] , MAX_COMPONENT[5] ), true);
        display.WriteText(String.Format("{0} Girder:                         {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[6] , AMOUNT_COMPONENT[6] , MIN_COMPONENT[6] , MAX_COMPONENT[6] ), true);
        display.WriteText(String.Format("{0} Gravity Component:              {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[7] , AMOUNT_COMPONENT[7] , MIN_COMPONENT[7] , MAX_COMPONENT[7] ), true);
        display.WriteText(String.Format("{0} Interior Plate:                 {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[8] , AMOUNT_COMPONENT[8] , MIN_COMPONENT[8] , MAX_COMPONENT[8] ), true);
        display.WriteText(String.Format("{0} Large Tube:                     {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[9] , AMOUNT_COMPONENT[9] , MIN_COMPONENT[9] , MAX_COMPONENT[9] ), true);
        display.WriteText(String.Format("{0} Medical Component:              {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[10], AMOUNT_COMPONENT[10], MIN_COMPONENT[10], MAX_COMPONENT[10]), true);
        display.WriteText(String.Format("{0} Metal Grid:                     {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[11], AMOUNT_COMPONENT[11], MIN_COMPONENT[11], MAX_COMPONENT[11]), true);
        display.WriteText(String.Format("{0} Motor:                          {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[12], AMOUNT_COMPONENT[12], MIN_COMPONENT[12], MAX_COMPONENT[12]), true);
        display.WriteText(String.Format("{0} Power Cell:                     {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[13], AMOUNT_COMPONENT[13], MIN_COMPONENT[13], MAX_COMPONENT[13]), true);
        display.WriteText(String.Format("{0} Radiocommunication Component:   {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[14], AMOUNT_COMPONENT[14], MIN_COMPONENT[14], MAX_COMPONENT[14]), true);
        display.WriteText(String.Format("{0} Reactor Component:              {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[15], AMOUNT_COMPONENT[15], MIN_COMPONENT[15], MAX_COMPONENT[15]), true);
        display.WriteText(String.Format("{0} Small Tube:                     {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[16], AMOUNT_COMPONENT[16], MIN_COMPONENT[16], MAX_COMPONENT[16]), true);
        display.WriteText(String.Format("{0} Solar Cell:                     {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[17], AMOUNT_COMPONENT[17], MIN_COMPONENT[17], MAX_COMPONENT[17]), true);
        display.WriteText(String.Format("{0} Steel Plate:                    {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[18], AMOUNT_COMPONENT[18], MIN_COMPONENT[18], MAX_COMPONENT[18]), true);
        display.WriteText(String.Format("{0} Superconductor:                 {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[19], AMOUNT_COMPONENT[19], MIN_COMPONENT[19], MAX_COMPONENT[19]), true);
        display.WriteText(String.Format("{0} Thruster Component:             {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_COMPONENT[20], AMOUNT_COMPONENT[20], MIN_COMPONENT[20], MAX_COMPONENT[20]), true);
    }
}

public void checkAmmoStorage() {

    List<String> NAMES_AMMO = new List<String> { // list of all ammo names for assembler queue checking
        /* GATLING AMMO BOX     */ "NATO_25x184mm",
        /* MISSILE              */ "Missile200mm",
        /* S-10 MAGAZINE        */ "SemiAutoPistolMagazine",
        /* S-10E MAGAZINE       */ "ElitePistolMagazine",
        /* S-20A MAGAZINE       */ "FullAutoPistolMagazine",
        /* MR-20 MAGAZINE       */ "AutomaticRifleGun_Mag_20rd",
        /* MR-8P MAGAZINE       */ "PreciseAutomaticRifleGun_Mag_5rd",
        /* MR-50A MAGAZINE      */ "RapidFireAutomaticRifleGun_Mag_50rd",
        /* MR-30E MAGAZINE      */ "UltimateAutomaticRifleGun_Mag_30rd",
        /* AUTOCANNON MAGAZINE  */ "AutocannonClip",
        /* ARTILLERY SHELL      */ "LargeCalibreAmmo",
        /* ASSAULT CANNON SHELL */ "MediumCalibreAmmo",
        /* SMALL RAILGUN SABOT  */ "SmallRailgunAmmo",
        /* LARGE RAILGUN SABOT  */ "LargeRailgunAmmo"
    };

    List<double> AMOUNT_AMMO = new List<double> { // list of amount of all ammo
        /* GATLING AMMO BOX     */ 0d,
        /* MISSILE              */ 0d,
        /* S-10 MAGAZINE        */ 0d,
        /* S-10E MAGAZINE       */ 0d,
        /* S-20A MAGAZINE       */ 0d,
        /* MR-20 MAGAZINE       */ 0d,
        /* MR-8P MAGAZINE       */ 0d,
        /* MR-50A MAGAZINE      */ 0d,
        /* MR-30E MAGAZINE      */ 0d,
        /* AUTOCANNON MAGAZINE  */ 0d,
        /* ARTILLERY SHELL      */ 0d,
        /* ASSAULT CANNON SHELL */ 0d,
        /* SMALL RAILGUN SABOT  */ 0d,
        /* LARGE RAILGUN SABOT  */ 0d
    };

    List<int> MIN_AMMO = new List<int> { // min ammo amount before assembler start producing
        /* GATLING AMMO BOX     */ 0,
        /* MISSILE              */ 0,
        /* S-10 MAGAZINE        */ 0,
        /* S-10E MAGAZINE       */ 0,
        /* S-20A MAGAZINE       */ 0,
        /* MR-20 MAGAZINE       */ 0,
        /* MR-8P MAGAZINE       */ 0,
        /* MR-50A MAGAZINE      */ 0,
        /* MR-30E MAGAZINE      */ 0,
        /* AUTOCANNON MAGAZINE  */ 0,
        /* ARTILLERY SHELL      */ 0,
        /* ASSAULT CANNON SHELL */ 0,
        /* SMALL RAILGUN SABOT  */ 0,
        /* LARGE RAILGUN SABOT  */ 0
    };

    List<int> MAX_AMMO = new List<int> { // max ammo amount which assembler targets when producing
        /* GATLING AMMO BOX     */ 0,
        /* MISSILE              */ 0,
        /* S-10 MAGAZINE        */ 0,
        /* S-10E MAGAZINE       */ 0,
        /* S-20A MAGAZINE       */ 0,
        /* MR-20 MAGAZINE       */ 0,
        /* MR-8P MAGAZINE       */ 0,
        /* MR-50A MAGAZINE      */ 0,
        /* MR-30E MAGAZINE      */ 0,
        /* AUTOCANNON MAGAZINE  */ 0,
        /* ARTILLERY SHELL      */ 0,
        /* ASSAULT CANNON SHELL */ 0,
        /* SMALL RAILGUN SABOT  */ 0,
        /* LARGE RAILGUN SABOT  */ 0
    };

    List<String> ARROW_AMMO = new List<String> { // list of status arrows
        /* GATLING AMMO BOX     */ "",
        /* MISSILE              */ "",
        /* S-10 MAGAZINE        */ "",
        /* S-10E MAGAZINE       */ "",
        /* S-20A MAGAZINE       */ "",
        /* MR-20 MAGAZINE       */ "",
        /* MR-8P MAGAZINE       */ "",
        /* MR-50A MAGAZINE      */ "",
        /* MR-30E MAGAZINE      */ "",
        /* AUTOCANNON MAGAZINE  */ "",
        /* ARTILLERY SHELL      */ "",
        /* ASSAULT CANNON SHELL */ "",
        /* SMALL RAILGUN SABOT  */ "",
        /* LARGE RAILGUN SABOT  */ ""
    };

    List<MyItemType> TYPE_AMMO = new List<MyItemType> { // list of all ammo types to check in inventory
        /* GATLING AMMO BOX     */ new MyItemType("MyObjectBuilder_AmmoMagazine","NATO_25x184mm"),
        /* MISSILE              */ new MyItemType("MyObjectBuilder_AmmoMagazine","Missile200mm"),
        /* S-10 MAGAZINE        */ new MyItemType("MyObjectBuilder_AmmoMagazine","SemiAutoPistolMagazine"),
        /* S-10E MAGAZINE       */ new MyItemType("MyObjectBuilder_AmmoMagazine","ElitePistolMagazine"),
        /* S-20A MAGAZINE       */ new MyItemType("MyObjectBuilder_AmmoMagazine","FullAutoPistolMagazine"),
        /* MR-20 MAGAZINE       */ new MyItemType("MyObjectBuilder_AmmoMagazine","AutomaticRifleGun_Mag_20rd"),
        /* MR-8P MAGAZINE       */ new MyItemType("MyObjectBuilder_AmmoMagazine","PreciseAutomaticRifleGun_Mag_5rd"),
        /* MR-50A MAGAZINE      */ new MyItemType("MyObjectBuilder_AmmoMagazine","RapidFireAutomaticRifleGun_Mag_50rd"),
        /* MR-30E MAGAZINE      */ new MyItemType("MyObjectBuilder_AmmoMagazine","UltimateAutomaticRifleGun_Mag_30rd"),
        /* AUTOCANNON MAGAZINE  */ new MyItemType("MyObjectBuilder_AmmoMagazine","AutocannonClip"),
        /* ARTILLERY SHELL      */ new MyItemType("MyObjectBuilder_AmmoMagazine","LargeCalibreAmmo"),
        /* ASSAULT CANNON SHELL */ new MyItemType("MyObjectBuilder_AmmoMagazine","MediumCalibreAmmo"),
        /* SMALL RAILGUN SABOT  */ new MyItemType("MyObjectBuilder_AmmoMagazine","SmallRailgunAmmo"),
        /* LARGE RAILGUN SABOT  */ new MyItemType("MyObjectBuilder_AmmoMagazine","LargeRailgunAmmo")
    };

    List<MyDefinitionId> BP_AMMO = new List<MyDefinitionId> { // list of all blueprints to build in assembler
        /* GATLING AMMO BOX     */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/NATO_25x184mmMagazine"),
        /* MISSILE              */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/Missile200mm"),
        /* S-10 MAGAZINE        */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/SemiAutoPistolMagazine"),
        /* S-10E MAGAZINE       */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/ElitePistolMagazine"),
        /* S-20A MAGAZINE       */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/FullAutoPistolMagazine"),
        /* MR-20 MAGAZINE       */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/AutomaticRifleGun_Mag_20rd"),
        /* MR-8P MAGAZINE       */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/PreciseAutomaticRifleGun_Mag_5rd"),
        /* MR-50A MAGAZINE      */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/RapidFireAutomaticRifleGun_Mag_50rd"),
        /* MR-30E MAGAZINE      */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/UltimateAutomaticRifleGun_Mag_30rd"),
        /* AUTOCANNON MAGAZINE  */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/AutocannonClip"),
        /* ARTILLERY SHELL      */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/LargeCalibreAmmo"),
        /* ASSAULT CANNON SHELL */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/MediumCalibreAmmo"),
        /* SMALL RAILGUN SABOT  */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/SmallRailgunAmmo"),
        /* LARGE RAILGUN SABOT  */ MyDefinitionId.Parse("MyObjectBuilder_BlueprintDefinition/LargeRailgunAmmo")
    };

    foreach(IMyCargoContainer cargo in CARGO_AMMO) { // check inventory for ammo

        IMyInventory inventory = cargo.GetInventory();

        /* GATLING AMMO BOX     */ AMOUNT_AMMO[0]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[0] ).SerializeString());
        /* MISSILE              */ AMOUNT_AMMO[1]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[1] ).SerializeString());
        /* S-10 MAGAZINE        */ AMOUNT_AMMO[2]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[2] ).SerializeString());
        /* S-10E MAGAZINE       */ AMOUNT_AMMO[3]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[3] ).SerializeString());
        /* S-20A MAGAZINE       */ AMOUNT_AMMO[4]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[4] ).SerializeString());
        /* MR-20 MAGAZINE       */ AMOUNT_AMMO[5]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[5] ).SerializeString());
        /* MR-8P MAGAZINE       */ AMOUNT_AMMO[6]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[6] ).SerializeString());
        /* MR-50A MAGAZINE      */ AMOUNT_AMMO[7]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[7] ).SerializeString());
        /* MR-30E MAGAZINE      */ AMOUNT_AMMO[8]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[8] ).SerializeString());
        /* AUTOCANNON MAGAZINE  */ AMOUNT_AMMO[9]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[9] ).SerializeString());
        /* ARTILLERY SHELL      */ AMOUNT_AMMO[10] += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[10]).SerializeString());
        /* ASSAULT CANNON SHELL */ AMOUNT_AMMO[11] += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[11]).SerializeString());
        /* SMALL RAILGUN SABOT  */ AMOUNT_AMMO[12] += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[12]).SerializeString());
        /* LARGE RAILGUN SABOT  */ AMOUNT_AMMO[13] += Convert.ToDouble(inventory.GetItemAmount(TYPE_AMMO[13]).SerializeString());
    }

    for(int i=0; i < TYPE_AMMO.Count; i++) { // get assembler jobs if not enough inventory

        if(0d != MIN_AMMO[i] && MIN_AMMO[i] > AMOUNT_AMMO[i]) {

            double producingAmount = checkAssemblerQueue(NAMES_AMMO[i]);
            double producingDifference = (MIN_AMMO[i] - AMOUNT_AMMO[i]) + (MAX_AMMO[i] - MIN_AMMO[i]) - producingAmount;

            if(producingDifference > 0d && (producingAmount + AMOUNT_AMMO[i]) < MIN_AMMO[i]) {
                ARROW_AMMO[i] = specialChar["ArrowRightBlue"];
                createAssemblerJob(producingDifference, BP_AMMO[i]);
            }
            else if(producingAmount != 0) {
                ARROW_AMMO[i] = specialChar["ArrowRightBlue"];
            }
        }
        else if (0d != MIN_AMMO[i] && MIN_AMMO[i] < AMOUNT_AMMO[i]) {
            ARROW_AMMO[i] = specialChar["ArrowRightGreen"];
        }
        else {
            ARROW_AMMO[i] = specialChar["ArrowRightYellow"];
            continue;
        }
    }

    foreach(IMyTextSurface display in DISPLAY_AMMO) { // print to display

        display.ContentType = ContentType.TEXT_AND_IMAGE;
        display.FontSize = 0.675f;
        display.Font = "Monospace";

        display.WriteText("--AMMUNITION---------------------------------------------------------------\n", false);
        display.WriteText("\n", true);
        display.WriteText("  Ammunition                                   Storage        Min / Wanted\n\n", true);
        display.WriteText(String.Format("{0} Gatling Ammo Box:               {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[0] , AMOUNT_AMMO[0] , MIN_AMMO[0] , MAX_AMMO[0] ), true);
        display.WriteText(String.Format("{0} Missile:                        {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[1] , AMOUNT_AMMO[1] , MIN_AMMO[1] , MAX_AMMO[1] ), true);
        display.WriteText(String.Format("{0} S-10 Magazine:                  {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[2] , AMOUNT_AMMO[2] , MIN_AMMO[2] , MAX_AMMO[2] ), true);
        display.WriteText(String.Format("{0} S-10E Magazine:                 {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[3] , AMOUNT_AMMO[3] , MIN_AMMO[3] , MAX_AMMO[3] ), true);
        display.WriteText(String.Format("{0} S-20A Magazine:                 {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[4] , AMOUNT_AMMO[4] , MIN_AMMO[4] , MAX_AMMO[4] ), true);
        display.WriteText(String.Format("{0} MR-20 Magazine:                 {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[5] , AMOUNT_AMMO[5] , MIN_AMMO[5] , MAX_AMMO[5] ), true);
        display.WriteText(String.Format("{0} MR-8P Magazine:                 {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[6] , AMOUNT_AMMO[6] , MIN_AMMO[6] , MAX_AMMO[6] ), true);
        display.WriteText(String.Format("{0} MR-50A Magazine:                {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[7] , AMOUNT_AMMO[7] , MIN_AMMO[7] , MAX_AMMO[7] ), true);
        display.WriteText(String.Format("{0} MR-30E Magazine:                {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[8] , AMOUNT_AMMO[8] , MIN_AMMO[8] , MAX_AMMO[8] ), true);
        display.WriteText(String.Format("{0} Autocannon Magazine:            {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[9] , AMOUNT_AMMO[9] , MIN_AMMO[9] , MAX_AMMO[9] ), true);
        display.WriteText(String.Format("{0} Artillery Shell:                {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[10], AMOUNT_AMMO[10], MIN_AMMO[10], MAX_AMMO[10]), true);
        display.WriteText(String.Format("{0} Assault Cannon Shell:           {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[11], AMOUNT_AMMO[11], MIN_AMMO[11], MAX_AMMO[11]), true);
        display.WriteText(String.Format("{0} Small Railgun Sabot:            {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[12], AMOUNT_AMMO[12], MIN_AMMO[12], MAX_AMMO[12]), true);
        display.WriteText(String.Format("{0} Large Railgun Sabot:            {1,20:####################0}   [ {2,6:#####0} / {3,6:#####0}]\n", ARROW_AMMO[13], AMOUNT_AMMO[13], MIN_AMMO[13], MAX_AMMO[13]), true);
    }
}

public void checkMaterialStorage() {

    List<double> AMOUNT_INGOT = new List<double> { // list of amount of all ingot
        /* COBALT    */ 0d,
        /* GOLD      */ 0d,
        /* GRAVEL    */ 0d,
        /* IRON      */ 0d,
        /* MAGNESIUM */ 0d,
        /* NICKEL    */ 0d,
        /* PLATINUM  */ 0d,
        /* SILICON   */ 0d,
        /* SILVER    */ 0d,
        /* URANIUM   */ 0d
    };

    List<double> AMOUNT_ORE = new List<double> { // list of amount of all ore
        /* COBALT    */ 0d,
        /* GOLD      */ 0d,
        /* GRAVEL    */ 0d,
        /* IRON      */ 0d,
        /* MAGNESIUM */ 0d,
        /* NICKEL    */ 0d,
        /* PLATINUM  */ 0d,
        /* SILICON   */ 0d,
        /* SILVER    */ 0d,
        /* URANIUM   */ 0d,
        /* STONE     */ 0d,
        /* ICE       */ 0d
    };

    List<MyItemType> TYPE_INGOT = new List<MyItemType> { // list of all ingot types to check in inventory
        /* COBALT    */ new MyItemType("MyObjectBuilder_Ingot","Cobalt"),
        /* GOLD      */ new MyItemType("MyObjectBuilder_Ingot","Gold"),
        /* GRAVEL    */ new MyItemType("MyObjectBuilder_Ingot","Stone"),
        /* IRON      */ new MyItemType("MyObjectBuilder_Ingot","Iron"),
        /* MAGNESIUM */ new MyItemType("MyObjectBuilder_Ingot","Magnesium"),
        /* NICKEL    */ new MyItemType("MyObjectBuilder_Ingot","Nickel"),
        /* PLATINUM  */ new MyItemType("MyObjectBuilder_Ingot","Platinum"),
        /* SILICON   */ new MyItemType("MyObjectBuilder_Ingot","Silicon"),
        /* SILVER    */ new MyItemType("MyObjectBuilder_Ingot","Silver"),
        /* URANIUM   */ new MyItemType("MyObjectBuilder_Ingot","Uranium")
    };

    List<MyItemType> TYPE_ORE = new List<MyItemType> { // list of all ore types to check in inventory
        /* COBALT    */ new MyItemType("MyObjectBuilder_Ore","Cobalt"),
        /* GOLD      */ new MyItemType("MyObjectBuilder_Ore","Gold"),
        /* GRAVEL    */ new MyItemType("MyObjectBuilder_Ore","Stone"),
        /* IRON      */ new MyItemType("MyObjectBuilder_Ore","Iron"),
        /* MAGNESIUM */ new MyItemType("MyObjectBuilder_Ore","Magnesium"),
        /* NICKEL    */ new MyItemType("MyObjectBuilder_Ore","Nickel"),
        /* PLATINUM  */ new MyItemType("MyObjectBuilder_Ore","Platinum"),
        /* SILICON   */ new MyItemType("MyObjectBuilder_Ore","Silicon"),
        /* SILVER    */ new MyItemType("MyObjectBuilder_Ore","Silver"),
        /* URANIUM   */ new MyItemType("MyObjectBuilder_Ore","Uranium"),
        /* STONE     */ new MyItemType("MyObjectBuilder_Ore","Stone"),
        /* ICE       */ new MyItemType("MyObjectBuilder_Ore","Ice")
    };

    foreach(IMyCargoContainer cargo in CARGO_INGOT) { // check inventory for ingot

        IMyInventory inventory = cargo.GetInventory();

        /* COBALT    */ AMOUNT_INGOT[0] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[0]).SerializeString());
        /* GOLD      */ AMOUNT_INGOT[1] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[1]).SerializeString());
        /* GRAVEL    */ AMOUNT_INGOT[2] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[2]).SerializeString());
        /* IRON      */ AMOUNT_INGOT[3] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[3]).SerializeString());
        /* MAGNESIUM */ AMOUNT_INGOT[4] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[4]).SerializeString());
        /* NICKEL    */ AMOUNT_INGOT[5] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[5]).SerializeString());
        /* PLATINUM  */ AMOUNT_INGOT[6] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[6]).SerializeString());
        /* SILICON   */ AMOUNT_INGOT[7] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[7]).SerializeString());
        /* SILVER    */ AMOUNT_INGOT[8] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[8]).SerializeString());
        /* URANIUM   */ AMOUNT_INGOT[9] += Convert.ToDouble(inventory.GetItemAmount(TYPE_INGOT[9]).SerializeString());
    }

    foreach(IMyCargoContainer cargo in CARGO_ORE) { // check inventory for ore

        IMyInventory inventory = cargo.GetInventory();

        /* COBALT    */ AMOUNT_ORE[0]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[0] ).SerializeString());
        /* GOLD      */ AMOUNT_ORE[1]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[1] ).SerializeString());
        /* GRAVEL    */ AMOUNT_ORE[2]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[2] ).SerializeString());
        /* IRON      */ AMOUNT_ORE[3]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[3] ).SerializeString());
        /* MAGNESIUM */ AMOUNT_ORE[4]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[4] ).SerializeString());
        /* NICKEL    */ AMOUNT_ORE[5]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[5] ).SerializeString());
        /* PLATINUM  */ AMOUNT_ORE[6]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[6] ).SerializeString());
        /* SILICON   */ AMOUNT_ORE[7]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[7] ).SerializeString());
        /* SILVER    */ AMOUNT_ORE[8]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[8] ).SerializeString());
        /* URANIUM   */ AMOUNT_ORE[9]  += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[9] ).SerializeString());
        /* STONE     */ AMOUNT_ORE[10] += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[10]).SerializeString());
        /* ICE       */ AMOUNT_ORE[11] += Convert.ToDouble(inventory.GetItemAmount(TYPE_ORE[11]).SerializeString());
    }

    foreach(IMyTextSurface display in DISPLAY_MATERIAL) { // print to display

        display.ContentType = ContentType.TEXT_AND_IMAGE;
        display.FontSize = 0.675f;
        display.Font = "Monospace";

        display.WriteText("--INGOT-----------------------------   --ORE-------------------------------\n", false);
        display.WriteText("\n", true);
        display.WriteText(String.Format("{0} Cobalt:            {1,15:##############0.00}   {0} Cobalt:            {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[0], AMOUNT_ORE[0]), true);
        display.WriteText(String.Format("{0} Gold:              {1,15:##############0.00}   {0} Gold:              {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[1], AMOUNT_ORE[1]), true);
        display.WriteText(String.Format("{0} Gravel:            {1,15:##############0.00}   {0} Gravel:            {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[2], AMOUNT_ORE[2]), true);
        display.WriteText(String.Format("{0} Iron:              {1,15:##############0.00}   {0} Iron:              {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[3], AMOUNT_ORE[3]), true);
        display.WriteText(String.Format("{0} Magnesium:         {1,15:##############0.00}   {0} Magnesium:         {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[4], AMOUNT_ORE[4]), true);
        display.WriteText(String.Format("{0} Nickel:            {1,15:##############0.00}   {0} Nickel:            {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[5], AMOUNT_ORE[5]), true);
        display.WriteText(String.Format("{0} Platinum:          {1,15:##############0.00}   {0} Platinum:          {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[6], AMOUNT_ORE[6]), true);
        display.WriteText(String.Format("{0} Silicon:           {1,15:##############0.00}   {0} Silicon:           {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[7], AMOUNT_ORE[7]), true);
        display.WriteText(String.Format("{0} Silver:            {1,15:##############0.00}   {0} Silver:            {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[8], AMOUNT_ORE[8]), true);
        display.WriteText(String.Format("{0} Uranium:           {1,15:##############0.00}   {0} Uranium:           {2,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_INGOT[9], AMOUNT_ORE[9]), true);
        display.WriteText(String.Format("                                       {0} Stone:             {1,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_ORE[10]), true);
        display.WriteText(String.Format("                                       {0} Ice:               {1,15:##############0.00}\n", specialChar["ArrowRightWhite"], AMOUNT_ORE[11]), true);
    }
}

public void checkGasTank() {

}

public void createAssemblerJob(double amount, MyDefinitionId blueprint)
{
    double producingAmount = Math.Ceiling(amount/ASSEMBLER_MAIN.Count);

    foreach(IMyAssembler assembler in ASSEMBLER_MAIN)
    {
        assembler.AddQueueItem(blueprint, producingAmount);
    }
}

public double checkAssemblerQueue(String searchedItem)
{
    double itemAmount = 0;
    foreach(IMyAssembler assembler in ASSEMBLER_MAIN){
        List<MyProductionItem> items = new List<MyProductionItem>();
        assembler.GetQueue(items);
        foreach(MyProductionItem item in items)
        {
            String[] itemName = item.BlueprintId.ToString().Split('/');
            if(itemName[1] == searchedItem)
            {
                itemAmount += Convert.ToDouble(item.Amount.SerializeString());
            }
            else
            {
                continue;
            }
        };
    };

    return itemAmount;
}
