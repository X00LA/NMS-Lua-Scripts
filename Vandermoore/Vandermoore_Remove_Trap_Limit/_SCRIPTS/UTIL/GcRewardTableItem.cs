//=============================================================================

public class RewardTableItem
{
	public static GcRewardTableItem Units(
		int MIN,
		int MAX = 0,
		float CHANCE = 100.0f,  // 0 - 100
		string LABEL_ID = null
	)
	{
		if( MAX == 0 ) MAX = MIN;
		return new() {
			Reward = new GcRewardMoney {
				AmountMin   = MIN,
				AmountMax   = MAX,
				RoundNumber = false,
				Currency    = new() { Currency = CurrencyEnum.Units }
			},
			PercentageChance = CHANCE,
			LabelID = LABEL_ID ?? ""
		};
	}

	//...........................................................

	public static GcRewardTableItem Nanites(
		int MIN,
		int MAX = 0,
		float CHANCE = 100.0f,  // 0 - 100
		string LABEL_ID = null
	)
	{
		if( MAX == 0 ) MAX = MIN;
		return new() {
			Reward = new GcRewardMoney {
				AmountMin   = MIN,
				AmountMax   = MAX,
				RoundNumber = false,
				Currency    = new() { Currency = CurrencyEnum.Nanites }
			},
			PercentageChance = CHANCE,
			LabelID = LABEL_ID ?? ""
		};
	}

	//...........................................................

	public static GcRewardTableItem Specials(
		int MIN,
		int MAX = 0,
		float CHANCE = 100.0f,  // 0 - 100
		string LABEL_ID = null
	)
	{
		if( MAX == 0 ) MAX = MIN;
		return new() {
			Reward = new GcRewardMoney {
				AmountMin   = MIN,
				AmountMax   = MAX,
				RoundNumber = false,
				Currency    = new() { Currency = CurrencyEnum.Specials }
			},
			PercentageChance = CHANCE,
			LabelID = LABEL_ID ?? ""
		};
	}

	//...........................................................

	public static GcRewardTableItem TeachWord(
		RaceEnum RACE,
		wordcategorytableEnumEnum CATEGORY = wordcategorytableEnumEnum.MISC,
		float CHANCE = 100.0f,  // 0 - 100
		string LABEL_ID = null
	) => new() {
		Reward = new GcRewardTeachWord {
			Race        = new() { AlienRace = RACE },
			UseCategory = CATEGORY != wordcategorytableEnumEnum.MISC,
			Category    = new() { wordcategorytableEnum = CATEGORY },
			AmountMin   = 1,
			AmountMax   = 1
		},
		PercentageChance = CHANCE,
		LabelID = LABEL_ID ?? ""
	};

	//...........................................................

	public static GcRewardTableItem SpecificSubstance(
		string ID,
		int MIN = 1,
		int MAX = 1,
		float CHANCE = 100.0f,  // 0 - 100
		string LABEL_ID = null
	) => new() {
		Reward = new GcRewardSpecificSubstance {
			ID = ID,
			AmountMin = MIN,
			AmountMax = MAX,
		},
		PercentageChance = CHANCE,
		LabelID = LABEL_ID ?? ""
	};

	//...........................................................

	public static GcRewardTableItem SpecificProduct(
		string ID,
		int MIN = 1,
		int MAX = 1,
		float CHANCE = 100.0f,  // 0 - 100
		string LABEL_ID = null
	) => new() {
		Reward = new GcRewardSpecificProduct {
			ID = ID,
			AmountMin = MIN,
			AmountMax = MAX,
		},
		PercentageChance = CHANCE,
		LabelID = LABEL_ID ?? ""
	};

	//...........................................................

	public static GcRewardTableItem SpecificTechnology(
		string ID,
		float CHANCE = 100.0f,  // 0 - 100
		string LABEL_ID = null
	) => new() {
		Reward = new GcRewardSpecificTech {
			TechId = ID
		},
		PercentageChance = CHANCE,
		LabelID = LABEL_ID ?? ""
	};

	//...........................................................

