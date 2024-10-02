//=============================================================================

public class Remove_Trap_Limit : cmk.NMS.Script.ModClass
{
    protected override void Execute()
    {
        var mbin = ExtractMbin<GcBaseBuildingTable>(
            "METADATA/REALITY/TABLES/BASEBUILDINGOBJECTSTABLE.MBIN"
        );

        // Iterate through each entry in the table and modify PlanetLimit to 0
        foreach (var buildingEntry in mbin.Objects) // Accessing Objects list
        {
            if (buildingEntry.PlanetLimit > 0) // Check if PlanetLimit is set
            {
                buildingEntry.PlanetLimit = 0; // Set PlanetLimit to 0
            }
        }
    }

    //...........................................................
}

//=============================================================================