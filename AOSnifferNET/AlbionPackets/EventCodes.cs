﻿namespace AOSnifferNET
{
    public enum EventCodes
    {
        Unused = 0,
        Leave, // [{"Key":0,"Value":1515905},{"Key":252,"Value":1}]
        JoinFinished,
        Move,
        Teleport,
        ChangeEquipment,
        HealthUpdate, // mi id: "characterId":166380,"markId":"d5BAcx01AkmtmRylW1C1Zg==" PACKETE: {"0: targetEntityId":166414,"1":14992275,"2: healthUpdate":-10.0,"3: targetEntityCurrentHealth":591.0,"4":1,"5":5,"6: attackerEntityId":166380,"7":1757,"252":6}
        EnergyUpdate,
        DamageShieldUpdate,
        CraftingFocusUpdate,
        ActiveSpellEffectsUpdate,
        ResetCooldowns,
        Attack,
        CastStart,
        ChannelingUpdate,
        CastCancel,
        CastTimeUpdate,
        CastFinished,
        CastSpell,
        CastHit,
        CastHits,
        ChannelingEnded,
        AttackBuilding,
        InventoryPutItem = 25, //  map[0:652 1:6 2:[118 -97 114 112 -46 84 -60 75 -103 -93 -3 -29 118 -125 -50 96] 3:17 252:23] (0: ObjectId, 2: UserId)
        InventoryDeleteItem, // map[0:754 1:48 252:24] (0: ObjectId) 
        NewCharacter = 27,
        NewEquipmentItem, //  map[0:657 1:2036 2:1 4:28169331 5:Apolo540 6:3 7:90000000 8:[] 9:[0] 252:27] (0: ObjectId, 1: ItemId, 2: Amount, 4: Avarage Market Price, 5: CrafterName)
        NewSimpleItem, //  map[0:505 1:7006 2:1 3:true 4:29033970 252:27] (0: ObjectId, 1: ItemId, 2: Amount)
        NewFurnitureItem,
        NewJournalItem,
        NewLaborerItem,
        NewSimpleHarvestableObject,
        NewSimpleHarvestableObjectList = 35,
        NewHarvestableObject = 36,
        NewSilverObject,
        NewBuilding = 41,
        HarvestableChangeState = 42,
        MobChangeState,
        FactionBuildingInfo,
        CraftBuildingInfo,
        RepairBuildingInfo,
        MeldBuildingInfo,
        ConstructionSiteInfo,
        PlayerBuildingInfo,
        FarmBuildingInfo,
        TutorialBuildingInfo,
        LaborerObjectInfo,
        LaborerObjectJobInfo,
        MarketPlaceBuildingInfo,
        HarvestStart = 55,
        HarvestCancel = 56,
        HarvestFinished = 57,
        TakeSilver,
        ActionOnBuildingStart,
        ActionOnBuildingCancel,
        ActionOnBuildingFinished,
        ItemRerollQualityStart,
        ItemRerollQualityCancel,
        ItemRerollQualityFinished,
        InstallResourceStart,
        InstallResourceCancel,
        InstallResourceFinished,
        CraftItemFinished,
        LogoutCancel,
        ChatMessage,
        ChatSay,
        ChatWhisper,
        ChatMuted,
        PlayEmote,
        StopEmote,
        SystemMessage,
        UtilityTextMessage = 75,
        UpdateSilver = 76, // map[0:4195 1:884995625105 252:71] (0: ObjectId, 1: CurrentSilver)
        UpdateFame, // map[0:4195 1:5811910006347 2:100000000 4:10000 6:1 7:427 252:72] (0: ObjectId, 1: TotalPlayerFame, 2: fameWithZoneMultiplier, 3: GroupSize, 4: Multiplier, 5: IsPremiumBonus, 6: BonusFactor, 7: ItemId, 9: SatchelFame, )
        UpdateLearningPoints,
        UpdateReSpecPoints,
        UpdateCurrency,
        UpdateFactionStanding,
        Respawn,
        ServerDebugLog,
        CharacterEquipmentChanged = 85,
        RegenerationHealthChanged,
        RegenerationEnergyChanged,
        RegenerationMountHealthChanged,
        RegenerationCraftingChanged,
        RegenerationHealthEnergyComboChanged,
        RegenerationPlayerComboChanged,
        DurabilityChanged,
        NewLoot = 93, // {"0":443987,"1":753,"2":443320,"3":"@MOB_UNDEAD_GHOUL_STANDARD","4":[190.0,293.5],"5":298.889069,"7":2,"10":["Uv++ltnQS0m8aD1+rF1tzw=="],"12":638028508050864513,"14":true,"15":1.25,"18":[],"22":0,"23":0,"24":-1,"252":89} 4: pos 10: markid del dueño?
        AttachItemContainer = 94, //  {"0":150286,"1":"8WUpR31OzEqiKE2bPQ6HWg==","3":[150287],"4":1,"252":90} 0: ObjectID 1: OwnerMark 3. Items ID List
        DetachItemContainer, //  map[0:[-95 72 -77 -75 -70 34 127 73 -114 -96 28 8 75 -107 -106 125] 252:90]
        InvalidateItemContainer,
        LockItemContainer,
        GuildUpdate,
        GuildPlayerUpdated,
        InvitedToGuild,
        GuildMemberWorldUpdate,
        UpdateMatchDetails,
        ObjectEvent,
        NewMonolithObject,
        NewSiegeCampObject,
        NewOrbObject,
        NewCastleObject,
        NewSpellEffectArea,
        UpdateSpellEffectArea,
        NewChainSpell,
        UpdateChainSpell,
        NewTreasureChest,
        StartMatch,
        StartTerritoryMatchInfos,
        StartArenaMatchInfos,
        EndTerritoryMatch,
        EndArenaMatch = 109,
        MatchUpdate,
        ActiveMatchUpdate = 112,
        NewMob = 117,
        DebugAggroInfo,
        DebugVariablesInfo,
        DebugReputationInfo,
        DebugDiminishingReturnInfo,
        DebugSmartClusterQueueInfo,
        ClaimOrbStart,
        ClaimOrbFinished,
        ClaimOrbCancel,
        OrbUpdate,
        OrbClaimed,
        NewWarCampObject,
        NewMatchLootChestObject,
        NewArenaExit,
        GuildMemberTerritoryUpdate,
        InvitedMercenaryToMatch,
        ClusterInfoUpdate,
        ForcedMovement,
        ForcedMovementCancel,
        CharacterStats,
        CharacterStatsKillHistory,
        CharacterStatsDeathHistory,
        GuildStats,
        KillHistoryDetails,
        FullAchievementInfo,
        FinishedAchievement,
        AchievementProgressInfo,
        FullAchievementProgressInfo,
        FullTrackedAchievementInfo,
        FullAutoLearnAchievementInfo,
        QuestGiverQuestOffered,
        QuestGiverDebugInfo,
        ConsoleEvent,
        TimeSync,
        ChangeAvatar,
        ChangeMountSkin,
        GameEvent,
        KilledPlayer,
        Died,
        KnockedDown,
        MatchPlayerJoinedEvent,
        MatchPlayerStatsEvent,
        MatchPlayerStatsCompleteEvent,
        MatchTimeLineEventEvent,
        MatchPlayerMainGearStatsEvent,
        MatchPlayerChangedAvatarEvent,
        InvitationPlayerTrade,
        PlayerTradeStart,
        PlayerTradeCancel,
        PlayerTradeUpdate,
        PlayerTradeFinished,
        PlayerTradeAcceptChange,
        MiniMapPing,
        MarketPlaceNotification,
        DuellingChallengePlayer,
        NewDuellingPost,
        DuelStarted,
        DuelEnded,
        DuelDenied,
        DuelLeftArea,
        DuelReEnteredArea,
        NewRealEstate,
        MiniMapOwnedBuildingsPositions,
        RealEstateListUpdate,
        GuildLogoUpdate,
        GuildLogoChanged,
        PlaceableObjectPlace,
        PlaceableObjectPlaceCancel,
        FurnitureObjectBuffProviderInfo,
        FurnitureObjectCheatProviderInfo,
        FarmableObjectInfo,
        NewUnreadMails,
        Unknown187,
        GuildLogoObjectUpdate,
        StartLogout,
        NewChatChannels,
        JoinedChatChannel,
        LeftChatChannel,
        RemovedChatChannel,
        AccessStatus,
        Mounted = 200, // When me or other player gets mounted
        MountStart,
        MountCancel,
        NewTravelpoint,
        NewIslandAccessPoint,
        NewExit,
        UpdateHome,
        UpdateChatSettings,
        ResurrectionOffer,
        ResurrectionReply,
        LootEquipmentChanged,
        UpdateUnlockedGuildLogos,
        UpdateUnlockedAvatars,
        UpdateUnlockedAvatarRings,
        UpdateUnlockedBuildings,
        NewIslandManagement,
        NewTeleportStone,
        Cloak,
        PartyInvitation,
        PartyJoined,
        PartyChangedOrder, // map[0:14368 2:1 3:[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] 4:[[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] [-118 61 -70 72 17 -107 121 72 -102 110 20 -25 64 20 106 2]] 5:[Triky313 Bruno313] 6:[0 0] 7:[18 0] 8:[35 0] 9:[-1 -1] 10:[true true] 252:212]
        PartyPlayerLeft, // map[1:14184 252:213]
        PartyPlayerJoined, // map[0:11925 1:[-63 -19 39 16 26 35 -25 67 -111 60 -87 -58 -31 -100 -124 -44] 2:Mitch77 3:1 4:20 5:12 6:-1 7:true 252:214]
        PartyDisbanded, // map[0:14368 1:[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] 252:216]
        PartyLeaderChanged, // map[0:14595 1:[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] 252:217]
        PartyLootSettingChangedPlayer, // map[0:14368 1:1 252:218]
        PartySilverGained,
        PartyPlayerUpdated, // map[0:Bruno313 1:true 3:5 252:221]
        PartyInvitationPlayerBusy,
        PartyMarkedObjectsUpdated,
        PartyOnClusterPartyJoined,
        PartySetRoleFlag, // map[0:8 1:[-118 61 -70 72 17 -107 121 72 -102 110 20 -25 64 20 106 2] 252:225] (0: FlagType, 1: ObjectId)
        SpellCooldownUpdate,
        NewHellgate,
        NewHellgateExit,
        NewExpeditionExit,
        NewExpeditionNarrator,
        ExitEnterStart,
        ExitEnterCancel,
        ExitEnterFinished,
        HellClusterTimeUpdate,
        NewQuestGiverObject,
        FullQuestInfo,
        QuestProgressInfo,
        QuestGiverInfoForPlayer,
        FullExpeditionInfo,
        ExpeditionQuestProgressInfo,
        InvitedToExpedition,
        ExpeditionRegistrationInfo,
        EnteringExpeditionStart,
        EnteringExpeditionCancel,
        RewardGranted,
        ArenaRegistrationInfo,
        EnteringArenaStart,
        EnteringArenaCancel,
        EnteringArenaLockStart,
        EnteringArenaLockCancel,
        InvitedToArenaMatch,
        PlayerCounts,
        Unknown254,
        Unknown255,
        GrabbedLoot, // LOOT: map[0:424 1:Triky313 2:Bruno313 4:1841 5:1 252:256] | SILVER: map[0:6436 2:Triky313 3:true 5:1550115 252:256] (0: ObjectId, 1: LootedBody, 2: Looter, 4: ItemId, 5: Quantity) 
        PlayersInRegionUpdate,
        InCombatStateUpdate = 263, // <- 1 = true; player hits enemy | 2 = true; enemy hits player
        OtherGrabbedLoot,
        SiegeCampClaimStart,
        SiegeCampClaimCancel,
        SiegeCampClaimFinished,
        SiegeCampScheduleResult,
        TreasureChestUsingStart,
        TreasureChestUsingFinished,
        TreasureChestUsingCancel,
        TreasureChestUsingOpeningComplete,
        TreasureChestForceCloseInventory,
        PremiumChanged,
        PremiumExtended,
        PremiumLifeTimeRewardGained,
        LaborerGotUpgraded,
        JournalGotFull,
        JournalFillError,
        FriendRequest,
        FriendRequestInfos,
        FriendInfos,
        FriendRequestAnswered,
        FriendOnlineStatus,
        FriendRequestCanceled,
        FriendRemoved,
        FriendUpdated,
        PartyLootItems,
        PartyLootItemsRemoved,
        ReputationUpdate,
        DefenseUnitAttackBegin,
        DefenseUnitAttackEnd,
        DefenseUnitAttackDamage,
        UnrestrictedPvpZoneUpdate = 999999,
        ReputationImplicationUpdate,
        NewMountObject = 295,
        MountHealthUpdate,
        MountCooldownUpdate,
        NewExpeditionAgent,
        NewExpeditionCheckPoint,
        ExpeditionStartent,
        Voteent,
        Ratingent,
        NewArenaAgent,
        BoostFarmable,
        UseFunction,
        NewPortalEntrance,
        NewPortalExit,
        NewRandomDungeonExit = 308,
        WaitingQueueUpdate,
        PlayerMovementRateUpdate,
        ObserveStart,
        MinimapZergs,
        MinimapSmartClusterZergs,
        PaymentTransactions,
        PerformanceStatsUpdate,
        OverloadModeUpdate,
        DebugDrawEvent,
        RecordCameraMove,
        RecordStart,
        TerritoryClaimStart,
        TerritoryClaimCancel,
        TerritoryClaimFinished,
        TerritoryScheduleResult,
        UpdateAccountState,
        StartDeterministicRoam,
        GuildFullAccessTagsUpdated,
        GuildAccessTagUpdated,
        GvgSeasonUpdate,
        GvgSeasonCheatCommand,
        SeasonPointsByKillingBooster,
        FishingStart,
        FishingCast,
        FishingCatch,
        FishingFinished,
        FishingCancel,
        NewFloatObject = 343,
        NewFishingZoneObject,
        FishingMiniGame,
        SteamAchievementCompleted,
        UpdatePuppet,
        ChangeFlaggingFinished,
        NewOutpostObject,
        OutpostUpdate,
        OutpostClaimed,
        OutpostReward,
        OverChargeEnd,
        OverChargeStatus,
        PartyFinderFullUpdate,
        PartyFinderUpdate,
        PartyFinderApplicantsUpdate,
        PartyFinderEquipmentSnapshot,
        PartyFinderJoinRequestDeclined,
        NewUnlockedPersonalSeasonRewards,
        PersonalSeasonPointsGained,
        ChallengePoints = 352, // map[0:1578596 252:352]
        EasyAntiCheatMessageToClient,
        MatchLootChestOpeningStart,
        MatchLootChestOpeningFinished,
        MatchLootChestOpeningCancel,
        NotifyCrystalMatchReward,
        CrystalRealmFeedback,
        NewLocationMarker,
        NewTutorialBlocker,
        NewTileSwitch,
        NewInformationProvider,
        NewDynamicGuildLogo,
        TutorialUpdate,
        TriggerHintBox,
        RandomDungeonPositionInfo,
        NewLootChest = 368, // map[0:23 1:[20.5 177.5] 2:423 3:KEEPER_SOLO_BOOKCHEST_STANDARD 4:FOREST_GREEN_LOOTCHEST_KEEPER_SOLO_BOOKCHEST_STANDARD 5:4 6:637734315213820408 7:[] 8:[] 13:true 252:367]
        UpdateLootChest = 369, // map[0:23 1:4 2:637734315213820408 3:[] 4:[] 9:true 252:368]
        LootChestOpened = 370, // map[0:23 252:369]
        NewShrine = 372, // map[0:19 1:[-89 90] 2:180 3:GENERAL_SHRINE_COMBAT_BUFF 4:SHRINE_NON_COMBAT_BUFF 5:1 6:637734312344532502 252:371]
        UpdateShrine = 373, // map[0:19 1:2 2:637734313445294913 252:372]
        MutePlayerUpdate,
        ShopTileUpdate,
        ShopUpdate,
        EasyAntiCheatKick,
        UnlockVanityUnlock,
        AvatarUnlocked,
        CustomizationChanged,
        GuildVaultInfo = 385,
        BaseVaultInfo = 386,
        BankVaultInfo,
        RecoveryVaultPlayerInfo,
        RecoveryVaultGuildInfo,
        UpdateWardrobe,
        CastlePhaseChanged,
        GuildAccountLogEvent,
        NewHideoutObject,
        NewHideoutManagement,
        NewHideoutExit,
        InitHideoutAttackStart,
        InitHideoutAttackCancel,
        InitHideoutAttackFinished,
        HideoutManagementUpdate,
        IpChanged,
        SmartClusterQueueUpdateInfo,
        SmartClusterQueueActiveInfo,
        SmartClusterQueueKickWarning,
        SmartClusterQueueInvite,
        ReceivedSeasonPoints = 399,
        TerritoryBonusLevelUpdate,
        OpenWorldAttackScheduleStart,
        OpenWorldAttackScheduleFinished,
        OpenWorldAttackScheduleCancel,
        OpenWorldAttackConquerStart,
        OpenWorldAttackConquerFinished,
        OpenWorldAttackConquerCancel,
        OpenWorldAttackConquerStatus,
        OpenWorldAttackStart,
        OpenWorldAttackEnd,
        NewRandomResourceBlocker,
        NewHomeObject,
        HideoutObjectUpdate,
        UpdateInfamy,
        Unknown408,
        Unknown409,
        Unknown410,
        Unknown411,
        NewTunnel = 418,
        Unknown413,
        Unknown414,
        Unknown415,
        Unknown416,
        NewMobList = 423,
        Unknown418,
        Unknown419,
        Unknown420,
        Unknown421,
        Unknown422,
        MightFavorPoints = 471 // map[0:63063 2:21021 3:16617 5:5539 6:349680 8:0 252:470] (0: Might, 2: Premium of might, 3: Favor, 5: Premium of favor, 6: Total favor, 8: ???) 
    }
}
