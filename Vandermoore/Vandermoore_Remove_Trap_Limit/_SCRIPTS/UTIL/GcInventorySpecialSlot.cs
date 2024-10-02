//=============================================================================

public partial class Inventory
{
	protected static GcInventorySpecialSlot SpecialSlot(
		InventorySpecialSlotTypeEnum TYPE,
		int X, int Y
	) => new() {
		Type  = new() { InventorySpecialSlotType = TYPE },
		Index = new() { X = X, Y = Y }
	};

	//...........................................................
	
	protected static GcInventorySpecialSlot Broken(
		int X, int Y
	) => SpecialSlot(InventorySpecialSlotTypeEnum.Broken, X, Y);

	//...........................................................
	
	protected static GcInventorySpecialSlot TechOnly(
		int X, int Y
	) => SpecialSlot(InventorySpecialSlotTypeEnum.TechOnly, X, Y);

	//...........................................................
	
	protected static GcInventorySpecialSlot Cargo(
		int X, int Y
	) => SpecialSlot(InventorySpecialSlotTypeEnum.Cargo, X, Y);

	//...........................................................
	
	protected static GcInventorySpecialSlot BlockedByBrokenTech(
		int X, int Y
	) => SpecialSlot(InventorySpecialSlotTypeEnum.BlockedByBrokenTech, X, Y);

	//...........................................................
	
	protected static GcInventorySpecialSlot TechBonus(
		int X, int Y
	) => SpecialSlot(InventorySpecialSlotTypeEnum.TechBonus, X, Y);
}

//=============================================================================