	public static GcRewardTableItem SpecificTechnologyFromList(
		List<nms.NMSString0x10> LIST,
		bool FAIL_IF_ALL_KNOWN = true,
		TechListRewardOrderEnum ORDER = TechListRewardOrderEnum.InOrder,
		float CHANCE = 100.0f,  // 0 - 100
		string LABEL_ID = null
	) => new() {
		Reward = new GcRewardSpecificTechFromList {
			TechList            = LIST,
			FailIfAllKnown      = FAIL_IF_ALL_KNOWN,
			TechListRewardOrder = ORDER
		},
		PercentageChance = CHANCE,
		LabelID = LABEL_ID ?? ""
	};

	//...........................................................

	public static GcRewardTableItem ProceduralProduct(
			int QUALITY_OVERRRIDE,
			ProceduralProductCategoryEnum PRODUCT_CATEGORY,
			RarityEnum RARITY = RarityEnum.Common,
			bool OVERRIDE_RARITY = false,
			bool SUB_IF_PLAYER_ALREADY_HAS_ONE = false,
			string OSD_MESSAGE = null,
			float CHANCE = 100.0f,
			string LABEL_ID = null
		) => new() {
			Reward = new GcRewardProceduralProduct {
				OSDMessage = OSD_MESSAGE,
				FreighterTechQualityOverride = QUALITY_OVERRRIDE,
				Rarity = new() { Rarity = RARITY },
				Type   = new() { ProceduralProductCategory = PRODUCT_CATEGORY },
				OverrideRarity = OVERRIDE_RARITY,
				SubIfPlayerAlreadyHasOne = SUB_IF_PLAYER_ALREADY_HAS_ONE,
			},
			PercentageChance = CHANCE,
			LabelID = LABEL_ID ?? ""
		};

	//...........................................................

	public static GcRewardTableItem SpecificShip(
		string NAMEOVERRIDE,
		ShipClassEnum TYPE,
		InventoryClassEnum CLASS,
		string FILENAME,
		long SEED,
		bool SEED_USED = true,
		int SLOTS = 48,
		List<GcInventoryElement> INVENTORY = null,
		List<GcInventoryBaseStatEntry> STATS = null
	) => new() {
		Reward = new GcRewardSpecificShip {
			ShipResource = new() {
				Filename = FILENAME,
				Seed     = new() { Seed = SEED, UseSeedValue = SEED_USED }
			},
			ShipInventory = new() {
				Slots          = INVENTORY,
				Class          = new() { InventoryClass = CLASS },
				BaseStatValues = STATS
			},
			NameOverride = NAMEOVERRIDE,
			ShipLayout   = new() { Slots = SLOTS, Seed = new() { Seed = 1, UseSeedValue = true }, Level = 1 },
			ShipType     = new() { ShipClass = TYPE },
			IsGift       = true,
			IsRewardShip = true
		},
		PercentageChance = 100.0f,
	};

	//...........................................................

	public static GcRewardTableItem SpecificFrigate(
		string NAMEOVERRIDE,
		FrigateClassEnum TYPE,
		ulong FRIGATE_SEED = 1,
		ulong SYSTEM_SEED = 0,
		AlienRaceEnum RACE = AlienRaceEnum.None,
		string PRIMARY_TRAIT = null
	) => new() {
		Reward = new GcRewardSpecificFrigate {
			FrigateClass = new() { FrigateClass = TYPE },
			FrigateSeed  = FRIGATE_SEED,
			SystemSeed   = SYSTEM_SEED,
			AlienRace    = new() { AlienRace = RACE },
			NameOverride = NAMEOVERRIDE,
			IsGift           = true,
			IsRewardFrigate  = true,
			FormatAsSeasonal = false,
			UseSeedFromCommunicator = true,
			PrimaryTrait = PRIMARY_TRAIT
		},
		PercentageChance = 100.0f,
	};

	//...........................................................

	public static GcRewardTableItem EndFrigateFlyby(
	) => new() {
		Reward = new GcRewardEndFrigateFlyby(),
		PercentageChance = 100.0f,
	};

	//...........................................................

	// todo: GcRewardSubstance, GcRewardProduct, GcRewardSystemSpecificProductFromList, ...
}

//=============================================================================
