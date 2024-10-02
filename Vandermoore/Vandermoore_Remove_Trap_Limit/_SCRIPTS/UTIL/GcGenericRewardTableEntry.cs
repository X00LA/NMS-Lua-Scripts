//=============================================================================

public class GenericRewardTableEntry
{
	public static GcGenericRewardTableEntry Create(
		string                  ID,
		RewardChoiceEnum        CHOICE             = RewardChoiceEnum.GiveAll,
		List<GcRewardTableItem> LIST               = null,
		bool                    OVERRIDE_ZERO_SEED = false
	) => new() {
		Id   = ID,
		List = new() {
			RewardChoice     = CHOICE,
			OverrideZeroSeed = OVERRIDE_ZERO_SEED,
			List             = LIST ?? new()
		}
	};
}

//=============================================================================

public static partial class _x_
{
	public static GcGenericRewardTableEntry Find(
		this List<GcGenericRewardTableEntry> LIST,
		string                               ID
	) => LIST.Find(ENTRY => ENTRY.Id == ID);

	//...........................................................
	
	public static void Add(
		this GcGenericRewardTableEntry ENTRY,
		GcRewardTableItem              ITEM
	) => ENTRY.List.List.Add(ITEM);

	//...........................................................
	
	public static void AddRange(
		this GcGenericRewardTableEntry ENTRY,
		IEnumerable<GcRewardTableItem> LIST
	) => ENTRY.List.List.AddRange(LIST);
}

//=============================================================================
