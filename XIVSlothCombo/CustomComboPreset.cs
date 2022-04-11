using XIVSlothComboPlugin.Attributes;
using XIVSlothComboPlugin.Combos;

namespace XIVSlothComboPlugin
{
    /// <summary>
    /// Combo presets.
    /// </summary>
    public enum CustomComboPreset
    {
        // ====================================================================================
        #region Misc

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", ADV.JobID)]
        AdvAny = 0,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", AST.JobID)]
        AstAny = AdvAny + AST.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BLM.JobID)]
        BlmAny = AdvAny + BLM.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BRD.JobID)]
        BrdAny = AdvAny + BRD.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DNC.JobID)]
        DncAny = AdvAny + DNC.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOH.JobID)]
        DohAny = AdvAny + DOH.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOL.JobID)]
        DolAny = AdvAny + DOL.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRG.JobID)]
        DrgAny = AdvAny + DRG.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRK.JobID)]
        DrkAny = AdvAny + DRK.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", GNB.JobID)]
        GnbAny = AdvAny + GNB.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MCH.JobID)]
        MchAny = AdvAny + MCH.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MNK.JobID)]
        MnkAny = AdvAny + MNK.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", NIN.JobID)]
        NinAny = AdvAny + NIN.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", PLD.JobID)]
        PldAny = AdvAny + PLD.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RDM.JobID)]
        RdmAny = AdvAny + RDM.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RPR.JobID)]
        RprAny = AdvAny + RPR.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SAM.JobID)]
        SamAny = AdvAny + SAM.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SCH.JobID)]
        SchAny = AdvAny + SCH.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SGE.JobID)]
        SgeAny = AdvAny + SGE.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SMN.JobID)]
        SmnAny = AdvAny + SMN.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WAR.JobID)]
        WarAny = AdvAny + WAR.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WHM.JobID)]
        WhmAny = AdvAny + WHM.JobID,

        [CustomComboInfo("Disabled", "This should not be used.", ADV.JobID)]
        Disabled = 99999,

        #endregion
        // ====================================================================================
        #region ADV
        #endregion
        /*
        #region GLOBAL FEATURES
        [CustomComboInfo("Global Interrupt Feature", "Replaces Stun (LowBlow) with interrupt (Interject) when the target can be interrupted.", All.JobID)]
        InterruptFeature = 90000,

        [ConflictingCombos(SchRaiseFeature, WHMRaiseFeature, AstrologianAscendFeature, SageEgeiroFeature)]
        [CustomComboInfo("Global 复活 Feature", "Replaces Swiftcast with 复活/Resurrection/Verraise/Ascend/Egeiro when appropriate.", All.JobID)]
        DoMSwiftcastFeature = 90001,

        #endregion
        */
        // ====================================================================================
        #region ASTROLOGIAN

        [CustomComboInfo("抽卡 on Play", "Play turns into 抽卡 when no card is drawn, as well as the usual 出卡 behavior.", AST.JobID, 0, "Pot of Greed", "抽卡 some cards, or something. Idk, you're the one that chose to play AST.")]
        AstrologianCardsOnDrawFeaturelikewhat = 1000,

        [CustomComboInfo("Crown Play to 小奥秘卡", "Changes Crown Play to 小奥秘卡 when a card is not drawn or has Lord Or Lady Buff.", AST.JobID, 0, "Bestow Royalty", "This one's for the Lords and Ladies, lemme get a HYEEEAAAAAH!")]
        AstrologianCrownPlayFeature = 1001,

        [CustomComboInfo("吉星 2 to 吉星 Level Sync", "Changes 吉星 2 to 吉星 when below level 26 in synced content.", AST.JobID, 0, "Sprout's Benedict Cumberbatch", "Changes Big Benedict into Little Benedict when you visit the sprout universe.")]
        AstrologianBeneficFeature = 1002,

        [ConflictingCombos(AstrologianAlternateAscendFeature)]
        [CustomComboInfo("AST 复活 Feature", "Changes Swiftcast to 生辰", AST.JobID, 0, "Rez-bot-3000", "Does your job for you, but faster. You're welcome, little sloth.")]
        AstrologianAscendFeature = 1003,

        [ConflictingCombos(AstrologianAscendFeature)]
        [CustomComboInfo("AST 复活 Alternate Feature", "Changes 复生 To Swiftcast when Swiftcast is available", AST.JobID, 0, "Rez-bot-0003", "Same same, but different!")]
        AstrologianAlternateAscendFeature = 1019,

        [ConflictingCombos(AstrologianAlternateDpsFeature, CustomValuesTest)]
        [CustomComboInfo("DPS Feature(On 凶星)", "Adds 烧灼 to the main malefic combo whenever the debuff is not present or about to expire", AST.JobID, 0, "Green DPS? Look no further", "Adds fatter deeps to your combo. Just pick another job already...")]
        AstrologianDpsFeature = 1004,

        [ParentCombo(AstrologianDpsFeature)]
        [CustomComboInfo("Lucid Dreaming Feature", "Adds Lucid dreaming to the DPS feature when below set MP value.", AST.JobID, 0, "Lucid SCREAMING Feature", "I heard once you could control your dreams... But then I woke up.")]
        AstrologianLucidFeature = 1008,

        [CustomComboInfo("星力 Feature", "Adds 星力 to the DPS feature when ready", AST.JobID, 0, "Astro-whine Feature", "Astro-whining again? Sorry, everyone's busy looking at the SGE's cool floating sticks.")]
        AstrologianAstrodyneFeature = 1009,

        [CustomComboInfo("Aspected 阳星 Feature", "Replaces Aspected 阳星 whenever you are under Aspected 阳星 regen with 阳星", AST.JobID, 0, "HELIOSCOPTER", "HELIOSCOPTER HELIOSCOPTER")]
        AstrologianHeliosFeature = 1010,

        [CustomComboInfo("Auto Card 抽卡", "Adds Auto Card 抽卡 Onto Main DPS Feature", AST.JobID, 0, "Kaiba Feature", "You just activated my trap card!")]
        AstrologianAutoDrawFeature = 1011,

        [CustomComboInfo("Auto Crown Card 抽卡", "Adds Auto Crown Card 抽卡 Onto Main DPS Feature ", AST.JobID, 0, "Kaiba 2, Electric Boogaloo", "It's a trap!")]
        AstrologianAutoCrownDrawFeature = 1012,

        [CustomComboInfo("AoE DPS Feature", "Adds Auto抽卡s/Astrodyne to the AoE Gravity combo", AST.JobID, 0, "A bowlful of cards", "Oops! All AoE!")]
        AstrologianDpsAoEFeature = 1013,

        [CustomComboInfo("Lazy Lord Feature", "Adds Lord Of Crowns Onto Main DPS/AoE Feature", AST.JobID, 0, "Brainless Lord Feature", "You're like that tiny guy from Shrek. - E -")]
        AstrologianLazyLordFeature = 1014,

        [CustomComboInfo("Astrodyne on 出卡", "出卡 becomes Astrodyne when you have 3 seals.", AST.JobID, 0, "Astro-whine on 出卡", "Seal me up and let me die, baby")]
        AstrologianAstrodyneOnPlayFeature = 1015,

        [ConflictingCombos(AstrologianDpsFeature, CustomValuesTest)]
        [CustomComboInfo("Alternate DPS Feature (On 烧灼)", "Adds 烧灼 to the main malefic combo whenever the debuff is not present or about to expire", AST.JobID, 0, "Alternate Deeps, buddy", "Now we're really doing your job for you. Damn.")]
        AstrologianAlternateDpsFeature = 1016,

        [ConflictingCombos(AstrologianDpsFeature, AstrologianAlternateDpsFeature, DisableCombustOnDpsFeature)]
        [CustomComboInfo("DPS Feature Custom Values Testing", "Same as DPSFeature (On 凶星).Allows you to customize target MaxHp & CurrentPercentageHp & CurrentHp checks. Testing Only! ", AST.JobID, 0, "Green DPS? But you looked further...", "Same as that other guy, but with NUMBERS.")]
        CustomValuesTest = 1017,

        [ParentCombo(AstrologianDpsFeature)]
        [ConflictingCombos(AstrologianAlternateDpsFeature)]
        [CustomComboInfo("Removes DoT From DPS Feature", "Removed DoT From the DPS Feature, You can still use all other features that are on malefic! ", AST.JobID, 0, "DPS Less", "Oh, look, guys! Look! This one's actually healing!")]
        DisableCombustOnDpsFeature = 1018,

        [CustomComboInfo("光速 Feature", "Adds 光速 to the DPS Feature", AST.JobID, 0, "Warp-speed", "GO FASTER! FASTER!")]
        AstrologianLightSpeedFeature = 1020,

        [ParentCombo(AstrologianHeliosFeature)]
        [CustomComboInfo("天星冲日 Feature", "Adds 天星冲日", AST.JobID, 0)]
        AstrologianCelestialOppositionFeature = 1021,

        [ParentCombo(AstrologianHeliosFeature)]
        [CustomComboInfo("Lazy Lady Feature", "Adds 王冠之贵妇, if the card is drawn", AST.JobID, 0)]
        AstrologianLazyLadyFeature = 1022,

        [CustomComboInfo("Simple Heal", "Single target healing", AST.JobID, 0)]
        AstrologianSimpleSingleTargetHeal = 1023,

        [ParentCombo(AstrologianSimpleSingleTargetHeal)]
        [CustomComboInfo("先天禀赋 Feature", "先天禀赋 will be added when the target is at or below the value set", AST.JobID, 0)]
        AstroEssentialDignity = 1024,

        [ParentCombo(AstrologianSimpleSingleTargetHeal)]
        [CustomComboInfo("天星交错 Feature", "Adds 天星交错.", AST.JobID, 0)]
        CelestialIntersectionFeature = 1025,

        [ParentCombo(AstrologianHeliosFeature)]
        [CustomComboInfo("天宫图 Feature", "Adds 天宫图.", AST.JobID, 0)]
        AstrologianHoroscopeFeature = 1026,
        
        [ParentCombo(AstrologianSimpleSingleTargetHeal)]
        [CustomComboInfo("Aspected 吉星 Feature", "Adds Aspected 吉星 & refreshes it if needed.", AST.JobID, 0)]
        AspectedBeneficFeature = 1027,

        [ParentCombo(AstrologianSimpleSingleTargetHeal)]
        [CustomComboInfo("擢升 Feature", "Adds 擢升.", AST.JobID, 0)]
        ExaltationFeature = 1028,


        #endregion
        // ====================================================================================
        #region BLACK MAGE

        [ConflictingCombos(BlackSimpleFeature)]
        [CustomComboInfo("天语 Stance Switcher ++", "Change Scathe to 火炎 4 or Blizzard 4 depending on stance.\nScathe becomes all in one rotation.\nIf Thunder Feature is turned on it also adds Thunder3 proces onto all in one combo when DoT is about to expire or dosen't exist\nThis REQUIRES other features to be turned on!!!", BLM.JobID, 0, "BrainLess Mage", "One button, BAYBEE!")]
        BlackEnochianFeature = 2000,

        [CustomComboInfo("Umbral Soul/星灵移位 Switcher", "Change 星灵移位 into Umbral Soul when Umbral Soul is usable.", BLM.JobID, 0, "Eh? Huh?", "Just does BLM things. Probably.")]
        BlackManaFeature = 2001,

        [CustomComboInfo("(Between the) 黑魔纹", "Change 黑魔纹 into BTL when 黑魔纹 is active.", BLM.JobID, 0, "BLT Sandwich feature", "Look between, and you shall find")]
        BlackLeyLinesFeature = 2002,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("冰结 1/2/3 Feature", "冰结 1 becomes 冰结 3 when out of Umbral Ice. Freeze becomes 冰结 2 when synced.", BLM.JobID, 0, "地之印lly boi", "地之印ll out, for real. It's sleepy sloth time")]
        BlackBlizzardFeature = 2003,

        [ConflictingCombos(BlackEnochianFeature, BlackSimpleFeature)]
        [CustomComboInfo("崩溃/Xenoglossy Feature", "崩溃 becomes Xenoglossy when available.", BLM.JobID, 0, "Glossy paint", "So shiny, so glossy...")]
        BlackScatheFeature = 2004,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("火炎 1/3", "火炎 1 becomes 火炎 3 outside of Astral 火炎, OR when 火炎starter proc is up.", BLM.JobID, 0, "Burna boi", "It's getting hot in here...")]
        BlackFire13Feature = 2005,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("闪雷", "Thunder 1/3 replaces Enochian/火炎 4/Blizzard 4 on Enochian switcher.\n Occurs when Thundercloud is up and either\n- Thundercloud buff on you is about to run out, or\n- 闪雷 debuff on your CURRENT target is about to run out\nAssuming it won't interrupt timer upkeep.\nEnochian Stance Switcher must be active.", BLM.JobID, 0, "Plug Socket Mode", "Forks at the ready!")]
        BlackThunderFeature = 2006,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("绝望 Feature", "Despair replaces 火炎 4 when below 2400 MP.\nEnochian Stance Switcher must be active.", BLM.JobID, 0, "My MP!", "The horror! The despair!")]
        BlackDespairFeature = 2007,

        [CustomComboInfo("AoE Combo Feature", "One Button AoE Feature that adds whole AoE rotation onto FLARE (TESTING ONLY!!!)", BLM.JobID, 0, "Dungeon Tesla Mode", "Asleep at the wheel? We've got you!")]
        BlackAoEComboFeature = 2008,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("冰结 Paradox Feature", "Adds Paradox onto ice phase combo", BLM.JobID, 0, "The sentence below is false.", "The sentence above is true.")]
        BlackBlizzardParadoxFeature = 2009,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("Aspect Swap Feature", "Changes Scathe to Blizzard 3 when at 0 MP in Astral 火炎 or to 火炎 3 when at 10000 MP in Umbral Ice with 3 Umbral Hearts.", BLM.JobID, 0, "", "")]
        BlackAspectSwapFeature = 2010,

        [ParentCombo(BlackThunderFeature)]
        [CustomComboInfo("闪雷 Uptime Feature", "Changes Scathe to 闪雷 1/3 when not detected on target.", BLM.JobID, 0, "Bzzt", "Shocking!")]
        BlackThunderUptimeFeature = 2011,

        [ConflictingCombos(BlackEnochianFeature, BlackScatheFeature)]
        [CustomComboInfo("Simple BLM", "Adds the whole rotation to one button.", BLM.JobID, 0, "", "")]
        BlackSimpleFeature = 2012,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple Buffs Feature", "Adds 魔泉, 激情咏唱, 详述 onto the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimpleBuffsFeature = 2013,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple Buffs - 黑魔纹", "Adds 黑魔纹 onto the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimpleBuffsLeylinesFeature = 2014,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple 抛竿s Feature", "Adds 三连咏唱/Swiftcast onto the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimpleCastsFeature = 2015,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple 抛竿s - Pooling", "Keep one triplecast usage for movement in the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimpleCastPoolingFeature = 2016,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple Pooling", "Keep one xenoglossy usage for movement in the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimplePoolingFeature = 2017,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple 火炎3 Opener", "Adds the 火炎 III Opener to Simple BLM.", BLM.JobID, 0, "", "")]
        BlackSimpleOpenerFeature = 2018,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple 火炎3 Opener - 1 Triplecast", "Modifies the Simple 火炎3 Opener to only use 1 Triplecast.", BLM.JobID, 0, "", "")]
        BlackSimpleAltOpenerFeature = 2019,

        [ParentCombo(BlackAoEComboFeature)]
        [CustomComboInfo("Foul / 魔泉 to Flare Option", "Adds foul when available during Astral 火炎. Weaves manafont after foul for additional Flare", BLM.JobID, 0, "", "")]
        BlackAoEFoulOption = 2020,

        #endregion
        // ====================================================================================
        #region BLUE MAGE

        [CustomComboInfo("Buffed 苦闷之歌", "Turns 苦闷之歌 into Bristle so SoT is buffed. \nSpells Required: 苦闷之歌.", BLU.JobID)]
        BluBuffedSoT = 70000,

        [CustomComboInfo("月之笛 Opener", "Puts the Full 月之笛 Opener on 月之笛 or Whistle. \nSpells Required: Whistle, 哔哩哔哩, 月之笛, 正义飞踢, 渔叉三段, 月下彼岸花, Rose of Destruction, 飞翎雨, 怒发冲冠, 冰雪乱舞, 穿甲散弹, 马特拉魔术, 轰雷, 鬼宿脚.", BLU.JobID)]
        BluOpener = 70001,

        [CustomComboInfo("终极针 Combo", "Turns 终极针 into the buff combo of: Moon Flute, 哔哩哔哩, 口笛, 终极针. Will use any primals off CD before casting 终极针. \nSpells Required: Moon Flute, 哔哩哔哩, 口笛, 终极针", BLU.JobID)]
        BluFinalSting = 70002,

        [ParentCombo(BluFinalSting)]
        [CustomComboInfo("Off CD Primal Additions", "Adds any Primals that are off CD to the 终极针 Combo. \nPrimals Used: Feather Rain, 轰雷, 冰雪乱舞, 正义飞踢, Rose of Destruction. ", BLU.JobID)]
        BluPrimals = 70003,

        [CustomComboInfo("Swiftcasted 天使低语", "Turns 天使低语 to Swiftcast when Swiftcast and 天使低语 are available. \nSpells required: 天使低语 ", BLU.JobID)]
        BluRez = 70004,

        [CustomComboInfo("Ram's Voice into 超振动", "Turns Ultravibration into Ram's Voice if Deep 玄冰 isn't on the target. Will swiftcast Ultravibration if available. \nSpells Required: Ram's Voice, 超振动. ", BLU.JobID)]
        BluUltravibrate = 70005,

        [CustomComboInfo("Tank Debuff Feature", "Puts 捕食, Off-Guard, Lucid Dreaming, and 臭气 into one button when under Tank Mimicry. \nSpells Required: Devour, Off-Guard, 臭气.", BLU.JobID)]
        BluDebuffCombo = 70006,

        [CustomComboInfo("Addle/魔法锤 Debuff Feature", "Turns 魔法锤 into Addle when off CD. \nSpells Required: 魔法锤.", BLU.JobID)]
        BluAddleFeature = 70007,

        [CustomComboInfo("Primal Feature", "Turns 飞翎雨 into any Primals that are off CD. \nSpells Required: 飞翎雨, 轰雷, 斗灵弹, 冰雪乱舞, J Kick. \nWill cause primals to desync from 月之笛 burst phases if used on CD.", BLU.JobID)]
        BluPrimalFeature = 70008,

        [CustomComboInfo("Knight's Tour Feature", "Turns Black Knight's Tour or 白骑士之旅 into its counterpart when the enemy is under the effect of the spell's debuff. \nSpells Required: 白骑士之旅, 黑骑士之旅", BLU.JobID)]
        BluKnightFeature = 70009,

        [CustomComboInfo("Peripheral Synthesis into 芥末爆弹", "Turns Peripheral Synthesis into 芥末爆弹 when target is under the effect of Lightheaded. \nSpells Required: Peripheral Synthesis, 芥末爆弹.", BLU.JobID)]
        BluLightheadedCombo = 70010,


        #endregion
        // ====================================================================================
        #region BARD

        [CustomComboInfo("Wanderer's into 完美音调", "Replaces Wanderer's Minuet with 完美音调 while in WM.", BRD.JobID, 0, "Braindead Minuet", "Songs for idiots")]
        BardWanderersPitchPerfectFeature = 3000,

        [ConflictingCombos(SimpleBardFeature)]
        [CustomComboInfo("强力射击 into Straight Shot", "Replaces 强力射击/Burst Shot with Straight Shot/Refulgent Arrow when procced.", BRD.JobID, 0, "This shot into that shot", "You're still using a bow? In this day and age?\nJust play MCH. They have guns, dude.")]
        BardStraightShotUpgradeFeature = 3001,

        [ConflictingCombos(SimpleBardFeature)]
        [ParentCombo(BardStraightShotUpgradeFeature)]
        [CustomComboInfo("DoT Maintenance Option", "Enabling this option will make 强力射击 into Straight Shot refresh your DoTs on your current.", BRD.JobID, 0, "Butter Maintenance Option", "Slathers butter on your target if butter is not present.")]
        BardDoTMaintain = 3002,

        [ConflictingCombos(BardIronJawsAlternateFeature)]
        [CustomComboInfo("伶牙俐齿 Feature", "伶牙俐齿 is replaced with Caustic Bite/Stormbite if one or both are not up.\nAlternates between the two if 伶牙俐齿 isn't available.", BRD.JobID, 0, "Jaws", "Wasn't this guy a James Bond villain in the '70s?")]
        BardIronJawsFeature = 3003,

        [ConflictingCombos(BardIronJawsFeature)]
        [CustomComboInfo("伶牙俐齿 Alternate Feature", "伶牙俐齿 is replaced with Caustic Bite/Stormbite if one or both are not up.\n伶牙俐齿 will only show up when debuffs are about to expire.", BRD.JobID, 0, "Mr. Larson", "Oh, and Happy Gilmore!!")]
        BardIronJawsAlternateFeature = 3004,

        [ConflictingCombos(SimpleBardFeature)]
        [CustomComboInfo("Burst Shot/连珠箭 into Apex Arrow", "Replaces Burst Shot and 连珠箭 with Apex Arrow when gauge is full and Blast Arrow when you are Blast Arrow ready.", BRD.JobID, 0, "Robin Hood Feature", "Steal from Lolorito and give to Garlemald, I guess?\nGood on ya.")]
        BardApexFeature = 3005,

        [ConflictingCombos(SimpleBardFeature, BardSimpleOpener)]
        [CustomComboInfo("Single Target oGCD Feature", "All oGCD's on 失血箭 (+ Songs rotation) depending on their CD.", BRD.JobID, 0, "oGCD's spilling everywhere", "The Algorithm between the lines. Trademark")]
        BardoGCDSingleTargetFeature = 3006,

        [ConflictingCombos(BardAoEComboFeature)]
        [CustomComboInfo("AoE oGCD Feature", "All AoE oGCD's on 死亡箭雨 depending on their CD.", BRD.JobID, 0, "", "Arrows! Everywhere! Run!")]
        BardoGCDAoEFeature = 3007,

        [ConflictingCombos(BardSimpleAoEFeature)]
        [CustomComboInfo("AoE Combo Feature", "Replaces 连珠箭/Ladonsbite with Shadowbite when ready", BRD.JobID, 0, "", "C-C-C-Combo!")]
        BardAoEComboFeature = 3008,

        [ConflictingCombos(BardStraightShotUpgradeFeature, BardDoTMaintain, BardApexFeature, BardoGCDSingleTargetFeature)]
        [CustomComboInfo("Simple Bard", "Adds every single target ability to one button,\nIf there are DoTs on target Simple Bard will try to maintain their uptime.", BRD.JobID, 0, "Sbimple Sbard", "Goodbye, brain. And then there's this feature, too!")]
        SimpleBardFeature = 3009,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Bard DoT Option", "This option will make Simple Bard apply DoTs if none are present on the target.", BRD.JobID, 0, "", "If you don't look at the DoTs, they don't exist.")]
        SimpleDoTOption = 3010,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Bard Song Option", "This option adds the bards songs to the Simple Bard feature.", BRD.JobID, 0, "Sing-song", "Look, a raid contribution feature!\nShame nobody will thank you for it")]
        SimpleSongOption = 3011,

        [ParentCombo(BardoGCDAoEFeature)]
        [CustomComboInfo("Song Feature", "Adds Songs onto AoE oGCD Feature.", BRD.JobID, 0, "", "Get your MIDI files ready, it's song time.")]
        BardSongsFeature = 3012,

        [CustomComboInfo("Bard Buffs Feature", "Adds 猛者强击 and Battle Voice onto Barrage.", BRD.JobID, 0, "", "Buff me up, Judy")]
        BardBuffsFeature = 3013,

        [CustomComboInfo("One Button Songs", "Add 贤者的叙事谣 and Army's Paeon to Wanderer's Minuet depending on cooldowns", BRD.JobID, 0, "EDM songs", "They all sound the same, anyway.")]
        BardOneButtonSongs = 3014,

        [CustomComboInfo("Simple AoE Bard", "Weaves oGCDs onto 连珠箭/Ladonsbite", BRD.JobID, 0, "", "Group attacks to make you feel like you're not the worst Ranged DPS in the room")]
        BardSimpleAoEFeature = 3015,

        [ParentCombo(BardSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE Bard Song Option", "Weave songs on the Simple AoE", BRD.JobID, 0, "", "Wow. You're performing to a crowd now, huh")]
        SimpleAoESongOption = 3016,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Buffs Feature", "Adds buffs onto the Simple Bard feature.", BRD.JobID, 0, "", "Buff for me, buff for you.")]
        BardSimpleBuffsFeature = 3017,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Buffs - Radiant", "Adds 光明神的最终乐章 to the Simple Buffs feature.", BRD.JobID, 0, "", "Nothing radiant about it, if you ask me.")]
        BardSimpleBuffsRadiantFeature = 3018,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Raid Mode", "Removes enemy health checking on mobs for buffs, dots and songs.", BRD.JobID, 0, "But Muh Parse", "Just slings all the shit, all the time!")]
        BardSimpleRaidMode = 3019,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Interrupt", "Uses interrupt during simple bard rotation if applicable", BRD.JobID, 0, "Simple Interr-", "Excuse me, I wa-")]
        BardSimpleInterrupt = 3020,

        [CustomComboInfo("Disable 绝峰箭", "Removes 绝峰箭 from Simple Bard and AoE Feature.", BRD.JobID, 0, "Disable Apex Legends", "Removing features? You? Surely not")]
        BardRemoveApexArrowFeature = 3021,

        [ConflictingCombos(BardoGCDSingleTargetFeature)]
        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Opener", "Adds the optimum opener to simple bard.\nThis conflicts with pretty much everything outside of simple bard options due to the nature of the opener.", BRD.JobID, 0, "Totally hands-off feature", "It's like watching a YouTube video!")]
        BardSimpleOpener = 3022,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Pooling", "Pools bloodletter chargers to allow for optimum burst phases", BRD.JobID, 0, "Dancer pooling feature", "NOW you're Dancing.")]
        BardSimplePooling = 3023,

        [ParentCombo(BardIronJawsFeature)]
        [CustomComboInfo("伶牙俐齿 Apex", "Adds Apex and Blast Arrow to 伶牙俐齿 when available", BRD.JobID, 0, "", "Arrows this, jaws that.\nTruly the apex of BRD technology")]
        BardIronJawsApexFeature = 3024,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple RagingJaws", "Enable the snapshotting of DoTs, within the remaining time of 猛者强击 below:", BRD.JobID, 0, "No thanks, DoTs", "Wish you'd had changes like SMN in Endwalker? Wish no more!")]
        BardSimpleRagingJaws = 3025,

        #endregion
        // ====================================================================================
        #region DANCER

        // Single Target Multibutton Section
        [ConflictingCombos(DancerSimpleFeature, DancerSimpleAoEFeature)]
        [CustomComboInfo("Single Target Multibutton", "Change 瀑泻 into procs and combos as available.", DNC.JobID, 0, "", "")]
        DancerSingleTargetMultibutton = 4000,

        [ParentCombo(DancerSingleTargetMultibutton)]
        [CustomComboInfo("ST Esprit Overcap Option", "Adds Saber Dance to the 瀑泻 combo if you are at 85 or more Esprit.", DNC.JobID, 0, "", "")]
        DancerEspritOvercapSTFeature = 4001,

        [ParentCombo(DancerEspritOvercapSTFeature)]
        [CustomComboInfo("ST Instant Saber Option", "Adds Saber Dance to the 瀑泻 combo if you have at least 50 Esprit.\nOverrides 'ST Esprit Overcap Option'.", DNC.JobID, 0, "", "")]
        DancerEspritOvercapSTInstantOption = 4002,

        [ParentCombo(DancerSingleTargetMultibutton)]
        [CustomComboInfo("扇舞·序 Overcap Protection", "Adds Fan Dance 1 onto 瀑泻 when Fourfold Feathers are full.", DNC.JobID, 0, "", "")]
        DancerFanDanceMainComboOvercapFeature = 4003,

        [ParentCombo(DancerSingleTargetMultibutton)]
        [CustomComboInfo("Fan Dance On 瀑泻 Feature", "Adds Fan Dance 3/4 onto 瀑泻 when available.", DNC.JobID, 0, "", "")]
        DancerFanDance34OnMainComboFeature = 4004,


        // AoE Multibutton Section
        [ConflictingCombos(DancerSimpleFeature, DancerSimpleAoEFeature)]
        [CustomComboInfo("AoE Multibutton", "Change 风车 into procs and combos as available.", DNC.JobID, 0, "", "")]
        DancerAoEMultibutton = 4010,

        [ParentCombo(DancerAoEMultibutton)]
        [CustomComboInfo("AoE Esprit Overcap Option", "Adds Saber Dance to the 风车 combo if you are at 85 or more Esprit.", DNC.JobID, 0, "", "")]
        DancerEspritOvercapAoEFeature = 4011,

        [ParentCombo(DancerEspritOvercapAoEFeature)]
        [CustomComboInfo("AoE Instant Saber Option", "Adds Saber Dance to the 风车 combo if you have at least 50 Esprit.\nOverrides 'AoE Esprit Overcap Option'.", DNC.JobID, 0, "", "")]
        DancerEspritOvercapAoEInstantOption = 4012,

        [ParentCombo(DancerAoEMultibutton)]
        [CustomComboInfo("AoE 扇舞·序 Overcap Protection", "Adds Fan Dance 2 onto 风车 when Fourfold Feathers are full.", DNC.JobID, 0, "", "")]
        DancerFanDanceAoEComboOvercapFeature = 4013,

        [ParentCombo(DancerAoEMultibutton)]
        [CustomComboInfo("AoE Fan Dance On 风车 Feature", "Adds FanDance 3/4 Onto 风车 When available.", DNC.JobID, 0, "", "")]
        DancerFanDanceOnAoEComboFeature = 4014,


        // Dance Features Section (SS/TS)
        [CustomComboInfo("Dance Features", "Features and options involving 标准舞步 and Technical Step.\nCollapsing this category does NOT disable the features inside.", DNC.JobID, 0, "", "")]
        DancerMenuDanceFeatures = 4020,

        [ParentCombo(DancerMenuDanceFeatures)]
        [ConflictingCombos(DancerCombinedDanceFeature, DancerDanceComboCompatibility)]
        [CustomComboInfo("Dance Step Combo", "Change 标准舞步 and Technical Step into each dance step while dancing.\nWorks with Simple Dancer and Simple Dancer AoE.", DNC.JobID, 0, "", "")]
        DancerDanceStepCombo = 4021,

        [ParentCombo(DancerMenuDanceFeatures)]
        [ConflictingCombos(DancerDanceStepCombo, DancerDanceComboCompatibility, DancerSimpleFeature, DancerSimpleAoEFeature)]
        [CustomComboInfo("Combined Dance Feature", "Standard And Technical Dance on one button (SS). Standard > Technical. This combos out into Tillana and 流星舞.", DNC.JobID, 0, "", "")]
        DancerCombinedDanceFeature = 4022,

        [ParentCombo(DancerCombinedDanceFeature)]
        [CustomComboInfo("进攻之探戈 Plus Option", "Adds 进攻之探戈 right after Technical finish.", DNC.JobID, 0, "", "")]
        DancerDevilmentOnCombinedDanceFeature = 4023,

        [ParentCombo(DancerCombinedDanceFeature)]
        [CustomComboInfo("百花争艳 Plus Option", "Adds 百花争艳 to the Combined Dance Feature.", DNC.JobID, 0, "", "")]
        DancerFlourishOnCombinedDanceFeature = 4024,

        [ParentCombo(DancerMenuDanceFeatures)]
        [ConflictingCombos(DancerDanceStepCombo, DancerCombinedDanceFeature, DancerSimpleFeature, DancerSimpleAoEFeature)]
        [CustomComboInfo("Custom Dance Step Feature",
        "Change custom actions into dance steps while dancing." +
        "\nThis helps ensure you can still dance with combos on, without using auto dance." +
        "\nYou can change the respective actions by inputting action IDs below for each dance step." +
        "\nThe defaults are Cascade, Flourish, Fan Dance and Fan Dance II. If set to 0, they will reset to these actions." +
        "\nYou can get Action IDs with Garland Tools by searching for the action and clicking the cog.", DNC.JobID, 0, "", "")]
        DancerDanceComboCompatibility = 4025,


        // Flourishing Features Section
        [ConflictingCombos(DancerSimpleFeature, DancerSimpleAoEFeature)]
        [CustomComboInfo("百花争艳ing Features", "Features and options involving Fourfold Feathers and 百花争艳.\nCollapsing this category does NOT disable the features inside.", DNC.JobID, 0, "", "")]
        DancerMenuFlourishingFeatures = 4030,

        [ParentCombo(DancerMenuFlourishingFeatures)]
        [ConflictingCombos(DancerSimpleFeature, DancerSimpleAoEFeature)]
        [CustomComboInfo("百花争艳 Proc Saver Feature", "Change 百花争艳 into any available Feather-generating procs before using.", DNC.JobID, 0, "", "")]
        DancerFlourishProcFeature = 4031,

        [ParentCombo(DancerFlourishProcFeature)]
        [CustomComboInfo("Proc Saver 扇舞·序 Option", "Include 扇舞·序 3 & 4 in the proc saver during weave-windows.", DNC.JobID, 0, "", "")]
        DancerFlourishProcFanDanceWeaveOption = 4032,


        // Fan Dance Combo Features Section
        [ParentCombo(DancerMenuFlourishingFeatures)]
        [ConflictingCombos(DancerSimpleFeature, DancerSimpleAoEFeature)]
        [CustomComboInfo("扇舞·序 Combo Features", "Options for 扇舞·序 combos. 扇舞·序 3 takes priority over 扇舞·序 4.\nCollapsing this category disables the options inside.", DNC.JobID, 0, "", "")]
        DancerFanDanceComboFeatures = 4033,

        [ParentCombo(DancerFanDanceComboFeatures)]
        [CustomComboInfo("扇舞·序 1 -> 3", "Changes 扇舞·序 1 to 扇舞·序 3 when available.", DNC.JobID, 0, "", "")]
        DancerFanDance1_3Combo = 4034,

        [ParentCombo(DancerFanDanceComboFeatures)]
        [CustomComboInfo("扇舞·序 1 -> 4", "Changes 扇舞·序 1 to 扇舞·序 4 when available.", DNC.JobID, 0, "", "")]
        DancerFanDance1_4Combo = 4035,

        [ParentCombo(DancerFanDanceComboFeatures)]
        [CustomComboInfo("扇舞·序 2 -> 3", "Changes 扇舞·序 2 to 扇舞·序 3 when available.", DNC.JobID, 0, "", "")]
        DancerFanDance2_3Combo = 4036,

        [ParentCombo(DancerFanDanceComboFeatures)]
        [CustomComboInfo("扇舞·序 2 -> 4", "Changes 扇舞·序 2 to 扇舞·序 4 when available.", DNC.JobID, 0, "", "")]
        DancerFanDance2_4Combo = 4037,

        [ConflictingCombos(DancerSimpleFeature, DancerSimpleAoEFeature)]
        [CustomComboInfo("进攻之探戈 to Starfall Feature", "Change 进攻之探戈 into Starfall Dance after use.", DNC.JobID, 0, "", "")]
        DancerDevilmentFeature = 4038,


        // Simple Dancer Section
        [ConflictingCombos(DancerSingleTargetMultibutton, DancerAoEMultibutton, DancerCombinedDanceFeature, DancerDanceComboCompatibility, DancerMenuFlourishingFeatures, DancerDevilmentFeature)]
        [CustomComboInfo("Simple Dancer (Single Target)", "BETA - Single button, single target dancer. Includes songs, flourishes and overprotections.\nConflicts with all other non-simple toggles, except 'Dance Step Combo'\nUse at your own risk!", DNC.JobID, 0, "", "")]
        DancerSimpleFeature = 4050,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Interrupt", "Includes an interrupt in the rotation (if your current target can be interrupted).", DNC.JobID, 0, "", "")]
        DancerSimpleInterruptFeature = 4051,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple 标准舞步", "Includes 标准舞步 in the rotation.", DNC.JobID, 0, "", "")]
        DancerSimpleStandardFeature = 4052,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple 技巧舞步", "Includes 技巧舞步 in the rotation.", DNC.JobID, 0, "", "")]
        DancerSimpleTechnicalFeature = 4053,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Tech 进攻之探戈", "Includes 进攻之探戈 in the rotation (during Technical Finish).", DNC.JobID, 0, "", "")]
        DancerSimpleDevilmentFeature = 4054,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple 百花争艳", "Includes 百花争艳 in the rotation.", DNC.JobID, 0, "", "")]
        DancerSimpleFlourishFeature = 4055,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Feathers", "Includes Feather usage in the rotation.", DNC.JobID, 0, "", "")]
        DancerSimpleFeatherFeature = 4056,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Feather Pooling", "Makes the rotation only use feathers when you have more than 3, or when you're under the effects of 技巧舞步.", DNC.JobID, 0, "")]
        DancerSimpleFeatherPoolingFeature = 4057,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Panic Heals", "Includes 治疗之华尔兹 and Second Wind in the rotation when available and below 30 and 50 percent HP, respectively.", DNC.JobID, 0, "", "")]
        DancerSimplePanicHealsFeature = 4058,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple 即兴表演", "Includes 即兴表演 in the rotation when available.", DNC.JobID, 0, "", "")]
        DancerSimpleImprovFeature = 4059,


        // Simple Dancer AoE Section
        [ConflictingCombos(DancerSingleTargetMultibutton, DancerAoEMultibutton, DancerCombinedDanceFeature, DancerDanceComboCompatibility, DancerMenuFlourishingFeatures, DancerDevilmentFeature)]
        [CustomComboInfo("Simple Dancer (AoE)", "BETA - Single button aoe dancer, including songs, flourishes and overprotections.\nConflicts with all other non-simple toggles, except 'Dance Step Combo'.\nUse at your own risk!", DNC.JobID, 0, "", "")]
        DancerSimpleAoEFeature = 4070,

        [ParentCombo(DancerSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE Interrupt", "Includes an interrupt in the AoE rotation (if your current target can be interrupted).", DNC.JobID, 0, "", "")]
        DancerSimpleAoEInterruptFeature = 4071,

        [ParentCombo(DancerSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE 标准舞步", "Includes 标准舞步 in the AoE rotation.", DNC.JobID, 0, "")]
        DancerSimpleAoEStandardFeature = 4072,

        [ParentCombo(DancerSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE 技巧舞步", "Includes 技巧舞步 in the AoE rotation.", DNC.JobID, 0, "")]
        DancerSimpleAoETechnicalFeature = 4073,

        [ParentCombo(DancerSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE Tech 进攻之探戈", "Includes 进攻之探戈 in the AoE rotation (during Technical Finish).", DNC.JobID, 0, "", "")]
        DancerSimpleAoEDevilmentFeature = 4074,

        [ParentCombo(DancerSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE 百花争艳", "Includes 百花争艳 in the AoE rotation.", DNC.JobID, 0, "", "")]
        DancerSimpleAoEFlourishFeature = 4075,

        [ParentCombo(DancerSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE Feathers", "Includes feather usage in the AoE rotation.", DNC.JobID, 0, "", "")]
        DancerSimpleAoEFeatherFeature = 4076,

        [ParentCombo(DancerSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE Feather Pooling", "Makes it so the AoE rotation only uses feathers when you have more than 3.", DNC.JobID, 0, "", "")]
        DancerSimpleAoEFeatherPoolingFeature = 4077,

        [ParentCombo(DancerSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE Panic Heals", "Includes 治疗之华尔兹 and Second Wind in the rotation when available and below 30 and 50 percent HP, respectively.", DNC.JobID, 0, "", "")]
        DancerSimpleAoEPanicHealsFeature = 4078,

        [ParentCombo(DancerSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE 即兴表演", "Includes 即兴表演 in the AoE rotation when available.", DNC.JobID, 0, "", "")]
        DancerSimpleAoEImprovFeature = 4079,

        #endregion
        // ====================================================================================
        #region DARK KNIGHT

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("Buffs on Main Combo", "收藏品采集ion of Buffs to add to Main Combo", DRK.JobID)]
        DarkMainComboBuffsGroup = 5098,

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("CDs on Main Combo", "收藏品采集ion of CDs to add to Main Combo", DRK.JobID)]
        DarkMainComboCDsGroup = 5099,

        [CustomComboInfo("噬魂斩 Combo", "Replace 噬魂斩 with its combo chain. \nIf all sub options are selected will turn into a full one button rotation (Simple Dark Knight)", DRK.JobID, 0, "Fetch me their souls!", "Heheheheheh")]
        DarkSouleaterCombo = 5000,

        [CustomComboInfo("刚魂 Combo", "Replace 刚魂 with its combo chain.", DRK.JobID, 0, "", "Ugly name for an ugly job")]
        DarkStalwartSoulCombo = 5001,

        [ParentCombo(DarkMainComboBuffsGroup)]
        [CustomComboInfo("血乱 Feature", "Replace 噬魂斩 and Stalwart Soul with Bloodspiller and Quietus when Delirium is active.", DRK.JobID, 0, "", "血乱 is what you have if you choose to play DRK.\nDoc's words, not mine")]
        DeliriumFeature = 5002,

        [ParentCombo(DarkStalwartSoulCombo)]
        [CustomComboInfo("Dark Knight Gauge Overcap Feature", "Replace AoE combo with gauge spender if you are about to overcap.", DRK.JobID, 0, "", "Hey big spenderrrrr")]
        DRKOvercapFeature = 5003,

        [ParentCombo(DarkMainComboCDsGroup)]
        [CustomComboInfo("掠影示现 Feature", "掠影示现 will now be on main combo if its not on CD and you have gauge for it.", DRK.JobID, 0, "", "Trick everyone into thinking a party member is standing where they shouldn't be!")]
        DRKLivingShadowFeature = 5004,

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("EoS Overcap Feature", "Uses EoS if you are above 8.5k mana or Darkside is about to expire (10sec or less)", DRK.JobID, 0, "Something about mana", "You're basically a black mage! Well done!")]
        DarkManaOvercapFeature = 5005,

        [CustomComboInfo("oGCD Feature", "Adds Living Shadow > 腐秽大地 > Carve And Spit > Salt And Darkness to Carve And Spit and Abysal Drain", DRK.JobID, 0, "", "Just does your whole job for you, really")]
        DarkoGCDFeature = 5006,

        [ParentCombo(DarkoGCDFeature)]
        [CustomComboInfo("暗影使者 Feature", "Adds 暗影使者 to oGCD Feature ", DRK.JobID, 0, "", "Wasn't this last expansion?")]
        DarkShadowbringeroGCDFeature = 5007,

        [ParentCombo(DarkMainComboCDsGroup)]
        [CustomComboInfo("跳斩 Feature", "Adds 跳斩 onto main combo whenever its available and Darkside is up.", DRK.JobID, 0, "", "Take the plunge. All the way!")]
        DarkPlungeFeature = 5008,

        [ParentCombo(DeliriumFeature)]
        [CustomComboInfo("Delayed 血乱 Feature", "Delays Bloodspiller by 2 GCDs when 血乱 is used during even windows, uses it regularly during odd windows. Useful for feeding into raid buffs at level 90.", DRK.JobID, 0)]
        DelayedDeliriumFeatureOption = 5010,

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("伤残 Uptime Feature", "Replace Souleater Combo Feature with 伤残 when you are out of range.", DRK.JobID, 0, "Ranged DPS job now, duh", "Stubby little arms, huh")]
        DarkRangedUptimeFeature = 5011,

        [CustomComboInfo("Interrupt Feature", "Replaces Low Blow with Interject when target can be interrupted .", DRK.JobID, 0, "Lower blow", "Blow, but low.")]
        DarkKnightInterruptFeature = 5012,

        [ParentCombo(DarkStalwartSoulCombo)]
        [CustomComboInfo("吸血深渊 Feature", "Adds abyssal drain to the AoE Combo when you fall below 60 percent hp.", DRK.JobID, 0, "", "Even the un-cool kids got heals these days")]
        DRKStalwartabyssalDrainFeature = 5013,

        [ParentCombo(DarkStalwartSoulCombo)]
        [CustomComboInfo("AoE 暗影使者 Feature", "Adds 暗影使者 to the AoE Combo.", DRK.JobID, 0, "", "Wasn't this last expansion?")]
        DRKStalwartShadowbringerFeature = 5014,

        [ParentCombo(DarkStalwartSoulCombo)]
        [CustomComboInfo("FoS Overcap Feature", "Uses FoS if you are above 8.5k mana or Darkside is about to expire (10sec or less)", DRK.JobID, 0, "Something about mana", "You're basically a black mage! Well done!")]
        DarkManaOvercapAoEFeature = 5015,

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("Blood Gauge Overcap Feature", "Adds 血溅 onto main combo when at 80 blood gauge or higher", DRK.JobID, 0, "", "Take the plunge. Or, just dip your toes in. Whatever.")]
        DarkBloodGaugeOvercapFeature = 5016,

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("Level 90 Dark Knight Opener", "Adds the Level 90 Dark Knight Opener to the Main Combo. \nOpener triggered by using The Blackest Night or 嗜血 before combat.", DRK.JobID, 0)]
        DarkOpenerFeature = 5017,

        [ParentCombo(DarkOpenerFeature)]
        [CustomComboInfo("嗜血 out of Combat Feature", "If TBN is used outside of combat, turns the main combo into 嗜血 in preparation for the opener.", DRK.JobID, 0)]
        DarkBloodWeaponOpener = 5018,

        [ParentCombo(DarkMainComboCDsGroup)]
        [CustomComboInfo("暗影使者 Feature", "Adds 暗影使者 on Main Combo while Darkside is up. Will use all stacks on CD.", DRK.JobID, 0)]
        DarkShBFeature = 5019,

        [ParentCombo(DarkManaOvercapFeature)]
        [CustomComboInfo("EoS Burst Option", "Uses EoS until chosen MP limit is reached during even minute window bursts.", DRK.JobID, 0)]
        DarkEoSPoolOption = 5020,

        [ParentCombo(DarkShBFeature)]
        [CustomComboInfo("暗影使者 Burst Option", "Pools 暗影使者 to use during even minute window bursts.", DRK.JobID, 0)]
        DarkBurstShBOption = 5021,

        [ParentCombo(DarkMainComboCDsGroup)]
        [CustomComboInfo("精雕怒斩 Feature", "Adds 精雕怒斩 on Main Combo while Darkside is up.", DRK.JobID, 0)]
        DarkCnSFeature = 5022,

        [ParentCombo(DarkPlungeFeature)]
        [CustomComboInfo("跳斩 Burst Option", "Pools 跳斩 to use during minute window bursts.", DRK.JobID, 0)]
        DarkPlungeBurstOption = 5023,

        [ParentCombo(DarkMainComboCDsGroup)]
        [CustomComboInfo("腐秽大地 Feature", "Adds 腐秽大地 on Main Combo while Darkside is up, will use Salt and Darkness if unlocked.", DRK.JobID, 0)]
        DarkSaltedEarthFeature = 5024,

        [ParentCombo(DeliriumFeature)]
        [CustomComboInfo("血乱 on CD", "Adds 血乱 to Main Combo on CD and when Darkside is up. Will also spend 50 blood gauge if 血乱 is nearly ready to protect from overcap.", DRK.JobID, 0)]
        DarkDeliriumOnCD = 5025,

        [ParentCombo(DarkMainComboBuffsGroup)]
        [CustomComboInfo("嗜血 on CD", "Adds 嗜血 to Main Combo on CD and when Darkside is up.", DRK.JobID, 0)]
        DarkBloodWeaponOption = 5026,
        
        [CustomComboInfo("Double Reprisal Protection", "Prevents the use of Reprisal when target already has the effectby replacing it with 飞石", DRK.JobID)]
        DarkKnightReprisalProtection = 5030,

        #endregion
        // ====================================================================================
        #region DRAGOON

        [ConflictingCombos(DragoonSimple)]
        [CustomComboInfo("跳跃 + Mirage Dive", "Replace (High) 跳跃 with Mirage Dive when Dive Ready.", DRG.JobID, 0, "跳跃 off map", "Oh no, muh double-weaves!")]
        DragoonJumpFeature = 6000,

        [ConflictingCombos(DragoonSimpleAoE)]
        [CustomComboInfo("山境酷刑 Combo", "Replace 山境酷刑 with its combo chain.", DRG.JobID, 1, "", "One combo!")]
        DragoonCoerthanTormentCombo = 6100,

        [ConflictingCombos(DragoonSimple)]
        [CustomComboInfo("樱花怒放 Combo", "Replace 樱花怒放 with its combo chain.", DRG.JobID, 2, "", "Two combo!")]
        DragoonChaosThrustCombo = 6200,

        [ParentCombo(DragoonChaosThrustCombo)]
        [CustomComboInfo("Chaos 贯穿尖 Uptime", "Replaces 樱花怒放 Combo with Piercing Talon when you are out of range.", DRG.JobID, 3, "", "Never stop hitting them.")]
        DragoonPiercingTalonChaosFeature = 6201,

        [ConflictingCombos(DragoonFullThrustComboPlus, DragoonSimple)]
        [CustomComboInfo("直刺 Combo", "Replace 直刺 with its combo chain.", DRG.JobID, 4, "", "Wait... Three combo?")]
        DragoonFullThrustCombo = 6300,

        [ParentCombo(DragoonFullThrustCombo)]
        [CustomComboInfo("Full 贯穿尖 Uptime", "Replaces 直刺 Combo with Piercing Talon when you are out of range.", DRG.JobID, 5, "", "Never stop hitting them.")]
        DragoonPiercingTalonFullFeature = 6301,

        [ConflictingCombos(DragoonFullThrustCombo, DragoonSimple)]
        [CustomComboInfo("直刺 Combo Plus", "Replace 直刺 Plus Combo with its combo chain (Disembowel/Chaosthrust/life surge added).", DRG.JobID, 6, "", "F- Three combo MORE!")]
        DragoonFullThrustComboPlus = 6400,

        [ParentCombo(DragoonFullThrustComboPlus)]
        [CustomComboInfo("High 跳跃 Plus Feature", "Includes High 跳跃 in the rotation.", DRG.JobID, 7, "", "跳跃ing, but higher.")]
        DragoonHighJumpPlusFeature = 6401,

        [ParentCombo(DragoonHighJumpPlusFeature)]
        [CustomComboInfo("Mirage Plus Feature", "Includes Mirage in the rotation.", DRG.JobID, 8, "", "They thought they saw it coming.")]
        DragoonMiragePlusFeature = 6402,

        [ParentCombo(DragoonFullThrustComboPlus)]
        [CustomComboInfo("龙剑 Plus Feature", "Includes 龙剑, while under proper buffs, onto proper GCDs, to the rotation.", DRG.JobID, 9, "", "Hit them harder still.")]
        DragoonLifeSurgePlusFeature = 6404,

        [ParentCombo(DragoonFullThrustComboPlus)]
        [CustomComboInfo("Plus 贯穿尖 Uptime", "Replaces 直刺 with Piercing Talon when you are out of range.", DRG.JobID, 10, "", "Never stop hitting them.")]
        DragoonPiercingTalonPlusFeature = 6403,

        [ConflictingCombos(DragoonFullThrustCombo, DragoonFullThrustComboPlus, DragoonJumpFeature, DragoonChaosThrustCombo, DragoonFangThrustFeature, DragoonFangAndClawFeature)]
        [CustomComboInfo("Simple Dragoon", "One Button, One Dragoon. Conflicts with every non-AoE feature.", DRG.JobID, 11, "", "Nidhogg never stood a chance.")]
        DragoonSimple = 6500,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Simple Opener", "Level 88+. Includes an opener to the Simple Dragoon rotation. OPTIONAL: USE REACTION OR MOACTION FOR OPTIMAL TARGETING.", DRG.JobID, 12, "", "Open with a backjump into the wall!")]
        DragoonOpenerFeature = 6501,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("天龙点睛 Feature", "Includes 天龙点睛 to the Simple Dragoon rotation.", DRG.JobID, 13, "", "Blue and red Dragons! Oh my.")]
        DragoonWyrmwindFeature = 6502,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("武神枪 and Nastrond Feature", "Includes 武神枪 and Nastrond in the rotation.", DRG.JobID, 18, "", "Let me chuck another dragon soul at them!")]
        DragoonGeirskogulNastrondFeature = 6503,

        [ConflictingCombos(DragoonLitanyDiveFeature, DragoonLanceDiveFeature, DragoonLifeLitanyDiveFeature)]
        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Dives Feature", "Single Weave Friendly, but not optimal: Includes 破碎冲, 龙炎冲 and Stardiver in the rotation.", DRG.JobID, 14, "", "Don't jump to your death!")]
        DragoonDiveFeature = 6504,

        [ConflictingCombos(DragoonDiveFeature, DragoonLitanyDiveFeature, DragoonLifeLitanyDiveFeature)]
        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Dives under 猛枪 Feature", "Single Weave Friendly: Includes 破碎冲 and Dragonfire Dive in the rotation, while under 猛枪, and 坠星冲 while under Life of the Dragon.", DRG.JobID, 17, "", "Don't jump to your death!")]
        DragoonLanceDiveFeature = 6505,

        [ConflictingCombos(DragoonDiveFeature, DragoonLanceDiveFeature, DragoonLifeLitanyDiveFeature)]
        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Dives under Litany Feature", "Double Weaves Required: Includes 破碎冲 and Dragonfire Dive in the rotation, while under 战斗连祷, and 坠星冲 while under Life of the Dragon.", DRG.JobID, 15, "", "Don't jump to your death!")]
        DragoonLitanyDiveFeature = 6506,

        [ConflictingCombos(DragoonDiveFeature, DragoonLanceDiveFeature, DragoonLitanyDiveFeature)]
        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Dives under Litany and Life of the Dragon Feature", "Double Weaves Required: Includes 破碎冲 and Dragonfire Dive in the rotation, while under 战斗连祷 and Life of the Dragon, and 坠星冲 while under Life of the Dragon.", DRG.JobID, 16, "", "Don't jump to your death!")]
        DragoonLifeLitanyDiveFeature = 6507,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("High 跳跃 Feature", "Includes High 跳跃 in the rotation.", DRG.JobID, 19, "", "跳跃ing, but higher.")]
        DragoonHighJumpFeature = 6508,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Mirage Feature", "Includes Mirage in the rotation.", DRG.JobID, 20, "", "They thought they saw it coming.")]
        DragoonMirageFeature = 6509,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Buffs Feature", "Includes 猛枪 and Battle Litany to the rotation.", DRG.JobID, 21, "", "This is why your team loves you.")]
        DragoonBuffsFeature = 6510,

        [ParentCombo(DragoonBuffsFeature)]
        [CustomComboInfo("巨龙视线 Feature", "Includes 巨龙视线 to the rotation. OPTIONAL: USE REACTION OR MOACTION FOR OPTIMAL TARGETING.", DRG.JobID, 22, "", "This is why your team loves you, too.")]
        DragoonDragonSightFeature = 6511,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("龙剑 Feature", "Includes 龙剑, while under proper buffs, onto proper GCDs, to the rotation.", DRG.JobID, 23, "", "Hit them with more feeling!")]
        DragoonLifeSurgeFeature = 6512,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Simple 贯穿尖 Feature", "Replaces 直刺 Combo with Piercing Talon when you are out of range. NOT OPTIMAL", DRG.JobID, 24, "", "Never stop hitting them.")]
        DragoonSimplePiercingTalonFeature = 6513,

        [ConflictingCombos(DragoonCoerthanTormentCombo)]
        [CustomComboInfo("Simple Dragoon AoE", "One Button, many enemies hit.", DRG.JobID, 25, "", "Never stop hitting them ALL.")]
        DragoonSimpleAoE = 6600,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("天龙点睛 AoE Feature", "Includes 天龙点睛 to the Simple Dragoon AoE rotation.", DRG.JobID, 26, "", "Blue and red Dragons! Oh my.")]
        DragoonAoEWyrmwindFeature = 6601,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("武神枪 and Nastrond AoE Feature", "Includes 武神枪 and Nastrond in the AoE rotation.", DRG.JobID, 27, "", "Let me chuck another dragon soul at them!")]
        DragoonAoEGeirskogulNastrondFeature = 6602,

        [ConflictingCombos(DragoonAoELitanyDiveFeature, DragoonAoELifeLitanyDiveFeature)]
        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Dives AoE Feature", "Includes 破碎冲, 龙炎冲 and Stardiver in the AoE rotation.", DRG.JobID, 28, "", "Don't jump to your death!")]
        DragoonAoEDiveFeature = 6603,

        [ConflictingCombos(DragoonAoEDiveFeature, DragoonAoELitanyDiveFeature, DragoonAoELifeLitanyDiveFeature)]
        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Dives under 猛枪 AoE Feature", "Single Weave Friendly: Includes 破碎冲 and Dragonfire Dive in the AoE rotation, while under 猛枪, and 坠星冲 while under Life of the Dragon.", DRG.JobID, 29, "", "Don't jump to your death!")]
        DragoonAoELanceDiveFeature = 6604,

        [ConflictingCombos(DragoonAoEDiveFeature, DragoonAoELanceDiveFeature, DragoonAoELifeLitanyDiveFeature)]
        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Dives under Litany AoE Features", "Includes 破碎冲 and Dragonfire Dive in the AoE rotation, while under 战斗连祷, and 坠星冲 while under Life of the Dragon.", DRG.JobID, 30, "", "Don't jump to your death!")]
        DragoonAoELitanyDiveFeature = 6605,

        [ConflictingCombos(DragoonAoEDiveFeature, DragoonAoELanceDiveFeature, DragoonAoELitanyDiveFeature)]
        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Dives under Litany and Life of the Dragon AoE Features", "Includes 破碎冲 and Dragonfire Dive in the AoE rotation, while under 战斗连祷 and Life of the Dragon, and 坠星冲 while under Life of the Dragon.", DRG.JobID, 31, "", "Don't jump to your death!")]
        DragoonAoELifeLitanyDiveFeature = 6606,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("High 跳跃 AoE Feature", "Includes High 跳跃 in the AoE rotation.", DRG.JobID, 32, "", "跳跃ing, but higher.")]
        DragoonAoEHighJumpFeature = 6607,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Mirage AoE Feature", "Includes Mirage in the AoE rotation.", DRG.JobID, 33, "", "They thought they saw it coming.")]
        DragoonAoEMirageFeature = 6608,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Buffs AoE Feature", "Includes 猛枪 and Battle Litany to the AoE rotation.", DRG.JobID, 34, "", "This is why your team loves you.")]
        DragoonAoEBuffsFeature = 6609,

        [ParentCombo(DragoonAoEBuffsFeature)]
        [CustomComboInfo("巨龙视线 AoE Feature", "Includes 巨龙视线 to the AoE rotation. OPTIONAL: USE REACTION OR MOACTION FOR OPTIMAL TARGETING.", DRG.JobID, 35, "", "This is why your team loves you, too.")]
        DragoonAoEDragonSightFeature = 6610,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("龙剑 AoE Feature", "Includes 龙剑, while under proper buffs, onto proper GCDs, to the AoE rotation.", DRG.JobID, 36, "", "Hit them with more feeling!")]
        DragoonAoELifeSurgeFeature = 6611,

        [ConflictingCombos(DragoonSimple)]
        [CustomComboInfo("Wheeling Thrust/龙牙龙爪 Option", "When you have either Enhanced 龙牙龙爪 or Wheeling Thrust, Chaos Thrust Combo becomes Wheeling Thrust and 直刺 Combo becomes Fang and Claw. Requires Chaos Thrust Combo and 直刺 Combo.", DRG.JobID, 37, "ALL THE COMBOS", "Turns Wheeling Thrust into 火炎 IV when Hallowed or PvP options are active.")]
        DragoonFangThrustFeature = 6700,

        [ConflictingCombos(DragoonSimple)]
        [CustomComboInfo("Wheeling Thrust/龙牙龙爪 Feature", "Fang And Claw Becomes 龙尾大回旋 when under Enhanced 龙尾大回旋 Buff.", DRG.JobID, 38, "Reinventing the Wheel", "Absolutely WHEELING, my guy")]
        DragoonFangAndClawFeature = 6701,

        #endregion
        // ====================================================================================
        #region GUNBREAKER

        [CustomComboInfo("迅连斩 Combo", "Replace 迅连斩 with its combo chain. \nIf all sub options are selected will turn into a full one button rotation (Simple Gunbreaker)", GNB.JobID, 0, "Floppy Barrel Combo", "Not so solid NOW, are ya?")]
        GunbreakerSolidBarrelCombo = 7000,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("烈牙 and Continuation on Main Combo", "Adds 烈牙 to the main combo. 烈牙 must be started manually and the combo will finish it off.\n Useful for when 烈牙 needs to be help due to downtime.", GNB.JobID, 0, "Fashing Gnang", "Why grandma, what big teeth you have!")]
        GunbreakerGnashingFangOnMain = 7001,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("CDs on Main Combo", "Adds various CDs to the Main Combo when under 无情 or when 无情 is on cooldown", GNB.JobID, 0, "Gee Whiz!", "Mom, I can't manage my oGCDs!")]
        GunbreakerMainComboCDsGroup = 7002,

        [ParentCombo(GunbreakerMainComboCDsGroup)]
        [CustomComboInfo("危险领域/Blasting Zone on Main Combo", "Adds 危险领域/Blasting Zone to the Main Combo", GNB.JobID, 0)]
        GunbreakerDZOnMainComboFeature = 7005,

        [ParentCombo(GunbreakerMainComboCDsGroup)]
        [CustomComboInfo("倍攻 on Main Combo", "Adds Double Down on main combo when under 无情 buff", GNB.JobID, 0, "ALL the deeps", "For when you're both feeling merciless and are stuffed full of powder. BANG!")]
        GunbreakerDDonMain = 7003,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("粗分斩 Option", "Adds 粗分斩 onto main combo whenever it's available.", GNB.JobID, 0, "Divide... Roughly", "Ayo pour one out for the homie Squall")]
        GunbreakerRoughDivideFeature = 7004,

        [ParentCombo(GunbreakerDemonSlaughterCombo)]
        [CustomComboInfo("弓形冲波 on AoE Feature", "Adds Bow Shock onto the aoe combo when it's off cooldown. Recommended to use with 烈牙 features.", GNB.JobID, 0, "AoE cattleprod enabler")]
        GunbreakerBowShockFeature = 7017,

        [CustomComboInfo("恶魔杀 Combo", "Replace 恶魔杀 with its combo chain.", GNB.JobID, 0, "dEmOn SlAuGhTeR", "恶魔杀? Really? What is this, RPR?")]
        GunbreakerDemonSlaughterCombo = 7006,

        [CustomComboInfo("Ammo Overcap Feature", "Uses 爆发击/Fated Circle on the respective ST/AoE combos when ammo is about to overcap.", GNB.JobID, 0, "Pew Pew Forever", "The whole nine yards")]
        GunbreakerAmmoOvercapFeature = 7007,

        [CustomComboInfo("烈牙 Continuation Combo", "Adds Continuation to 烈牙.", GNB.JobID, 0, "More Mercy", "More, no wait, less, no wait, MORE Mercy! No, wait...")]
        GunbreakerGnashingFangCombo = 7008,

        [ParentCombo(GunbreakerGnashingFangCombo)]
        [CustomComboInfo("无情 on Gnashing Fang", "Adds 无情 to Gnashing Fang when it's ready.", GNB.JobID, 0, "Blue DPS be like", "This one comes with teeth.")]
        GunbreakerNoMercyonGF = 7009,

        [ParentCombo(GunbreakerGnashingFangCombo)]
        [CustomComboInfo("Double Down on 烈牙", "Adds Double Down to Gnashing Fang when 无情 buff is up.", GNB.JobID, 0, "My hotbars are a (tiny) mess!", "Thanks plogon!")]
        GunbreakerDDOnGF = 7010,

        [ParentCombo(GunbreakerGnashingFangCombo)]
        [CustomComboInfo("CDs on 烈牙", "Adds Sonic Break/Bow Shock/Blasting Zone on 烈牙, order dependent on 无情 buff. \nBurst Strike added if there's charges while 无情 buff is up.", GNB.JobID, 0, "More Teeth", "Gnashing fang, but like, if a shark did it. Or something.")]
        GunbreakerCDsOnGF = 7011,

        [CustomComboInfo("BurstStrike续剑", "Adds Hypervelocity on Burst Strike Continuation combo and main combo and 烈牙.", GNB.JobID, 0, "Swish, swoosh", "Now we're cooking with gas! Hyper!")]
        GunbreakerBurstStrikeConFeature = 7012,

        [CustomComboInfo("爆发击 to Bloodfest Feature", "Replace 爆发击 with Bloodfest if you have no powder gauge.", GNB.JobID, 0, "P4S Vampire man 血壤 Feature", "Again with the edgelord names?\nTut, tut, Yoshi-P. Do better.")]
        GunbreakerBloodfestOvercapFeature = 7013,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("闪雷弹 Uptime", "Replace Solid Barrel Combo Feature with 闪雷弹 when you are out of range.", GNB.JobID, 0, "Stubby-armed GNB", "Can't reach?")]
        GunbreakerRangedUptimeFeature = 7015,

        [CustomComboInfo("Interrupt Feature", "Replaces LowBlow with Interject when target can be interrupted .", GNB.JobID, 0, "Lower blow", "Blow, but low.")]
        GunbreakerInterruptFeature = 7016,

        [ParentCombo(GunbreakerMainComboCDsGroup)]
        [CustomComboInfo("血壤 on Main Combo", "Adds 血壤 to main combo when ammo is 0.", GNB.JobID, 0)]
        GunbreakerBloodfestonST = 7014,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("无情 on Main Combo", "Adds 无情 to main combo when at full ammo.", GNB.JobID, 0)]
        GunbreakerNoMercyonST = 7018,

        [ParentCombo(GunbreakerGnashingFangOnMain)]
        [CustomComboInfo("烈牙 Starter", "Begins 烈牙 on main combo.", GNB.JobID, 0)]
        GunbreakerGFStartonMain = 7019,

        [ParentCombo(GunbreakerMainComboCDsGroup)]
        [CustomComboInfo("弓形冲波 on Main Combo", "Adds 弓形冲波 to the Main Combo", GNB.JobID, 0)]
        GunbreakerBSOnMainComboFeature = 7020,

        [ParentCombo(GunbreakerMainComboCDsGroup)]
        [CustomComboInfo("音速破 on Main Combo", "Adds 音速破 to the Main Combo", GNB.JobID, 0)]
        GunbreakerSBOnMainComboFeature = 7021,

        [CustomComboInfo("音速破/Bow Shock on NM", "Adds Sonic Break and Bow Shock to 无情 when NM is on CD", GNB.JobID, 0)]
        GunbreakerCDsonNMFeature = 7022,

        [ParentCombo(GunbreakerMainComboCDsGroup)]
        [CustomComboInfo("爆发击 on Main Combo", "Adds Burst Strike to Main Combo when under 无情 and Gnashing Fang is over.", GNB.JobID, 0)]
        GunbreakerBSinNMFeature = 7023,
        
        [CustomComboInfo("Double Reprisal Protection", "Prevents the use of Reprisal when target already has the effectby replacing it with 飞石", GNB.JobID)]
        GunbreakerReprisalProtection = 7030,

        #endregion
        // ====================================================================================
        #region MACHINIST

        [CustomComboInfo("(Heated) Shot Combo", "Replace either form of 狙击弹 with its combo chain.", MCH.JobID, 0, "Alright, Hotshot -", "Is there really such a thing as a clean shot? Let's find out.")]
        MachinistMainCombo = 8000,

        [CustomComboInfo("Overdrive Feature", "Replace 车式浮空炮塔 and Automaton Queen with Overdrive while active.", MCH.JobID, 0, "Drive (2011) Feature", "Insert synthwave soundtrack here.")]
        MachinistOverdriveFeature = 8002,

        [CustomComboInfo("虹吸弹 / Ricochet Feature", "Replace 虹吸弹 and Ricochet with one or the other depending on which has more charges.", MCH.JobID, 0, "Gatling feature", "It's just a lot of bullets, really.")]
        MachinistGaussRoundRicochetFeature = 8003,

        [CustomComboInfo("Drill / Air Anchor (热弹) Feature", "Replace Drill and Air Anchor (热弹) with one or the other (or Chainsaw) depending on which is on cooldown.", MCH.JobID, 0, "Multi-tool", "Why does MCH have a drill and a chainsaw? What is this, DoH?")]
        MachinistHotShotDrillChainsawFeature = 8004,

        [ParentCombo(MachinistMainCombo)]
        [ConflictingCombos(MachinistAlternateMainCombo)]
        [CustomComboInfo("钻头/Air/Chain Saw Feature On Main Combo", "Air Anchor followed by Drill is added onto main combo if you use 整备.\nIf Air Anchor is on cooldown and you use 整备, Chainsaw will be added to main combo instead.", MCH.JobID, 0, "A bit of everything feature", "Don't rub your last two brain-cells together! We got you!")]
        MachinistDrillAirOnMainCombo = 8005,

        [CustomComboInfo("Single Button 热冲击", "Switches 热冲击 to Hypercharge.", MCH.JobID, 0, "So-called '热冲击'", "Basically a large hair-dryer.")]
        MachinistHeatblastGaussRicochetFeature = 8006,

        [CustomComboInfo("Single Button 自动弩", "Switches 自动弩 to Hypercharge and weaves gauss/rico.", MCH.JobID, 0, "Laser Crossbow", "It's a crossbow, from the future!")]
        MachinistAutoCrossBowGaussRicochetFeature = 8018,

        [ParentCombo(MachinistMainCombo)]
        [ConflictingCombos(MachinistDrillAirOnMainCombo)]
        [CustomComboInfo("Alternate 钻头/Air Feature on Main Combo", "Drill/Air/Hotshot Feature is added onto main combo (Note: It will add them onto main combo ONLY if you are under 整备 Buff\nOr Reasemble is on CD (Will do nothing if 整备 is OFF CD)", MCH.JobID, 0, "Gunbreaker feature", "Look at me - I'm the tank now.")]
        MachinistAlternateMainCombo = 8007,

        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("Single Button HeatBlast On Main Combo Option", "Adds Single Button Heatblast onto the main combo when the option is enabled.", MCH.JobID, 0, "Scalp burner", "Dry your hair even faster! Even hotter! Owch!")]
        MachinistHeatBlastOnMainCombo = 8008,

        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("Battery Overcap Option", "Overcharge protection for your Battery, If you are at 100 battery charge rook/queen will be added to your (Heated) Shot Combo.", MCH.JobID, 0, "Battery", "Isn't battery like, assault? What's wrong with you?")]
        MachinistOverChargeOption = 8009,

        [ParentCombo(MachinistSpreadShotFeature)]
        [CustomComboInfo("Battery AOE Overcap Option", "Adds overcharge protection to 散射/Scattergun.", MCH.JobID, 0, "Battery", "Isn't battery like, assault? What's wrong with you?")]
        MachinistAoEOverChargeOption = 8010,

        [ParentCombo(MachinistSpreadShotFeature)]
        [CustomComboInfo("虹吸弹 Ricochet on AOE Feature", "Adds 虹吸弹/Ricochet to the AoE combo during Hypercharge.", MCH.JobID, 0, "Ratchet and Clank Feature", "Bouncing off the walls")]
        MachinistAoEGaussRicochetFeature = 8011,

        [ParentCombo(MachinistAoEGaussRicochetFeature)]
        [CustomComboInfo("Always 虹吸弹/Ricochet on AoE Option", "Adds 虹吸弹/Ricochet to the AoE combo outside of Hypercharge windows.", MCH.JobID, 0, "Ratchet and Clank Feature", "Bouncing off the walls")]
        MachinistAoEGaussOption = 8012,

        [ConflictingCombos(MachinistRicochetGaussMainCombo)]
        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("Ricochet & 虹吸弹 Feature", "Adds Ricochet and 虹吸弹 to main combo. Will use all charges.", MCH.JobID, 0, "Pew +1", "All the shots, ALL of the time.")]
        MachinistRicochetGaussChargesMainCombo = 8017,

        [ConflictingCombos(MachinistRicochetGaussChargesMainCombo)]
        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("Ricochet & 虹吸弹 overcap protection option", "Adds Ricochet and 虹吸弹 to main combo. Will leave 1 charge of each.", MCH.JobID, 0, "", "Never run out of bullets again! Or never have too many! Or something!\nBullets!")]
        MachinistRicochetGaussMainCombo = 8013,

        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("枪管加热 drift protection feature", "Adds 枪管加热 onto the main combo if heat is between 5-20.", MCH.JobID, 0, "Third Leg", "Adds Barrel Stabiliser when you're in heat. You heard me.")]
        BarrelStabilizerDrift = 8014,

        [ParentCombo(MachinistHeatblastGaussRicochetFeature)]
        [CustomComboInfo("野火 Feature", "Adds Wildfire to the Single Button Heat Blast Feature if Wildfire is off cooldown and you have enough heat for Hypercharge then Hypercharge will be replaced with Wildfire.\nAlso weaves Ricochet/虹吸弹 on Heat Blast when necessary.", MCH.JobID, 0, "PEW", "PEW PEW PEW PEW, AND PEW.\nALSO WEAVES PEW AND PEW.")]
        MachinistWildfireFeature = 8015,

        [ParentCombo(MachinistSpreadShotFeature)]
        [CustomComboInfo("毒菌Blaster Feature", "Adds 毒菌冲击 to the Spreadshot feature", MCH.JobID, 0, "War crime feature", "This is like uh, some sort of anthrax? Jeez bro. Relax.\nBanned by the Geneva Convention.")]
        MachinistBioblasterFeature = 8016,

        [CustomComboInfo("Barrel Feature", "Adds Barrel Stabalizer to Single Button 热冲击 and Single Button Auto Crossbow Features when below 50 heat and is off cooldown", MCH.JobID, 0, "Hot Cross Bow", "Now multi-purpose!")]
        MachinistAutoBarrel = 8019,

        [ConflictingCombos(MachinistMainCombo)]
        [CustomComboInfo("Simple Machinist", "Single button single target machinist, including buffs and overprotections.\nConflicts with other single target toggles!!\nMade to work optimally with a 2.5 GCD.", MCH.JobID, 0, "", "Goodbye, brain!")]
        MachinistSimpleFeature = 8020,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Interrupt", "Uses interrupt during simple machinist rotation, if applicable.", MCH.JobID, 0, "Simple Interr-", "Excuse me, I wa-")]
        MachinistSimpleInterrupt = 8021,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Gadget", "Adds Queen or Rook uses to the feature, based on your current level.\nTry to use Queen at optimal intervals between :55 to :05 windows.", MCH.JobID, 0, "Gadgeteer", "My queen!")]
        MachinistSimpleGadget = 8022,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Assembling", "Pairs reassemble uses with the following skills.\nBefore acquiring Drill it will be used with 狙击弹.", MCH.JobID, 0, "Megablox", "It's like Lego bricks! But worse!")]
        MachinistSimpleAssembling = 8023,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Gauss 弹射", "Adds 虹吸弹 and Ricochet uses to the feature.", MCH.JobID, 0, "", "More bullets!")]
        MachinistSimpleGaussRicochet = 8024,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Wildcharge", "Adds Hypercharge and 野火 uses to the feature.\nIt respects the 8 second rule of Drill, AirAnchor and Chainsaw.", MCH.JobID, 0, "Simply fantastic", "Is it really THAT simple?")]
        MachinistSimpleWildCharge = 8025,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Stabilizer", "Adds Barrel Stabilizer to the feature.\nWhen heat < 50 and 野火 is off CD or about to come off CD.", MCH.JobID, 0, "Third Leg", "Reduces recoil when spraying and praying.")]
        MachinistSimpleStabilizer = 8026,

        [ParentCombo(MachinistSpreadShotFeature)]
        [CustomComboInfo("超荷", "Adds hypercharge to the AoE.", MCH.JobID, 0, "Sugar Rush", "I'm gonna slap @augporto for putting in so many damn MCH features.\nHow full of witty one-liners do you think I am?!")]
        MachinistAoEHyperchargeFeature = 8027,

        [CustomComboInfo("Simple Machinist AOE", "散射 turns into Scattergun when lvl 82 or higher, Both turn into 自动弩 when overheated\nand Bioblaster is used first whenever it is off cooldown.", MCH.JobID, 0, "Dungeon go zzzz", "AoE, but you're just not here. Go make a coffee.")]
        MachinistSpreadShotFeature = 8028,

        [ParentCombo(MachinistSimpleAssembling)]
        [CustomComboInfo("钻头","Use 整备 with Drill when available.", MCH.JobID,0,"刺鱼aDrillBreaker","The 钻头 that will pierce the heavens!")]
        MachinistSimpleAssemblingDrill = 8029,

        [ParentCombo(MachinistSimpleAssembling)]
        [CustomComboInfo("空气锚", "Use 整备 with Air Anchor when available.", MCH.JobID, 0, "Air Guitar", "出卡 the tunes!")]
        MachinistSimpleAssemblingAirAnchor = 8030,

        [ParentCombo(MachinistSimpleAssembling)]
        [CustomComboInfo("回转飞锯", "Use 整备 with Chain Saw when available.", MCH.JobID, 0, "刺鱼a Sauce", "The secret to life.")]
        MachinistSimpleAssemblingChainSaw = 8031,

        [ParentCombo(MachinistSimpleAssemblingDrill)]
        [CustomComboInfo("Only use 钻头...", "...when you have max charges of reassemble.", MCH.JobID, 0, "刺鱼aDrillBreaker MAX", "Mow pow in the pew!")]
        MachinistSimpleAssemblingDrillMaxCharges = 8032,

        [ParentCombo(MachinistSimpleAssemblingAirAnchor)]
        [CustomComboInfo("Only use 空气锚...", "...when you have max charges of reassemble.", MCH.JobID, 0, "刺鱼aDrillBreaker MAX", "Mow pow in the pew!")]
        MachinistSimpleAssemblingAirAnchorMaxCharges = 8033,

        [ParentCombo(MachinistSimpleAssemblingChainSaw)]
        [CustomComboInfo("Only use 回转飞锯...", "...when you have max charges of reassemble.", MCH.JobID, 0, "刺鱼aDrillBreaker MAX", "Mow pow in the pew!")]
        MachinistSimpleAssemblingChainSawMaxCharges = 8034,

        #endregion
        // ====================================================================================
        #region MONK

        [CustomComboInfo("AoE Combo", "Replaces Arm Of The Destroyer/Shadow Of The Destroyer with the AoE combo chain.", MNK.JobID, 0, "", "Punching, but wide. It's like having extra hands!")]
        MnkAoECombo = 9000,

        [CustomComboInfo("连击 Feature", "Replaces Dragon Kick with 连击 if both a form and Leaden Fist are up.", MNK.JobID, 0, "", "Shine ya shoes, guv'na?")]
        MnkBootshineFeature = 9001,

        [CustomComboInfo("双掌打 Feature", "Replaces 正拳 with Twin Snakes if Disciplined Fist is not applied or is less than 6 seconds from falling off.", MNK.JobID, 0, "", "I've had it with these MF snakes on this MF plane!")]
        MnkTwinSnakesFeature = 9011,

        [ConflictingCombos(MnkBasicComboPlus)]
        [CustomComboInfo("Basic Rotation", "Basic Monk Combo on one button", MNK.JobID, 0, "", "I presses the buttons, I does the deeps")]
        MnkBasicCombo = 9002,

        [CustomComboInfo("震脚 Feature", "震脚 becomes Masterful Blitz while you have 3 Beast Chakra.", MNK.JobID, 0, "", "They say life is like walking a tightrope...")]
        MonkPerfectBalanceFeature = 9003,

        [CustomComboInfo("连击 Balance Feature", "Replaces 双龙脚 with Masterful Blitz if you have 3 Beast Chakra.", MNK.JobID, 0, "The tin", "Does what it says on the tin")]
        MnkBootshineBalanceFeature = 9004,

        [CustomComboInfo("Howling Fist/斗气 Feature", "Replaces Howling Fist/Enlightenment with 斗气 when the Fifth Chakra is not open.", MNK.JobID, 0, "", "Imagine using your fist to scream at someone. Welcome to MNK!\nEnjoy your stay.")]
        MonkHowlingFistMeditationFeature = 9005,

        [ConflictingCombos(MnkBasicCombo)]
        [CustomComboInfo("Basic Rotation Plus", "Basic Monk Combo on one button Plus (Only for Testing)", MNK.JobID, 0, "", "They call it 'basic' for a reason, you donkey")]
        MnkBasicComboPlus = 9006,

        [CustomComboInfo("震脚 Feature Plus", "All of the (Optimal?) Blitz combos on Masterful Blitz when 震脚 Is Active", MNK.JobID, 0, "", "Try not to fall over, eh")]
        MnkPerfectBalancePlus = 9007,

        [ParentCombo(MnkBasicComboPlus)]
        [CustomComboInfo("必杀技 to Main Combo", "Adds all of (Optimal?) Blitz combos and 必杀技 on Main Combo", MNK.JobID, 0, "", "It's maths, but for your Single Target combo!")]
        MonkMasterfullBlizOnMainCombo = 9008,

        [ParentCombo(MnkAoECombo)]
        [CustomComboInfo("必杀技 to AoE Combo", "Adds all of (Optimal?) Blitz combos and 必杀技 on AoE Combo.", MNK.JobID, 0, "", "It's maths, but for your AoE combo!")]
        MonkMasterfullBlizOnAoECombo = 9009,

        [CustomComboInfo("Forbidden Chakra Feature", "Adds Forbidden Chakra/Enlightement to the Main/AoE feature combo. Testing Only for now!", MNK.JobID, 0, "But, wait!", "Mom said no! It's forbidden!")]
        MonkForbiddenChakraFeature = 9010,

        [CustomComboInfo("Riddle of 火炎/Brotherhood Feature", "Replaces Riddle of 火炎 with Brotherhood when Riddle of 火炎 is on cooldown.", MNK.JobID, 0, "", "Riddle me this, brotha'")]
        MnkRiddleOfFireBrotherhoodFeature = 9012,

        [ParentCombo(MnkBasicComboPlus)]
        [CustomComboInfo("Damage Buffs to Main Combo Feature", "Places Riddle of Fire and Brotherhood onto main combo when 震脚 is up.", MNK.JobID, 0, "", "Been passed on for dance partner again? Don't worry, you have some buffs of your own.")]
        MnkMainComboBuffsFeature = 9013,

        [ParentCombo(MnkBasicComboPlus)]
        [CustomComboInfo("疾风极意 Main Combo Feature", "Places Riddle of Wind onto main combo after using 双掌打.", MNK.JobID, 0, "", "Easy, breezy.")]
        MnkRiddleOfWindFeature = 9014,

        #endregion
        // ====================================================================================
        #region NINJA

        [ConflictingCombos(NinSimpleSingleTarget)]
        [CustomComboInfo("强甲破点突 Combo", "Replace 强甲破点突 with its combo chain.", NIN.JobID, 0, "One, Two, Three", "It's a Ninja's life for me")]
        NinjaArmorCrushCombo = 10000,

        [ConflictingCombos(NinSimpleSingleTarget)]
        [CustomComboInfo("旋风刃 Combo", "Replace 旋风刃 with its combo chain.", NIN.JobID, 0, "Edgy Edge Combo", "Knife go stab")]
        NinjaAeolianEdgeCombo = 10001,

        //[CustomComboInfo("Simple AoE", "Replaces 血雨飞花 with the AoE rotation.", NIN.JobID)]
        //NinjaHakkeMujinsatsuCombo = 10002,

        //[CustomComboInfo("Dream to 断绝", "Replace Dream Within a Dream with 断绝 when 断绝 Ready.", NIN.JobID)]
        //NinjaAssassinateFeature = 10003,

        [CustomComboInfo("生杀予夺 to Trick", "Replaces Kassatsu with 攻其不备 while Suiton or Hidden is up.\nCooldown tracking plugin recommended.", NIN.JobID, 0, "Katsu Curry to Trick", "This is how we eat at a restaurant and don't pay the bill.\nRUN!")]
        NinjaKassatsuTrickFeature = 10004,

        [CustomComboInfo("天之印 Chi Jin to Meisui", "Replaces 天之印 Chi Jin (the move) with Meisui while Suiton is up.\nCooldown tracking plugin recommended.", NIN.JobID, 0, "天之印 Chin Scratches to Chop-Suey", "Does something, probably.\nHow do you deal with all these attack names?")]
        NinjaTCJMeisuiFeature = 10005,

        [CustomComboInfo("Kassatsu 地之印/Jin Feature", "Replaces 地之印 with Jin while Kassatsu is up if you have Enhanced Kassatsu.", NIN.JobID, 0, "", "Swaps your Katsu curry with a 地之印 地之印n-scratch.")]
        NinjaKassatsuChiJinFeature = 10006,

        [CustomComboInfo("隐遁 to Mug", "Replaces 隐遁 with Mug while in combat.", NIN.JobID, 0, "Stand and Deliver", "John Cena is a thief, now?")]
        NinjaHideMugFeature = 10007,

        [CustomComboInfo("Aeolian to 忍术 Feature", "Replaces 旋风刃 (combo) with Ninjutsu if any Mudra are used.", NIN.JobID, 0, "Hand signs and all that", "Do the Naruto thing, I think.\nIdk I don't watch anime, sorry")]
        NinjaNinjutsuFeature = 10008,

        [ConflictingCombos(NinSimpleSingleTarget)]
        [CustomComboInfo("GCDs to 忍术 Feature", "Every GCD combo becomes 忍术 while Mudras are being used.", NIN.JobID, 0, "Full-on Sign Language", "NOW you're really communicating with the party.")]
        NinjaGCDNinjutsuFeature = 10009,

        [CustomComboInfo("风来刃 / Raiju Feature", "Replaces Huraijin with Forked and 月影雷兽牙 when available.", NIN.JobID, 0, "Pikachu / Raichu Feature", "Does something? Maybe? Evolutions? Combos? Probably.")]
        NinjaHuraijinRaijuFeature = 10010,

        [ParentCombo(NinjaHuraijinRaijuFeature)]
        [CustomComboInfo("风来刃 / Raiju Feature Option 1", "Replaces Huraijin with 月影雷兽牙 when available.", NIN.JobID, 0, "Pikachu / Raichu Option 1", "Does the same thing probably, who knows.")]
        NinjaHuraijinRaijuFeature1 = 10011,

        [ParentCombo(NinjaHuraijinRaijuFeature)]
        [CustomComboInfo("风来刃 / Raiju Feature Option 2", "Replaces Huraijin with 月影雷兽爪 when available.", NIN.JobID, 0, "Pikachu / Raichu Option 2", "What we DO know, is that all NIN mains just slam their heads on the keyboard to do combos, anyway.")]
        NinjaHuraijinRaijuFeature2 = 10012,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("强甲破点突 Feature", "Adds 强甲破点突 onto main combo.", NIN.JobID, 0, "", "Act like you can crush armor with your kitchen knives or whatever.")]
        NinjaArmorCrushOnMainCombo = 10013,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("Raiju Feature", "Adds Fleeting Raiju to 旋风刃 Combo.", NIN.JobID, 0, "Raichu Feature", "闪雷bolt!")]
        NinjaFleetingRaijuFeature = 10014,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("风来刃ToMainCombo", "Adds 风来刃 to main combo if Huton buff is not present", NIN.JobID, 0, "", "Smells like a hurricane. No idea.")]
        NinjaHuraijinFeature = 10015,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("分身之术OnMainCombo", "Adds 分身之术 whenever its off cd and you have gauge for it on main combo.", NIN.JobID, 0, "What do you call a Viera that's been cut off at the knees?", "Bun-shin KEK")]
        NinjaBunshinFeature = 10016,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("BavacakraOnMainCombo", "Adds Bavacakra you have gauge for it on main combo.", NIN.JobID, 0, "BAKLAVA!", "BAKLAVA!")]
        NinjaBhavacakraFeature = 10017,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("飞刀 Uptime Feature", "Replace Aeolian Edge with 飞刀s when targer is our of range.", NIN.JobID, 0, "", "Would probably make more sense for NIN to be a Ranged DPS, anyway.")]
        NinjaRangedUptimeFeature = 10018,

        [CustomComboInfo("Simple Mudras", "Simplify the mudra casting to avoid failing.", NIN.JobID, 0, "Simple Murder", "Murder, made simple. For the everyday user.")]
        NinjaSimpleMudras = 10020,

        [ParentCombo(NinjaTCJMeisuiFeature)]
        [CustomComboInfo("天之印 Chi Jin Feature", "Turns 天之印 Chi Jin (the move) into 天之印, 地之印, and 人之印.", NIN.JobID, 0, "", "Does literally nothing. Ever")]
        NinTCJFeature = 10021,

        [ConflictingCombos(NinjaArmorCrushCombo, NinjaAeolianEdgeCombo, NinjaGCDNinjutsuFeature)]
        [CustomComboInfo("Simple Ninja Single Target", "Turns 双刃旋 into a one-button full single target rotation.\nUses Ninjitsus, applies 攻其不备 and uses Armor Crush to upkeep Huton buff.\nConflicts with a lot of features. Please only use this and the AoE version and disable all other Ninja features.", NIN.JobID, 0, "", "")]
        NinSimpleSingleTarget = 10022,

        [CustomComboInfo("Simple Ninja AoE", "Turns 血雨飞花 into a one-button full AoE rotation.\nApplies Doton but will only use Ninjitsus if under the effect of Kassatsu or have 2 charges to ensure more Doton uptime.", NIN.JobID, 0, "Dote-on AoE", "Uses /dote on every target.")]
        NinSimpleAoE = 10023,

        [ParentCombo(NinSimpleSingleTarget)]
        [CustomComboInfo("Include 攻其不备", "Add or disable 攻其不备 as part of the feature.", NIN.JobID, 0, "Surprise!", "It's like the Uno Reverse card of XIV!")]
        NinSimpleTrickFeature = 10024,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("断绝/Dream Within a Dream Feature", "Adds 断绝 and Dream Within a Dream to the combo.", NIN.JobID, 0, "Fever Dream", "Frothinig at the mouth")]
        NinAeolianAssassinateFeature = 10025,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("夺取 Feature", "Adds 夺取 to the combo.", NIN.JobID, 0, "Petty Theft", "Embarrassing.")]
        NinAeolianMugFeature = 10026,

        [ParentCombo(NinSimpleTrickFeature)]
        [CustomComboInfo("生杀予夺 for Suiton Feature", "Allows the use of 生杀予夺 to set up Suiton. Suiton is prioritised above Hyosho Ranryu under this effect \nand your trick cooldown window has elapsed.", NIN.JobID)]
        NinSimpleTrickKassatsuFeature = 10027,

        [ParentCombo(NinSimpleAoE)]
        [CustomComboInfo("通灵之术·大虾蟆 Feature", "Adds 通灵之术·大虾蟆 to the combo if you have Ninki to spend.", NIN.JobID)]
        NinSimpleHellfrogFeature = 10028,

        [ParentCombo(NinSimpleAoE)]
        [CustomComboInfo("Mudra Feature", "Adds Doton and Katon/劫火灭却之术 to the combo.", NIN.JobID)]
        NinSimpleAoeMudras = 10029,

        [ParentCombo(NinSimpleAoE)]
        [CustomComboInfo("分身之术 Feature", "Adds 分身之术 and Phantom Kamaitachi to the combo.", NIN.JobID)]
        NinSimpleAoeBunshin = 10030,

        #endregion
        // ====================================================================================
        #region PALADIN

        [CustomComboInfo("沥血剑 Combo", "Replace 沥血剑 with its combo chain.", PLD.JobID, 0, "These aren't heals... huh?", "Just take the armour off and don a robe, we all know you're green on the inside.")]
        PaladinGoringBladeCombo = 11000,

        [CustomComboInfo("王权剑 Combo", "All-in-one main combo adds 王权剑/战女神之怒.\nToggle all sub-options on to make this a 1 button rotation", PLD.JobID, 0, "", "Lmao, 'Authority'... If you say so, buddy.")]
        PaladinRoyalAuthorityCombo = 11001,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinAtonementTestFeature)]
        [CustomComboInfo("赎罪剑 Feature", "Replace 王权剑 with Atonement when under the effect of Sword Oath. \nDoes not drop last Atonement stack.", PLD.JobID, 1, "", "赎罪剑 for what? Picking the weakest Tank?")]
        PaladinAtonementFeature = 11002,

        [CustomComboInfo("日珥斩 Combo", "Replace 日珥斩 with its combo chain.", PLD.JobID, 0, "Promenade feature", "Long walks on the promenade...")]
        PaladinProminenceCombo = 11003,

        [ParentCombo(PaladinReqMainComboFeature)]
        [CustomComboInfo("圣灵 Feature", "Replace 王权剑/沥血剑 combo with 圣灵 and Prominence combo with 圣环 while Requiescat is active", PLD.JobID, 0, "Auto-PLD", "出卡s the whole job for you.\nJust stand there and take damage, right?")]
        PaladinRequiescatFeature = 11004,

        [ParentCombo(PaladinReqMainComboFeature)]
        [CustomComboInfo("悔罪 Combo Feature", "Replace 圣灵/圣环 with Confiteor when Requiescat is up and MP is under 2000 or only one stack remains \nand adds Faith/Truth/Valor Combo after Confiteor.", PLD.JobID, 0, "Confetti Feature", "This is gonna be a nightmare to clean up.")]
        PaladinConfiteorFeature = 11005,

        [CustomComboInfo("Scornful Spirits Feature", "Replace Spirits Within and 厄运流转 with whichever is available soonest.", PLD.JobID, 0, "", "Two for the price of one!")]
        PaladinScornfulSpiritsFeature = 11006,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [CustomComboInfo("沥血剑 Feature", "Insert 沥血剑 into the main combo when appropriate.", PLD.JobID, 0, "", "")]
        PaladinRoyalGoringOption = 11007,

        [CustomComboInfo("Standalone 圣灵 Feature", "Replaces 圣灵 with Confiteor and Confiteor combo", PLD.JobID, 0, "", "It's Christmas already?")]
        PaladinStandaloneHolySpiritFeature = 11008,

        [CustomComboInfo("Standalone 圣环 Feature", "Replaces 圣环 with Confiteor and Confiteor combo", PLD.JobID, 0, "", "This is MY circle.")]
        PaladinStandaloneHolyCircleFeature = 11009,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinInterveneFeatureOption)]
        [CustomComboInfo("调停 Feature (All Stacks)", "Adds intervene onto main combo whenever its available (Uses all stacks).", PLD.JobID, 4, "", "It looks like a gap-closer. It smells like a gap-closer...")]
        PaladinInterveneFeature = 11010,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinInterveneFeature)]
        [CustomComboInfo("调停 Feature (Leaves 1 stack)", "Adds intervene onto main combo whenever its available (Leaves 1 stack).", PLD.JobID, 4, "", "It must be a gap-closer!")]
        PaladinInterveneFeatureOption = 11011,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinRangedUptimeFeature2)]
        [CustomComboInfo("Uptime Feature", "Replace Main Combo with 投盾 when out of range.", PLD.JobID, 4, "", "Don't throw your shield, you're not Captain America.\nJust get close!")]
        PaladinRangedUptimeFeature = 11012,

        [ParentCombo(PaladinFightOrFlightMainComboFeature)]
        [ConflictingCombos(PaladinFightOrFlightFeature)]
        [CustomComboInfo("战逃反应", "Adds FoF onto the main combo (Testing).", PLD.JobID, 0, "", "What is this, P3S?")]
        PaladinFightOrFlightMainComboFeature = 11013,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [CustomComboInfo("安魂祈祷 Feature", "Adds 安魂祈祷 onto the main combo (Testing).", PLD.JobID, 2, "", "Just defend 4hed")]
        PaladinReqMainComboFeature = 11014,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinAtonementFeature/*, SkillCooldownRemaining*/)]
        [CustomComboInfo("赎罪剑 Drop Feature", "Drops 赎罪剑 to prevent Potency loss on lvl 90 rotation.", PLD.JobID, 1, "Anti-Atonement 导弹", "Imagine worrying about potency loss when you play a job like this. Couldn't be me!")]
        PaladinAtonementTestFeature = 11015,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinRangedUptimeFeature)]
        [CustomComboInfo("圣灵 Uptime Feature", "Replace 王权剑/战女神之怒 Feature with Holy Spirit when out of range.", PLD.JobID, 5, "(Un)神圣 Halone", "Who is Halone and why are they so angry?")]
        PaladinRangedUptimeFeature2 = 11016,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [CustomComboInfo("战逃反应 Feature (Custom Values) ", "Adds FoF onto the main combo. You can input your own gcd value (Value represtents percentage of your GCD, 1 = Full GCD).\nIf unsure put low on 0.250 and high on 0.750.", PLD.JobID, 2, "", "This feature hurts my brain. Yours too, no doubt")]
        PaladinFightOrFlightFeature = 11017,

        //[ParentCombo(PaladinRoyalAuthorityCombo)]
        //[ConflictingCombos(PaladinAtonementFeature, PaladinAtonementTestFeature)]
        //[CustomComboInfo("赎罪剑 Drop Feature (Custom Value Test)", "Drops 赎罪剑 to prevent Potency loss when FoF is about to expire.", PLD.JobID, 0, "", "Clumsy-ass dropped the 赎罪剑 again")]
        //SkillCooldownRemaining = 11018,

        [CustomComboInfo("Interrupt Feature", "Replaces 盾牌猛击 with Interject when target can be interrupted or Low Blow if it's off cooldown. .", PLD.JobID, 0, "Lower blow", "Blow, but low.")]
        PaladinInterruptFeature = 11019,

        [ParentCombo(PaladinProminenceCombo)]
        [CustomComboInfo("圣环 Feature", "Replaces AoE combo with 圣环 when Requiescat is active.", PLD.JobID, 1, "", "")]
        PaladinHolyCircleFeature = 11020,

        [ParentCombo(PaladinProminenceCombo)]
        [CustomComboInfo("AoE 悔罪 Feature", "Replaces AoE combo with Confiteor when 安魂祈祷 is active and appropiate.", PLD.JobID, 2, "", "")]
        PaladinAoEConfiteorFeature = 11021,

        [ParentCombo(PaladinProminenceCombo)]
        [CustomComboInfo("AoE 安魂祈祷 Feature", "Replaces AoE combo with 安魂祈祷 when it's off cooldown.\nProbably not optimal at all.", PLD.JobID, 0, "", "")]
        PaladinReqAoEComboFeature = 11022,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [CustomComboInfo("Expiacion and 厄运流转 Feature", "Adds Expiacion and 厄运流转 onto the main combo during weave windows", PLD.JobID, 0, "", "")]
        PaladinExpiacionScornFeature = 11023,

        [ParentCombo(PaladinProminenceCombo)]
        [CustomComboInfo("AOE Expiacion / 厄运流转 Feature", "Adds Expiacion and 厄运流转 onto the main AOE combo during weave windows", PLD.JobID, 0, "", "")]
        PaladinAoEExpiacionScornFeature = 11024,

        [CustomComboInfo("Double Reprisal Protection", "Prevents the use of Reprisal when target already has the effectby replacing it with 飞石", PLD.JobID)]
        PaladinReprisalProtection = 11030,

        #endregion
        // ====================================================================================
        #region REAPER

        // Single Target Combo Section
        [CustomComboInfo("切割 Combo Feature", "Replace 切割 with its combo chain. Features and options inside.\nCollapsing this category disables the features inside.", RPR.JobID, 0, "One, Two, Three", "It's a slicer's life for me~")]
        ReaperSliceCombo = 12000,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Soul 切割 Option", "Adds Soul 切割 to 切割 Combo when Soul Gauge is 50 or less, and target is under Death's Design debuff.", RPR.JobID, 0, "", "FETCH ME THEIR SOULS...")]
        ReaperSoulSliceFeature = 12001,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Shadow Of Death Option", "Adds Shadow of Death to 切割 Combo if debuff is not present or is about to expire.", RPR.JobID, 0, "DoB - Damage over Brain", "Already using all of your brain on positionals? Look no further!")]
        ReaperShadowOfDeathFeature = 12002,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Stun Option", "Adds Leg Sweep to main combo when target is performing an interruptible cast i.e. uses stun as an interrupt.", RPR.JobID, 0, "ZAP", "The male was too stunned to speak")]
        ReaperStunOption = 12003,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the combo at 65 and 40 percent HP, respectively.", RPR.JobID, 0, "Pretend 出卡 Heals", "Look mom, I'm a White Mage!")]
        ReaperComboHealsOption = 12004,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Ranged Filler Option", "Replaces the combo chain with 勾刃 (or Harvest Moon, if available) when outside of melee range. Will not override 团契.", RPR.JobID, 0, "Stretch Armstrong", "Can't quite reach? Here.")]
        ReaperRangedFillerOption = 12005,


        // AoE Combo Section
        [CustomComboInfo("Scythe Combo Feature", "Replace 旋转钐割 with its combo chain. Features and options inside.\nCollapsing this category disables the features inside.", RPR.JobID, 0, "One, Two, Th-", "Oh. It's barely a combo!")]
        ReaperScytheCombo = 12010,

        [ParentCombo(ReaperScytheCombo)]
        [CustomComboInfo("灵魂钐割 Option", "Adds 灵魂钐割 to Scythe Combo when Soul Gauge is 50 or less, and target is under Death's Design debuff.", RPR.JobID, 0, "", "I've made the CoD Zombies joke too many times, but I'm too tired to think of anything else.\nSorry!")]
        ReaperSoulScytheFeature = 12011,

        [ParentCombo(ReaperScytheCombo)]
        [CustomComboInfo("Whorl Of Death Option", "Adds 死亡之涡 to Scythe Combo if debuff is not present or is about to expire.", RPR.JobID, 0, "DoB - Damage over Brains", "Already using all of your brain-cells on positionals? Look no further!")]
        ReaperWhorlOfDeathFeature = 12012,


        // Gibbet, Gallows, Guillotine Combo Section
        [CustomComboInfo("[Unveiled Features]", "Features and options involving 绞决, 缢杀 and Guillotine.\nCollapsing this category does NOT disable the features inside.", RPR.JobID, 0, "Gubbins, Gibberish and Globular", "They all do the same thing, really.")]
        ReaperMenuUnveiledFeatures = 12020,

        [ParentCombo(ReaperMenuUnveiledFeatures)]
        [ConflictingCombos(ReaperGibbetGallowsInverseFeature)]
        [CustomComboInfo("绞决/Gallows Feature", "切割 and Shadow of Death are replaced with Gibbet and Gallows while Soul Reaver or Shroud is active.", RPR.JobID, 0, "Drown in FX!", "Now with even less buttons!")]
        ReaperGibbetGallowsFeature = 12021,

        [ParentCombo(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("绞决/Gallows One-Button Option", "切割 is instead replaced with whichever move is procced, and 死亡之影 remains untouched.", RPR.JobID, 0, "Gubbins/Gibberish One-Button Option", "Positionals were SO last patch, anyway.")]
        ReaperGibbetGallowsOption = 12022,

        [ParentCombo(ReaperMenuUnveiledFeatures)]
        [ConflictingCombos(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("Gallows/绞决 (Inverse) Feature - BROKEN (Currently same effect as above)", "切割 and Shadow of Death are replaced with Gallows and Gibbet while Soul Reaver or Shroud is active.\n(Positional replacements swapped)", RPR.JobID, 0, "BoRkEd", "Don't use this bruh, you KNOW it's broken.\nShit the bed!")]
        ReaperGibbetGallowsInverseFeature = 12023,

        [ParentCombo(ReaperMenuUnveiledFeatures)]
        [CustomComboInfo("断首 Feature", "旋转钐割's combo gets replaced with Guillotine while Soul Reaver or Shroud is active.", RPR.JobID, 0, "", "As if this job wasn't the easiest Melee already. You're welcome, little sloth.")]
        ReaperGuillotineFeature = 12024,


        // Blood Stalk, Grim Swathe, Gluttony Combo Section
        [CustomComboInfo("[Soul Reaver Features]", "Features and options involving 隐匿挥割, 束缚挥割 and Gluttony.\nCollapsing this category does NOT disable the features inside.", RPR.JobID, 0, "Grass Farmer Features", "oGCDs? You betcha")]
        ReaperMenuSoulReaverFeatures = 12030,

        [ParentCombo(ReaperMenuSoulReaverFeatures)]
        [ConflictingCombos(ReaperBloodStalkComboFeature, ReaperBloodStalkAlternateComboOption, ReaperGrimSwatheComboFeature)]
        [CustomComboInfo("隐匿挥割/Grim Swathe Feature", "When 暴食 is off-cooldown, 隐匿挥割 and Grim Swathe will turn into Gluttony.", RPR.JobID, 0, "Buttony", "It's like the normal buttons, but better! Double the fun!")]
        ReaperBloodSwatheFeature = 12031,

        [ParentCombo(ReaperMenuSoulReaverFeatures)]
        [ConflictingCombos(ReaperBloodSwatheFeature, ReaperBloodStalkAlternateComboOption)]
        [CustomComboInfo("隐匿挥割 Multi-Combo Feature", "Turns Blood Stalk into Gluttony when off-cooldown and puts 绞决 and Gallows on the same button as Blood Stalk. Also adds Enshrouded Combo.", RPR.JobID, 0, "", "出卡 the job properly u stinker!")]
        ReaperBloodStalkComboFeature = 12032,

        [ParentCombo(ReaperMenuSoulReaverFeatures)]
        [ConflictingCombos(ReaperBloodSwatheFeature, ReaperBloodStalkComboFeature)]
        [CustomComboInfo("隐匿挥割 Multi-Combo Feature Alternative - Same but better (?)", "Turns Blood Stalk into Gluttony when off-cooldown and puts 绞决 and Gallows on the same button as Blood Stalk. Also adds Enshrouded Combo.\n[Seems like the code is more effective in edge cases. Both features need further review.", RPR.JobID, 0, "", "You heard me the first time!")]
        ReaperBloodStalkAlternateComboOption = 12033,

        [ParentCombo(ReaperMenuSoulReaverFeatures)]
        [ConflictingCombos(ReaperBloodSwatheFeature)]
        [CustomComboInfo("束缚挥割 Multi-Combo Feature", "Turns Grim Swathe into Gluttony when off-cooldown and puts 断首 on the same button as Grim Swathe. Also adds Enshrouded Combo.", RPR.JobID, 0, "", "I SAID - 出卡 the job u stinker!!!!")]
        ReaperGrimSwatheComboFeature = 12034,


        // Enshroud Combo Section
        [CustomComboInfo("[夜游魂衣 Features]", "Features and options involving the 夜游魂衣ed burst phase.\nCollapsing this category does NOT disable the features inside.", RPR.JobID, 0, "Edgelord mode", "Devil May Cry reboot when?")]
        ReaperMenuEnshroudFeatures = 12040,

        [ParentCombo(ReaperMenuEnshroudFeatures)]
        [CustomComboInfo("Lemure Feature", "When you have two or more stacks of Void Shroud, Lemure 切割 replaces Gibbet/Gallows and Lemure Scythe replaces Guillotine.", RPR.JobID, 0, "One-button farming burst", "Who is Lemure and what do they want?")]
        ReaperLemureFeature = 12041,

        [ParentCombo(ReaperMenuEnshroudFeatures)]
        [CustomComboInfo("Combo 团契 Feature", "When one stack of Lemure Shroud remains, Communio replaces 绞决/Gallows/Guillotine.", RPR.JobID, 0, "", "They say strong communio is the key to a healthy relationship")]
        ReaperComboCommunioFeature = 12042,

        [ParentCombo(ReaperMenuEnshroudFeatures)]
        // [ConflictingCombos(ReaperEnshroudComboFeature)]
        [CustomComboInfo("夜游魂衣 Communio Feature", "Replace 夜游魂衣 with Communio when 夜游魂衣ed.", RPR.JobID, 0, "", "Go on, press it as soon as you enter 夜游魂衣.\nI dare you. Dingus.")]
        ReaperEnshroudCommunioFeature = 12043,

        // [ParentCombo(ReaperMenuEnshroudFeatures)]
        // [ConflictingCombos(ReaperEnshroudCommunioFeature)]
        // [CustomComboInfo("夜游魂衣 One-Button Single Target Combo - DOESN'T EXIST YET", "Turns 夜游魂衣 into Void/Cross Reaping, weaves Lemure 切割 and finishes with Communio.", RPR.JobID)]
        // ReaperEnshroudComboFeature = 12044,


        // Miscellaneous Combo Section
        [CustomComboInfo("[Extra Features]", "Miscellaneous features and options.\nCollapsing this category does NOT disable the features inside.", RPR.JobID, 0, "M O R E", "More? Haven't we made this job easy enough already?")]
        ReaperMenuExtraFeatures = 12050,

        [ParentCombo(ReaperMenuExtraFeatures)]
        [CustomComboInfo("神秘环 Harvest Feature", "Replace Arcane Circle with 大丰收 when you have stacks of Immortal Sacrifice.", RPR.JobID, 0, "Farming Simulator 2022", "You might as well buy a tractor at this point")]
        ReaperHarvestFeature = 12051,

        [ParentCombo(ReaperMenuExtraFeatures)]
        [CustomComboInfo("回退 Feature", "Both 地狱入境 and Hell's Egress turn into Regress when Threshold is active, instead of just the opposite of the one you used.", RPR.JobID, 0, "You're a DRG now, son", "GO WHENCE YOU CAME")]
        ReaperRegressFeature = 12052,

        [ParentCombo(ReaperMenuExtraFeatures)]
        [CustomComboInfo("勾刃 Soulsow Feature", "Changes 勾刃 into Soulsow when you are out of combat or have no target, and are not already under the effect of 播魂种.", RPR.JobID, 0, "", "Gotta have something to do before the pull, right?")]
        ReaperHarpeSoulsowFeature = 12053,

        [ParentCombo(ReaperMenuExtraFeatures)]
        [CustomComboInfo("勾刃 Harvest Moon Feature", "Changes 勾刃 into Harvest Moon when you are in combat with Soulsow active.", RPR.JobID, 0, "Dumb reaper be dumb", "Good luck finding the best place to use this kek")]
        ReaperHarpeHarvestMoonFeature = 12054,

        [ParentCombo(ReaperHarpeHarvestMoonFeature)]
        [CustomComboInfo("Enhanced 勾刃 Option", "Prevent Harvest Moon replacing Harpe when Enhanced Harpe is active.\nThis option also affects the Ranged Filler Option for the 切割 Combo Feature.", RPR.JobID, 0, "", "Look at me, all SMN-like and that")]
        ReaperHarpeHarvestMoonEnhancedOption = 12055,

        [ParentCombo(ReaperHarpeHarvestMoonFeature)]
        [CustomComboInfo("Combat 勾刃 Option", "Prevent Harvest Moon replacing Harpe when you are not in combat.\nThis option also affects the Ranged Filler Option for the 切割 Combo Feature.", RPR.JobID, 0, "", "OoOoH uNaSpEcTeD dAmAgE")]
        ReaperHarpeHarvestMoonCombatOption = 12056,

        #endregion
        // ====================================================================================
        #region RED MAGE

        [ConflictingCombos(RedMageSmartcastAoECombo)]
        [CustomComboInfo("Red Mage AoE Combo", "Replaces Veraero/赤闪雷 2 with Impact when Dualcast or Swiftcast are active.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageAoECombo = 13000,

        [CustomComboInfo("连攻 combo", "Replaces 连攻 with its combo chain, following enchantment rules.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageMeleeCombo = 13001,

        [CustomComboInfo("连攻 Combo Plus", "Replaces 连攻 with Verflare/Verholy after Enchanted 连攻, whichever is more appropriate.\nRequires 连攻 Combo.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageMeleeComboPlus = 13002,

        [ConflictingCombos(RedMageSmartSingleTargetCombo, RedMageJoltVerprocCombo)]
        [CustomComboInfo("Verproc into 摇荡", "Replaces Verstone/Verfire with 摇荡/Scorch when no proc is available.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageVerprocCombo = 13003,

        [ConflictingCombos(RedMageSmartSingleTargetCombo)]
        [CustomComboInfo("Verproc into 摇荡 Plus", "Additionally replaces Verstone/Verfire with Veraero/Verthunder if dualcast/swiftcast are up.\nRequires Verproc into 摇荡.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageVerprocComboPlus = 13004,

        [ConflictingCombos(RedMageSmartSingleTargetCombo)]
        [CustomComboInfo("Verproc into 摇荡 Plus Opener Feature", "Turns Verfire into Verthunder when out of combat.\nRequires Verproc into 摇荡 Plus.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageVerprocOpenerFeature = 13005,

        [CustomComboInfo("Resolution Feature", "Adds Resolution finisher to 赤闪雷/Verareo Combo ", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedmageResolutionFinisher = 13006,

        [CustomComboInfo("Resolution Feature Melee", "Adds Resolution finisher to melee combo ", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedmageResolutionFinisherMelee = 13007,

        [ConflictingCombos(RedMageAoECombo)]
        [CustomComboInfo("Smart AoE Feature", "Replaces 赤闪雷 II With Veraero II and impact depending on mana", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageSmartcastAoECombo = 13008,

        [ConflictingCombos(RedMageVerprocComboPlus, RedMageVerprocOpenerFeature, RedMageVerprocCombo, RedMageJoltVerprocCombo)]
        [CustomComboInfo("Smart Single Target Feature", "Smart Single target feature Credit: PrincessRTFM", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageSmartSingleTargetCombo = 13009,

        [CustomComboInfo("oGCD Feature", "Replace Contre Strike and 飞刺 with whichever is available soonest.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageOgcdCombo = 13010,

        [CustomComboInfo("Smart抛竿 Opener Feature", "赤闪雷 Opener Feature. Allows you to prepull with verthunder and still let the combo balance the mana for you", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageVerprocOpenerSmartCastFeature = 13011,

        [ParentCombo(RedMageSmartcastAoECombo)]
        [CustomComboInfo("Red Mage AoE Finisher", "Adds Finishers onto Moulinet and Smart抛竿 AoE Feature.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageMeleeAoECombo = 13012,

        [CustomComboInfo("交剑 Feature", "Adds 交剑 in all melee combos. (Testing Only!)", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageEngagementFeature = 13013,

        [CustomComboInfo("Simple Red Mage Feature Single Target", "Combines Smartcast feature with melee combo on 赤飞石,赤火炎 or melee skills (This is not optimal until i find a solution for distance delay)", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        SimpleRedMage = 13014,

        [CustomComboInfo("Simple Red Mage Feature AoE", "Combines Smartcast AoE feature with melee AoE combo on 赤闪雷2/Veraero2 (This is not optimal until i find a solution for distance delay)", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        SimpleRedMageAoE = 13015,

        [CustomComboInfo("Corps-A-corps/移转 Feature", "Corps-A-corps becomes displacement when in melee range", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageMovementFeature = 13016,

        [ParentCombo(RedMageOgcdCombo)]
        [CustomComboInfo("oGCD Feature Everywhere", "Adds oGCD Feature to all other combos", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageOgcdComboOnCombos = 13017,

        [ParentCombo(SimpleRedMage)]
        [CustomComboInfo("Verstone/赤火炎 Activation", "Add 促进 and Swiftcast to Simple Red Mage to force activation of verstone or verfire effects when necessary.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        SimpleRedMageFishing = 13018,

        [ParentCombo(SimpleRedMageFishing)]
        [CustomComboInfo("促进 only", "Only use 促进 to force verfire or verstone activations.", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        SimpleRedMageAccelOnlyFishing = 13019,

        [ParentCombo(SimpleRedMage)]
        [ConflictingCombos(RedMageVerprocOpenerSmartCastFeature)]
        [CustomComboInfo("Simple opener", "Do the optimal opener. [lv90 only]", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        SimpleRedMageOpener = 13020,

        [ConflictingCombos(RedMageSmartSingleTargetCombo, RedMageVerprocCombo)]
        [CustomComboInfo("摇荡 into Verproc", "Replaces 摇荡 with Verstone/Verfire, when proc is available and won't cause severe imbalance", RDM.JobID, 0, "Swiftcast -> 赤复活", "Ah look, it's what you were always meant to do")]
        RedMageJoltVerprocCombo = 13021,

        [CustomComboInfo("Lucid Dreaming Feature", "Add Lucid Dreaming to 赤疾风, 赤闪雷 and Impact when below threshold.", RDM.JobID, 0, "Veraero / 赤闪雷 / Impact -> Lucid Dreaming", "OOM? Git gud.")]
        RedMageLucidOnJolt = 13022,

        [CustomComboInfo("Swiftcast into 赤复活 Feature", "Changes Swiftcast to 赤复活 when under the effect of Swiftcast.", RDM.JobID, 0, "Swifty 赤复活", "You're panicing right now, aren't you?")]
        RedMageSwiftVerraise = 13023,

        #endregion
        // ====================================================================================
        #region SAGE

        [CustomComboInfo("Soteria into 心关 Feature", "Soteria turns into 心关 when not active or Soteria is on-cooldown.", SGE.JobID, 0, "Spoopy into Kpoopy", "Don't forget your danc- uh, heal partner!")]
        SageKardiaFeature = 14000,

        [CustomComboInfo("根素 Feature###SGENormal", "Replaces 白牛清汁, 灵橡清汁, Ixochole and 坚角清汁 with Rhizomata when Addersgall is empty.", SGE.JobID, 0, "根素to", "Can't quite manage that gauge? Neither can we.")]
        SageRhizomataFeature = 14001,

        [CustomComboInfo("Taurochole into 灵橡清汁 Feature", "Replaces Taurochole with 灵橡清汁 when Taurochole is on cooldown.", SGE.JobID, 0, "This for that", "They do the same thing, really. If you close your eyes.")]
        SageTauroDruoFeature = 14002,

        [CustomComboInfo("发炎 into X Feature", "Does nothing on it's own, must choose any/all sub-features!", SGE.JobID, 0, "", "发炎balls.")]
        SagePhlegmaFeature = 14031,

            [ParentCombo(SagePhlegmaFeature)]
            [CustomComboInfo("发炎 into Toxikon Feature", "发炎 turns into Toxikon when you are out of 发炎 charges and have Addersting.\nTakes priority over the 发炎 into Dyskrasia Feature.", SGE.JobID, 0, "", "Changes 发炎 to Toxikon, purely because the name is awful.")]
            SagePhlegmaToxikonFeature = 14003,

            [ParentCombo(SagePhlegmaFeature)]
            [CustomComboInfo("发炎 into Dyskrasia Feature", "发炎 turns into Dyskrasia when you are out of charges.", SGE.JobID, 0, "", "Again, 发炎 is the worst skill name in the game. GET RID!")]
            SagePhlegmaDyskrasiaFeature = 14004,

        [CustomComboInfo("注药 DPS Feature", "Adds Eukrasia and Eukrasian 注药 on one combo button.", SGE.JobID, 0, "", "Oh look, you're basically WHM now!")]
        SageDPSFeature = 14005,

            [ParentCombo(SageDPSFeature)]
            [CustomComboInfo("Fine Tune 注药", "Input some values to your liking.", SGE.JobID, 0, "", "NERD")]
            SageDPSFeatureAdvTest = 14009,

            [ParentCombo(SageDPSFeature)]
            [CustomComboInfo("Lucid Dreaming Option", "Adds Lucid Dreaming into the 注药 DPS feature at slider value or less.", SGE.JobID, 0, "Muh piety", "Never run out of steam!")]
            SageLucidFeature = 14006,

        [ConflictingCombos(SageAlternateEgeiroFeature)]
        [CustomComboInfo("Swiftcast into 复苏 Feature", "Changes Swiftcast to 复苏 when under the effect of Swiftcast.", SGE.JobID, 0, "Swiftcast to Swiftcast", "GET BACK TO DOING DAMAGE")]
        SageEgeiroFeature = 14007,

        [ConflictingCombos(SageEgeiroFeature)]
        [CustomComboInfo("复苏 into Swiftcast Feature", "Changes Egiero to Swiftcast when Swiftcast is available.", SGE.JobID, 0, "复活 to 复活", "Swaps your raise with WHM's raise.\nDoesn't work any more. You're welcome")]
        SageAlternateEgeiroFeature = 14008,

        [ConflictingCombos(SageRhizomataFeature, SageTauroDruoFeature)]
        [CustomComboInfo("Sage Single Target Heal Feature", "Changes 天辉gnosis. You must target a party member (including yourself) for some features to work.", SGE.JobID, 0)]
        SageSingleTargetHealFeature = 14011,

        [ConflictingCombos(SageRhizomataFeature, SageTauroDruoFeature)]
        [CustomComboInfo("Sage AoE Heal Feature", "Changes 预后. Customize your AoE healing to your liking", SGE.JobID, 0)]
        SageAoEHealFeature = 14012,

        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("Apply 心关", "Applies 心关 to your target if it's not applied to anyone else.", SGE.JobID, 0)]
        AutoApplyKardia = 14013,

        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("Eukrasian 天辉gnosis Feature", "天辉gnosis becomes Eukrasian 天辉gnosis if the shield is not applied to the target.", SGE.JobID, 0)]
        CustomEukrasianDiagnosisFeature = 14014,

        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("Custom 拯救 Feature", "Applies 拯救 when the selected target is at or above the set HP percentage.", SGE.JobID, 0)]
        CustomSoteriaFeature = 14015,
        
        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("Custom 活化 Feature", "Applies 活化 when the selected target is at or above the set HP percentage.", SGE.JobID, 0)]
        CustomZoeFeature = 14016,

        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("Custom 消化 Feature", "Triggers 消化 if a shield is present and the selected target is at or above the set HP percentage.", SGE.JobID, 0)]
        CustomPepsisFeature = 14017,

        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("Custom 白牛清汁 Feature", "Adds 白牛清汁 when the selected target is at or above the set HP percentage.", SGE.JobID, 0)]
        CustomTaurocholeFeature = 14018,

        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("Custom 输血 Feature", "Adds 输血 when the selected target is at or above the set HP percentage.", SGE.JobID, 0)]
        CustomHaimaFeature = 14019,

        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("Custom 根素 Feature###SGEST", "Adds 根素 when Addersgall is 0###SGEST", SGE.JobID, 0)]
        RhizomataFeature = 14020,
        
        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("Custom 混合 Feature", "Applies 混合 when the selected target is at or above the set HP percentage.", SGE.JobID, 0)]
        CustomKrasisFeature = 14021,

        [ParentCombo(SageAoEHealFeature)]
        [CustomComboInfo("自生 Feature", "Adds 自生.", SGE.JobID, 0)]
        PhysisFeature = 14022,

        [ParentCombo(SageAoEHealFeature)]
        [CustomComboInfo("Eukrasian 预后 Feature", "预后 becomes Eukrasian 预后 if the shield is not applied.", SGE.JobID, 0)]
        EukrasianPrognosisFeature = 14023,

        [ParentCombo(SageAoEHealFeature)]
        [CustomComboInfo("整体论 Feature", "Adds 整体论.", SGE.JobID, 0)]
        HolosFeature = 14024,

        [ParentCombo(SageAoEHealFeature)]
        [CustomComboInfo("泛输血 Feature", "Adds 泛输血.", SGE.JobID, 0)]
        PanhaimaFeature = 14025,

        [ParentCombo(SageAoEHealFeature)]
        [CustomComboInfo("消化 Feature", "Triggers 消化 if a shield is present.", SGE.JobID, 0)]
        PepsisFeature = 14026,

        [ParentCombo(SageAoEHealFeature)]
        [CustomComboInfo("寄生清汁 Feature", "Adds 寄生清汁", SGE.JobID, 0)]
        IxocholeFeature = 14027,

        [ParentCombo(SageAoEHealFeature)]
        [CustomComboInfo("坚角清汁 Feature", "Adds 坚角清汁", SGE.JobID, 0)]
        KeracholeFeature = 14028,

        [ParentCombo(SageAoEHealFeature)]
        [CustomComboInfo("根素 Feature###SGEAOE", "Adds 根素 when Addersgall is 0###SGEAOE", SGE.JobID, 0)]
        RhizomataFeatureAoE = 14029,

        [ParentCombo(SageSingleTargetHealFeature)]
        [CustomComboInfo("灵橡清汁 Feature", "Adds 灵橡清汁 when the selected target is at or above the set HP percentage.", SGE.JobID, 0)]
        CustomDruocholeFeature = 14030,
                
        #endregion
        // ====================================================================================
        #region SAMURAI

        [ConflictingCombos(SamuraiSimpleSamuraiFeature)]
        [CustomComboInfo("雪风 Combo", "Replace 雪风 with its combo chain.", SAM.JobID, 0, "Yakuza Combo", "Gang affiliation? Surely not.")]
        SamuraiYukikazeCombo = 15000,

        [ConflictingCombos(SamuraiSimpleSamuraiFeature)]
        [CustomComboInfo("月光 Combo", "Replace 月光 with its combo chain.", SAM.JobID, 0, "Geico Combo", "Fifteen minutes could save you 15% or more on car insurance!")]
        SamuraiGekkoCombo = 15001,

        [ConflictingCombos(SamuraiSimpleSamuraiFeature)]
        [CustomComboInfo("花车 Combo", "Replace 花车 with its combo chain.", SAM.JobID, 0, "Cashman Combo", "Dolla dolla bill, y'all")]
        SamuraiKashaCombo = 15002,

        [CustomComboInfo("满月 Combo", "Replace 满月 with its combo chain.", SAM.JobID, 0, "Mangetout Combo", "EAT IT ALL!")]
        SamuraiMangetsuCombo = 15003,

        [CustomComboInfo("樱花 Combo", "Replace 樱花 with its combo chain.", SAM.JobID, 0, "Okeh Combo", "Okeh")]
        SamuraiOkaCombo = 15004,

        [CustomComboInfo("人之印pu/Shifu Feature", "Replace Meikyo Shisui with 人之印pu or Shifu depending on what is needed.", SAM.JobID, 0, "跳跃up/Sitdown", "Work those glutes.")]
        SamuraiJinpuShifuFeature = 15005,

        [ConflictingCombos(SamuraiIaijutsuTsubameGaeshiFeature)]
        [CustomComboInfo("Tsubame-gaeshi to 居合术", "Replace Tsubame-gaeshi with 居合术 when Sen is empty.", SAM.JobID, 0, "", "You don't know the difference between this one and that one?")]
        SamuraiTsubameGaeshiIaijutsuFeature = 15006,

        [ConflictingCombos(SamuraiIaijutsuShohaFeature)]
        [CustomComboInfo("燕回返 to Shoha", "Replace 燕回返 with Shoha when meditation is 3.", SAM.JobID, 0, "", "Don't worry, neither do we.")]
        SamuraiTsubameGaeshiShohaFeature = 15007,

        [ConflictingCombos(SamuraiTsubameGaeshiIaijutsuFeature)]
        [CustomComboInfo("居合术 to Tsubame-gaeshi", "Replace 居合术 with Tsubame-gaeshi when Sen is not empty.", SAM.JobID, 0, "", "Wait, there's more?")]
        SamuraiIaijutsuTsubameGaeshiFeature = 15008,

        [ConflictingCombos(SamuraiTsubameGaeshiShohaFeature)]
        [CustomComboInfo("居合术 to Shoha", "Replace 居合术 with Shoha when meditation is 3.", SAM.JobID, 0, "", "You WHAT?!")]
        SamuraiIaijutsuShohaFeature = 15009,

        [CustomComboInfo("Shinten to Senei", "Replace 必杀剑·震天 with Senei when its cooldown is up.", SAM.JobID, 0, "", "Kicks you in the shins if Senei is on cooldown")]
        SamuraiSeneiFeature = 15010,

        [CustomComboInfo("Shinten to 照破", "Replace Hissatsu: Shinten with Shoha when 斗气 is full.", SAM.JobID, 0, "", "Kicks you in the shins if 照破 is on cooldown")]
        SamuraiShohaFeature = 15011,

        [CustomComboInfo("Kyuten to Guren", "Replace 必杀剑·九天 with Guren when its cooldown is up.", SAM.JobID, 0, "", "Hey Kyutie!")]
        SamuraiGurenFeature = 15012,

        [CustomComboInfo("Kyuten to 照破 II", "Replace Hissatsu: Kyuten with Shoha II when 斗气 is full.", SAM.JobID, 0, "", "Hey Kyutie 2, Electric Boogaloo!")]
        SamuraiShoha2Feature = 15013,

        [CustomComboInfo("意气冲天 Namikiri Feature", "Replace Ikishoten with Ogi Namikiri and then Kaeshi Namikiri when available.\nIf you have full 斗气 stacks, 意气冲天 becomes Shoha while you have Ogi Namikiri ready.", SAM.JobID, 0, "Sticky-icky-shoten", "Wait, you guys use meditation?")]
        SamuraiIkishotenNamikiriFeature = 15014,

        [ConflictingCombos(SamuraiYukikazeCombo, SamuraiGekkoCombo, SamuraiKashaCombo)]
        [CustomComboInfo("Simple Samurai Single Target", "Every sticker combo on one button (刃风).", SAM.JobID, 0, "Sleepy Samurai", "zzzz....wha?")]
        SamuraiSimpleSamuraiFeature = 15015,

        [CustomComboInfo("Simple Samurai AoE", "Both AoE Combos on same button (On 樱花). Big thanks to Stein121", SAM.JobID, 0, "", "Hardly any buttons in the first place, but we got you. Lazy-ass.")]
        SamuraiSimpleSamuraiAoECombo = 15016,

        [CustomComboInfo("Kaiten Feature Option 1", "Adds Kaiten to Higanbana when it has < 5 seconds remaining.", SAM.JobID, 0, "", "MORE!")]
        SamuraiKaitenFeature1 = 15018,

        [CustomComboInfo("Kaiten Feature Option 2", "Adds Kaiten to 天之印ka Goken.", SAM.JobID, 0, "", "MORE!!")]
        SamuraiKaitenFeature2 = 15019,

        [CustomComboInfo("Kaiten Feature Option 3", "Adds Kaiten to 纷乱雪月花.", SAM.JobID, 0, "", "MORE!!!")]
        SamuraiKaitenFeature3 = 15020,

        [CustomComboInfo("Gyoten Feature", "必杀剑·晓天 becomes Yaten/Gyoten depending on the distance from your target.", SAM.JobID, 0, "Gyoza Feature", "Mm, tasty.")]
        SamuraiYatenFeature = 15021,

        [CustomComboInfo("Kaiten Feature Option 4", "Adds Kaiten when above 20 gauge to OgiNamikiri and OgiNamikiri is ready.", SAM.JobID, 0, "", "MORE!!!!")]
        SamuraiOgiNamikiriFeature = 15022,

        [ConflictingCombos(SamuraiOvercapFeature85)]
        [CustomComboInfo("Samurai Overcap Feature 1", "Adds Senei>Shinten onto main combo at 75 or more Kenki", SAM.JobID, 0, "Wink emoji Overcap Feature 1", "Kinky.")]
        SamuraiOvercapFeature75 = 15023,

        [ConflictingCombos(SamuraiOvercapFeature75)]
        [CustomComboInfo("Samurai Overcap Feature 2", "Adds Senei>Shinten onto main combo at 85 or more Kenki", SAM.JobID, 0, "Wink emoji Overcap Feature 2", "Even more kinky.")]
        SamuraiOvercapFeature85 = 15024,

        [ConflictingCombos(SamuraiOvercapFeatureAoe85)]
        [CustomComboInfo("Samurai AoE Overcap Feature 1", "Adds Guren>Kyuten onto main AoE combos at 75 or more Kenki", SAM.JobID, 0, "Wink emoji Overcap Feature 3", "Kinkier")]
        SamuraiOvercapFeatureAoe75 = 15025,

        [ConflictingCombos(SamuraiOvercapFeatureAoe75)]
        [CustomComboInfo("Samurai AoE Overcap Feature 2", "Adds Guren>Kyuten onto main AoE combos at 85 or more Kenki", SAM.JobID, 0, "Wink emoji Overcap Feature 4", "Kinkiest")]
        SamuraiOvercapFeatureAoe85 = 15026,

        [CustomComboInfo("意气冲天 on combos", "Adds 意气冲天 to most Single Target/AoE combos when at or below 50 Kenki", SAM.JobID, 0, "Gauge pls", "You heard me. Gauge pls")]
        SamuraiIkishotenonmaincombo = 15027,

        [ParentCombo(SamuraiIkishotenNamikiriFeature)]
        [CustomComboInfo("Kaiten On 意气冲天", "Adds Kaiten to 意气冲天 Namikiri Feature", SAM.JobID, 0, "", "MORE!!!!!")]
        SamuraiIkishotenKaitenNamikiriFeature = 15028,



        #endregion
        // ====================================================================================
        #region SCHOLAR

        [CustomComboInfo("Seraph 异想的祥光/Consolation", "Change 异想的祥光 into Consolation when Seraph is out.", SCH.JobID, 0, "", "Stupid little fairy thing")]
        ScholarSeraphConsolationFeature = 16000,

        [CustomComboInfo("ED 以太超流", "Change Energy Drain into 以太超流 when you have no more 以太超流 stacks.", SCH.JobID, 0, "", "Stop trying to pretend you're a SMN. You're not fooling anyone")]
        ScholarEnergyDrainFeature = 16001,

        [ConflictingCombos(SCHAlternateRaiseFeature)]
        [CustomComboInfo("SCH 复活 Feature", "Changes Swiftcast to 复生.", SCH.JobID, 0, "", "Well, at least PF wants you for something")]
        SchRaiseFeature = 16002,

        [ConflictingCombos(SchRaiseFeature)]
        [CustomComboInfo("SCH 复活 Alternate Feature", "Changes 复生 To Swiftcast when Swiftcast is available.", SCH.JobID, 0, "", "Well, this raise stuff and Peloton Extreme, I guess.")]
        SCHAlternateRaiseFeature = 16008,

        [CustomComboInfo("Fairy Feature", "Change every action that requires a fairy into 朝日召唤 if you do not have a fairy summoned.", SCH.JobID, 0, "", "You're really gonna forget? Really?")]
        ScholarFairyFeature = 16004,

        [CustomComboInfo("DPS Feature", "Adds Bio1/Bio2/Biosys to Broil/毁灭 whenever the debuff is not present or about to expire.", SCH.JobID, 0, "", "Pretend something interesting is going on. DPS Routine!")]
        ScholarDPSFeature = 16005,

        [ParentCombo(ScholarDPSFeature)]
        [CustomComboInfo("DPS Feature Buff Option", "Adds 连环计 to the DPS Feature.", SCH.JobID, 0, "", "Raid buffs for everyone!")]
        ScholarDPSFeatureBuffOption = 16006,

        [ParentCombo(ScholarDPSFeature)]
        [CustomComboInfo("DPS Feature Lucid Dreaming Option", "Adds Lucid dreaming to the DPS feature when below set MP value.", SCH.JobID, 0, "", "Nobody's perfect. Maybe this'll help")]
        ScholarLucidDPSFeature = 16007,

        [CustomComboInfo("SCH Extra DPS Feature", "Adds Bio DoT on 毁灭 II. Won't work below level 38", SCH.JobID, 0, "", "People still use 毁灭 2? Shouldn't you be healing or something?")]
        SCHDPSAlternateFeature = 16003,

        #endregion
        // ====================================================================================
        #region SUMMONER

        [ConflictingCombos(SummonerMainComboFeature, SummonerRuinIVMobilityFeature)]
        [CustomComboInfo("Enable Single Target (毁灭1)", "Enables changing Single-Target Combo (毁灭 I).", SMN.JobID, 0, "毁灭 420 Feature", "毁灭ation is come")]
        SummonerMainComboFeatureRuin1 = 16999,

        [ConflictingCombos(SummonerMainComboFeatureRuin1)]
        [CustomComboInfo("Enable Single Target (毁灭III)", "Enables changing Single-Target Combo (毁灭 III).", SMN.JobID, 0, "毁灭 7 Feature", "毁灭ation is come... again?")]
        SummonerMainComboFeature = 17000,

        [CustomComboInfo("Enable AOE", "Enables changing AOE Combo (Tri-Disaster)", SMN.JobID, 0, "", "Can't deal with dungeons on your own? Fear not.")]
        SummonerAOEComboFeature = 17001,

        [CustomComboInfo("Single Target Demi Feature", "Replaces Astral Impulse/Fountain of 火炎 with Enkindle/Deathflare/Rekindle when appropriate.", SMN.JobID, 0, "Demi Dingus Feature", "Can't tell the difference between a Bahamut and a Phoenix?\nWe know.")]
        SummonerSingleTargetDemiFeature = 17002,

        [ParentCombo(SummonerAOEComboFeature)]
        [CustomComboInfo("AOE Demi Feature", "Replaces Astral 核爆/Brand of Purgatory with Enkindle/Deathflare/Rekindle when appropriate.", SMN.JobID, 0, "BRRRR", "Upgrade!")]
        SummonerAOEDemiFeature = 17003,

        [CustomComboInfo("Egi Attacks Feature", "Replaces 毁灭I/毁灭 III (Depending On Enabled Combo) and Tri-Disaster with Egi attacks. Will not work without enabling Single Target and/or AOE.", SMN.JobID, 0, "Eggy-bread", "No idea when you're in burst phase?\nHint: It's all the time, really")]
        SummonerEgiAttacksFeature = 17004,

        [CustomComboInfo("Garuda Slipstream Feature", "Adds Slipstream on 毁灭I/毁灭 III/Tri-disaster.", SMN.JobID, 0, "Slipstream", "2 Fast 2 Furious")]
        SummonerGarudaUniqueFeature = 17005,

        [CustomComboInfo("Ifrit Cyclone Feature", "Adds Crimson Cyclone/Crimson Strike on 毁灭I/毁灭 III/Tri-disaster.", SMN.JobID, 0, "Fists of Fury", "Show MNK how it's done, will ya?")]
        SummonerIfritUniqueFeature = 17006,

        [CustomComboInfo("Titan 山崩 Feature", "Adds Mountain Buster on 毁灭I/毁灭 III/Tri-disaster.", SMN.JobID, 0, "Mountain, BUSTA", "Bring the mountain to Mohammed, as they say")]
        SummonerTitanUniqueFeature = 17007,

        [CustomComboInfo("ED 溃烂爆发", "Change Fester into Energy Drain when our of 以太超流 stacks.", SMN.JobID, 0, "溃烂爆发ing", "溃烂爆发ing? Go take a shower, bro")]
        SummonerEDFesterCombo = 17008,

        [CustomComboInfo("ES 痛苦核爆", "Change Painflare into Energy Siphon when out of 以太超流 stacks.", SMN.JobID, 0, "Old age", "I sometimes get a painflare in my middle-back, too.")]
        SummonerESPainflareCombo = 17009,


        // BONUS TWEAKS
        [CustomComboInfo("Carbuncle Reminder Feature", "Reminds you always to summon Carbuncle by replacing 毁灭 (Carbuncle Summon Reminder Feature).", SMN.JobID, 0, "Rabbit Reminder", "C'mon. You had ONE job.")]
        SummonerCarbuncleSummonFeature = 17010,

        [CustomComboInfo("毁灭 4 On 毁灭3 Combo Feature", "Adds 毁灭4 on main 毁灭I/毁灭III combo feature when there are currently no summons being active.", SMN.JobID, 0, "毁灭 -> 毁灭 -> 毁灭", "毁灭 this, ruin that. Can't you see I'm busy ruining the plugin?!")]
        SummonerRuin4ToRuin3Feature = 17011,

        [CustomComboInfo("毁灭 4 On Tri-disaster Feature", "Adds 毁灭4 on main Tridisaster combo feature when there are currently no summons being active.", SMN.JobID, 0, "", "More 毁灭 this, more ruin that! Now in sharing size!")]
        SummonerRuin4ToTridisasterFeature = 17012,

        [ParentCombo(SummonerEDFesterCombo)]
        [CustomComboInfo("Ruin IV Fester/Pain核爆 Feature", "Change Fester/Pain核爆 into Ruin IV when out of Aetherflow stacks, ED/ES is on cooldown, and 毁灭 IV is up.", SMN.JobID, 0, "溃烂爆发ing Painflare", "Just take some Advil for that, or see the doc?")]
        SummonerFesterPainflareRuinFeature = 17013,

        [ParentCombo(SummonerEDFesterCombo)]
        [CustomComboInfo("Lazy 溃烂爆发 Feature", "Adds ED/溃烂爆发 during (AstralImpulse).\n. Will only ED during Phoenix phase in order to save it 溃烂爆发 for burst in bahamut", SMN.JobID, 0, "I don't read descriptions -", "Why is 溃烂爆发 Not working properly?")]
        SummonerLazyFesterFeature = 17014,

        [ConflictingCombos(SimpleSummonerOption2)]
        [CustomComboInfo("One Button Rotation Feature", "Summoner Single Target One Button Rotation (Single Target) on 毁灭1/毁灭3.(Titan>Garuda>Ifrit) ", SMN.JobID, 0, "", "We'll play the game for you. Shush, now")]
        SimpleSummoner = 17015,

        [CustomComboInfo("One Button AoE Rotation Feature", "Summoner AoE One Button Rotation (AoE) on Tridisaster", SMN.JobID, 0, "", "We'll play the game for you. Shush, now")]
        SimpleAoESummoner = 17016,

        [ParentCombo(SimpleSummoner)]
        [CustomComboInfo("灼热之光 Rotation Option", "Adds 灼热之光 to Simple Summoner Rotation, Single Target", SMN.JobID, 0, "My eyes!", "I can't see!")]
        BuffOnSimpleSummoner = 17017,

        [ParentCombo(SimpleAoESummoner)]
        [CustomComboInfo("灼热之光 AoE Option", "Adds 灼热之光 to Simple Summoner Rotation, AoE", SMN.JobID, 0, "Our Eyes!", "Yay, we're all legally blind!")]
        BuffOnSimpleAoESummoner = 17018,

        [CustomComboInfo("DemiReminderFeature", "Adds Only Demi Summons on 毁灭III (So you can still choose your Egis but never forget to summon Demis) ", SMN.JobID, 0, "Chad Kroeger Demi Feature", "This is how, you remind me, of what I really am")]
        SummonerDemiSummonsFeature = 17019,

        [CustomComboInfo("DemiReminderAoEFeature", "Adds Only Demi Summons on TriDisaster (So you can still choose your Egis but never forget to summon Demis) ", SMN.JobID, 0, "Nickelback Demi Feature", "Oh fuck, the whole band is here! Run!")]
        SummonerDemiAoESummonsFeature = 17020,

        [ConflictingCombos(SummonerMainComboFeatureRuin1)]
        [CustomComboInfo("毁灭 III mobility", "Allows you to cast 毁灭 III while 毁灭 IV is unavailable for mobility reasons. Shows up as 毁灭 I.\nWill break combos with 毁灭 I. Might break combos with 毁灭 IV.", SMN.JobID, 0, "", "Don't you have enough mobility as it is?\nThis isn't Ranged DPS, y'know.")]
        SummonerRuinIVMobilityFeature = 17021,

        [ConflictingCombos(SummonerSwiftcastFeatureIfrit)]
        [CustomComboInfo("Swiftcast Garuda Option", "Always swiftcasts Slipstream if available.", SMN.JobID, 0, "No Raising for me!", "Always slips swiftstream, sometimes")]
        SummonerSwiftcastFeatureGaruda = 17022,

        [ConflictingCombos(SummonerSwiftcastFeatureGaruda)]
        [CustomComboInfo("Swiftcast Ifrit Option", "Always swiftcasts 2nd Ruby Rite if available.", SMN.JobID, 0, "No Raising for you!", "Always cancels the Ifrit phase entirely, doing nothing instead.")]
        SummonerSwiftcastFeatureIfrit = 17023,

        [ConflictingCombos(SimpleSummoner)]
        [CustomComboInfo("One Button Rotation Feature Option2 ", "Same feature as One Button Rotation Feature but Garuda>Titan>Ifrit .", SMN.JobID, 0, "The Egi Shuffle", "You just had to be different, didn't you?")]
        SimpleSummonerOption2 = 17024,

        [CustomComboInfo("Prevent 毁灭4 Waste Feature", "Puts 毁灭4 Above anything if Further毁灭 about to expire and there is no Demi present.", SMN.JobID, 0, "", "Waste not, want not")]
        SummonerRuin4WastePrevention = 17025,

        [CustomComboInfo("Rekindle Feature", "Adds Rekindle onto the main 毁灭1 or 毁灭3 combo. Requires other features to work.", SMN.JobID, 0, "Tinderbox", "Remember making those fires in runescape? Yeah. That.")]
        SummonerRekindlePhoenix = 17026,

        #endregion
        // ====================================================================================
        #region WARRIOR

        [CustomComboInfo("Storms Path Combo", "All in one main combo feature adds 暴风碎/Path. \nIf all sub options and Fell Cleave/Decimate Options are toggled will turn into a full one button rotation (Simple Warrior)", WAR.JobID, 0, "", "Follow the yellow-brick road.")]
        WarriorStormsPathCombo = 18000,

        [CustomComboInfo("Storms Eye Combo", "Replace Storms Eye with its combo chain", WAR.JobID, 0, "", "Ow! My fucking eye!")]
        WarriorStormsEyeCombo = 18001,

        [CustomComboInfo("超压斧 Combo", "Add combos to 超压斧", WAR.JobID, 0, "Underpower", "Bet you wish you had damage like DRK right now, huh")]
        WarriorMythrilTempestCombo = 18002,

        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Warrior Gauge Overcap Feature", "Replace Single target or AoE combo with gauge spender if you are about to overcap and are before a step of a combo that would generate beast gauge", WAR.JobID, 0, "", "Taming the beast... for now.")]
        WarriorGaugeOvercapFeature = 18003,

        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Inner 放生 Feature", "Replace Single target and AoE combo with Fell Cleave/Decimate during Inner 放生", WAR.JobID, 0, "", "释放 your deepest thoughts and feelings upon the party. They'll love it!")]
        WarriorInnerReleaseFeature = 18004,

        [CustomComboInfo("原初的勇猛 Feature", "Replace 原初的勇猛 with Raw intuition when level synced below 76", WAR.JobID, 0, "Nasty-ass Flash", "Jeez. Keep it to yourself.")]
        WarriorNascentFlashFeature = 18005,

        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("动乱 Feature", "Adds 动乱 into maincombo if you have Surging Tempest", WAR.JobID, 0, "", "I use this feature when I'm moving house.")]
        WarriorUpheavalMainComboFeature = 18007,

        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("蛮荒崩裂 Feature", "Replace 原初之魂 and Steel Cyclone with Primal Rend when available (Also added onto Main AoE combo)", WAR.JobID, 0, "", "Going back to our roots. Let's get Primal!")]
        WarriorPrimalRendFeature = 18008,

        [ParentCombo(WarriorMythrilTempestCombo)]
        [CustomComboInfo("群山隆起 Feature", "Adds 群山隆起 onto main AoE combo when you are buffed with Surging Tempest", WAR.JobID, 0, "Orange-y feature", "Orange flavour. Mm.")]
        WarriorOrogenyFeature = 18009,

        [ParentCombo(WarriorStormsPathCombo)]
        [ConflictingCombos(WarriorSpenderOption)]
        [CustomComboInfo("狂魂 option", "Adds Inner Chaos to Storms Path Combo and Chaotic Cyclone to 超压斧 Combo if you are buffed with Nascent Chaos.\nRequires Storms Path Combo and 超压斧 Combo", WAR.JobID, 0, "", "THE EYE OF THE TIGERRRRR")]
        WarriorInnerChaosOption = 18010,

        [ParentCombo(WarriorStormsPathCombo)]
        [ConflictingCombos(WarriorInnerChaosOption)]
        [CustomComboInfo("裂石飞环/Decimate Option", "Adds Fell Cleave to main combo when gauge is at 50 or more and adds Decimate to the AoE combo .\nWill use Inner Chaos/Chaotic Cyclone if 战嚎 is used.\nWill begin pooling resources when Inner Release is under 30s", WAR.JobID, 0, "", "MORE CLEAVE!")]
        WarriorSpenderOption = 18011,

        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("猛攻 Feature", "Adds Onslaught to 暴风斩 feature combo if you are under Surging Tempest Buff", WAR.JobID, 0, "", "猛攻! Full Power!")]
        WarriorOnslaughtFeature = 18012,

        [CustomComboInfo("战嚎 Feature", "Replaces 战嚎 with Fell Cleave when under Inner Release buff.\nReplaces 战嚎 with Inner Chaos When under Nascent Chaos buff", WAR.JobID, 0, "Cleave of annoyance", "Infuriating stuff, if you ask me. Truly chaotic.")]
        WarriorInfuriateFeature = 18015,

        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("飞斧 Uptime Feature", "Replace 暴风斩 Combo Feature with Tomahawk when you are out of range.", WAR.JobID, 0, "飞斧!", "You heard me! 飞斧! Ka-chow!")]
        WARRangedUptimeFeature = 18016,

        [CustomComboInfo("Interrupt Feature", "Replaces Low Blow with Interject when target can be interrupted .", WAR.JobID, 0, "", "That's a low blow to my bro-bro, bro.")]
        WarriorInterruptFeature = 18017,

        [CustomComboInfo("战嚎 on Fell Cleave / Decimate", "Turns Fell Cleave and Decimate into 战嚎 if at or under set rage value", WAR.JobID)]
        WarriorInfuriateFellCleave = 18018,

        [CustomComboInfo("蛮荒崩裂 Option", "Turns Inner 放生 into Primal Rend on use.", WAR.JobID)]
        WarriorPrimalRendOnInnerRelease = 18019,
        
        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Inner Release on 暴风斩", "Adds Inner Release to 暴风斩 Combo when Nascent Chaos is not up.", WAR.JobID)]
        WarriorIRonST = 18020,

        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Infuriate on 暴风斩", "Adds Infuriate to 暴风斩 Combo when gauge is below 50 and not under Inner Release.", WAR.JobID)]
        WarriorInfuriateonST = 18021,

        [CustomComboInfo("Double Reprisal Protection", "Prevents the use of Reprisal when target already has the effectby replacing it with 飞石", WAR.JobID)]
        WarriorReprisalProtection = 18030,

        #endregion
        // ====================================================================================
        #region WHITE MAGE

        [CustomComboInfo("Solace into Misery", "Replaces 安慰之心 with Afflatus Misery when Misery is ready to be used", WHM.JobID, 0, "Misery", "I'd be miserable too if this were one of my DPS options.")]
        WhiteMageSolaceMiseryFeature = 19000,

        [CustomComboInfo("Rapture into Misery", "Replaces 狂喜之心 with Afflatus Misery when Misery is ready to be used", WHM.JobID, 0, "Misery, but with freinds", "Let's cry together!")]
        WhiteMageRaptureMiseryFeature = 19001,

        [CustomComboInfo("治疗 2 to 治疗 Level Sync", "Changes 治疗 2 to 治疗 when below level 30 in synced content.", WHM.JobID, 0, "Weenie 治疗", "Bet you forgot 治疗 1 existed for a sec, huh")]
        WhiteMageCureFeature = 19002,

        [CustomComboInfo("Afflatus Feature", "Changes 治疗 2 into Afflatus Solace, and 医治 into Afflatus Rapture, when lilies are up.", WHM.JobID, 0, "Inflatus Feature", "Pumps you full of air. Boing!")]
        WhiteMageAfflatusFeature = 19003,

        [ConflictingCombos(WHMAlternativeRaise)]
        [CustomComboInfo("WHM 复活 Feature", "Changes Swiftcast to 复活", WHM.JobID, 0, "What you're really here for", "You're the best at this. You got this.")]
        WHMRaiseFeature = 19004,

        [ConflictingCombos(WHMRaiseFeature)]
        [CustomComboInfo("WHM 复活 Feature alternative", "复活 Becomes Swiftcast when Swiftcast is available. Thin air feature also applies to this if enabled.", WHM.JobID, 0, "Look up!", "It's this, but that.")]
        WHMAlternativeRaise = 19015,

        [CustomComboInfo("DoT on 闪耀3 Feature", "Adds DoT on 闪耀3 when DoT is not preset on about to expire and when you are inCombat (You can still prepull 闪耀)", WHM.JobID, 0, "Weak", "WHM DPS rotation too much?")]
        WHMDotMainComboFeature = 19005,

        [ParentCombo(WHMDotMainComboFeature)]
        [CustomComboInfo("Lucid Dreaming Feature", "Adds Lucid dreaming to the DPS feature when below set MP value.", WHM.JobID, 0, "Dream within a Dream", "Awake, yet wholly asleep")]
        WHMLucidDreamingFeature = 19006,

        [CustomComboInfo("医治 Feature", "Replaces 医治2 whenever you are under 医治2 regen with 医治1", WHM.JobID, 0, "Big Brain AoE Heals", "God bless us all, eh")]
        WHMMedicaFeature = 19007,

        [ParentCombo(WHMDotMainComboFeature)]
        [CustomComboInfo("Presence Of Mind Feature", "Adds Presence of mind as oGCD onto main DPS Feature(闪耀3)", WHM.JobID, 0, "", "This would imply you're actually paying attention.")]
        WHMPresenceOfMindFeature = 19008,

        [ParentCombo(WHMDotMainComboFeature)]
        [CustomComboInfo("法令 Feature", "Adds 法令 as oGCD onto main DPS Feature(Glare3)", WHM.JobID, 0, "", "Size 'em up, knock 'em down")]
        WHMAssizeFeature = 19009,

        [ParentCombo(WHMMedicaFeature)]
        [CustomComboInfo("Afflatus Misery On 医治 Feature", "Adds Afflatus Misery onto the 医治 Feature", WHM.JobID, 0, "", "Ah, back to beinig miserable.")]
        WhiteMageAfflatusMiseryMedicaFeature = 19010,

        [ParentCombo(WHMMedicaFeature)]
        [CustomComboInfo("Afflatus Rapture On 医治 Feature", "Adds Afflatus Rapture onto the 医治 Feature", WHM.JobID, 0, "CRapture", "The final days are upon us!")]
        WhiteMageAfflatusRaptureMedicaFeature = 19011,

        [CustomComboInfo("苦难之心 Feature", "Changes 治疗 2 into Afflatus Misery.", WHM.JobID, 0, "", "治疗s? Who needs 'em?")]
        WhiteMageAfflatusMiseryCure2Feature = 19012,

        [ParentCombo(WHMDotMainComboFeature)]
        [CustomComboInfo("Remove DoT From 闪耀3 Feature", "Removes DoT from DPS feature", WHM.JobID, 0, "I'm an idiot", "Yes, one serving of less DPS, please.")]
        WHMRemoveDotFromDPSFeature = 19013,

        [CustomComboInfo("Thin Air 复活 Feature", "Adds Thin Air to the WHM 复活 Feature/Alternative Feature", WHM.JobID, 0, "", "I can hardly breathe as it is!")]
        WHMThinAirFeature = 19014,

        #endregion
        // ====================================================================================
        #region DOH

        // [CustomComboInfo("Placeholder", "Placeholder.", DOH.JobID)]
        // DohPlaceholder = 50001,

        #endregion
        // ====================================================================================
        #region DOL

        [CustomComboInfo("Eureka Feature", "Replace 农夫之智 and Solid Reason with Wise to the World when available.", DOL.JobID)]
        DolEurekaFeature = 51001,

        [CustomComboInfo("抛竿 / Hook Feature", "Replace 抛竿 with Hook when fishing.", DOL.JobID)]
        DolCastHookFeature = 51002,

        [CustomComboInfo("抛竿 / Gig Feature", "Replace 抛竿 with Gig when underwater.", DOL.JobID)]
        DolCastGigFeature = 51003,

        [CustomComboInfo("拍击水面 / Veteran Trade Feature", "Replace 拍击水面 with Veteran Trade when underwater.", DOL.JobID)]
        DolSurfaceTradeFeature = 51004,

        [CustomComboInfo("Prize Catch / 嘉惠 Feature", "Replace Prize Catch with 嘉惠 when underwater.", DOL.JobID)]
        DolPrizeBountyFeature = 51005,

        [CustomComboInfo("钓组 / Salvage Feature", "Replace 钓组 with Salvage when underwater.", DOL.JobID)]
        DolSnaggingSalvageFeature = 51006,

        [CustomComboInfo("抛竿 Light / Electric Current Feature", "Replace 抛竿 Light with Electric Current when underwater.", DOL.JobID)]
        DolCastLightElectricCurrentFeature = 51007,

        #endregion
        // ====================================================================================
        #region PvP Combos

        [SecretCustomCombo]
        [CustomComboInfo("BurstShotFeature", "Adds 影噬箭/EmpyArrow/PitchPerfect(3stacks)/SideWinder(When Target is low hp)/ApexArrow when gauge is 100 all on one button combo.", BRDPvP.JobID)]
        BurstShotFeaturePVP = 80000,

        [SecretCustomCombo]
        [CustomComboInfo("SongsFeature", "Replaces WanderersMinnuet and Peons song all on one button in an optimal order", BRDPvP.JobID)]
        SongsFeaturePVP = 80001,

        [SecretCustomCombo]
        [CustomComboInfo("噬魂斩ComboFeature", "Adds EoS as oGCD onto main combo and 血溅 when at 50 gauge or under delirium buff.", DRKPVP.JobID)]
        SouleaterComboFeature = 80002,

        [SecretCustomCombo]
        [CustomComboInfo("StalwartSoulComboFeature", "Adds FoS as oGCD onto main combo and 寂灭 when at 50 gauge or under delirium buff.", DRKPVP.JobID)]
        StalwartSoulComboFeature = 80003,

        [SecretCustomCombo]
        [CustomComboInfo("StormsPathComboFeature", "Replaces 暴风斩 Combo with FellCleave/IC when at 50 gauge or under IR", WARPVP.JobID)]
        StormsPathComboFeature = 80004,

        [SecretCustomCombo]
        [CustomComboInfo("SteelCycloneFeature", "Replaces 钢铁旋风 Combo with Decimate/CC when at 50 gauge or under IR", WARPVP.JobID)]
        SteelCycloneFeature = 80005,

        [SecretCustomCombo]
        [CustomComboInfo("RoyalAuthorityComboFeature", "Adds 神圣Spirit To the main combo", PLDPVP.JobID)]
        RoyalAuthorityComboFeature = 80006,

        [SecretCustomCombo]
        [CustomComboInfo("日珥斩ComboFeature", "Adds 神圣Circle to the main AoE Combo", PLDPVP.JobID)]
        ProminenceComboFeature = 80007,

        [SecretCustomCombo]
        [CustomComboInfo("GnashingFangComboFeature", "Adds BowShock(When target is meleeRange) and Burststrike at 2 ammo gauge to the main combo", GNBPVP.JobID)]
        SolidBarrelComboFeature = 80008,

        [SecretCustomCombo]
        [CustomComboInfo("DemonSlaughterComboFeature", "Adds BowShock(When target is meleeRange) and 命运之环 at 2 ammo gauge to the main AoE combo", GNBPVP.JobID)]
        DemonSlaughterComboFeature = 80009,

        [SecretCustomCombo]
        [CustomComboInfo("HeatedCleanShotFeature", "Adds Gauss/Rico weave to maincombo", MCHPVP.JobID)]
        HeatedCleanShotFeature = 80010,

        [SecretCustomCombo]
        [CustomComboInfo("野火BlankFeature", "Adds Blank To 野火 if you are in melee Range", MCHPVP.JobID)]
        WildfireBlankFeature = 80011,

        [SecretCustomCombo]
        [CustomComboInfo("Infernal切割ComboFeature", "Adds Gluttony/BloodStalk/Smite/EnshroudComboRotation on Infernal切割Combo", RPRPVP.JobID)]
        InfernalSliceComboFeature = 80012,

        [SecretCustomCombo]
        [CustomComboInfo("NightmareScytheComboFeature", "Adds 暴食/GrimSwathe/Smite/EnshroudComboRotation on InfernalScytheCombo", RPRPVP.JobID)]
        NightmareScytheComboFeature = 80013,

        [SecretCustomCombo]
        [CustomComboInfo("NinjaAeolianEdgePvpCombo", "Adds Cha/断绝/Smite on AeolianEdge combo", NINPVP.JobID)]
        NinjaAeolianEdgePvpCombo = 80014,

        [SecretCustomCombo]
        [CustomComboInfo("Mnk连击PvPFeature", "Adds Axekick/Smite/TornadoKick on main combo", MNKPVP.JobID)]
        MnkBootshinePvPFeature = 80015,

        [SecretCustomCombo]
        [CustomComboInfo("Black天语PVPFeature", "天语 Stance Switcher", BLMPVP.JobID)]
        BlackEnochianPVPFeature = 80016,


        #endregion
    }
}

