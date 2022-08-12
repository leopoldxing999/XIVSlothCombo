using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dalamud.Logging;
using XIVSlothCombo.Combos.PvE;
using XIVSlothCombo.Services;

namespace XIVSlothCombo.Attributes
{
    /// <summary> Attribute documenting additional information for each combo. </summary>
    [AttributeUsage(AttributeTargets.Field)]
    internal class CustomComboInfoAttribute : Attribute
    {
        /// <summary> Initializes a new instance of the <see cref="CustomComboInfoAttribute"/> class. </summary>
        /// <param name="fancyName"> Display name. </param>
        /// <param name="description"> Combo description. </param>
        /// <param name="jobID"> Associated job ID. </param>
        /// <param name="order"> Display order. </param>
        /// <param name="memeName"> Display meme name </param>
        /// <param name="memeDescription"> Meme description. </param>
        internal CustomComboInfoAttribute(string fancyName, string description, byte jobID, [CallerLineNumber] int order = 0, string memeName = "", string memeDescription = "")
        {
            var 原始fancyName = fancyName;
            var 原始description = description;
            var 增加搜索 = true;
            var 技能翻译 = true;


            // if (Service.Configuration != null)
            {
                // if (Service.Configuration.Language == "zh-CN")
                {
                    Dictionary<string, string> db = Translatezh_CN.db;
                    Dictionary<string, string> dbActionName = Translatezh_CN_DBActionName.dbActionName;

                    if (db.ContainsKey(fancyName))
                    {
                        fancyName = db[fancyName];
                        增加搜索 = false;
                        技能翻译 = false;
                    }


                    if (db.ContainsKey(description))
                    {
                        description = db[description];
                        技能翻译 = false;
                    }
                    if (技能翻译)
                    {
                        var split_description = description.Replace('\n',' ').Split(' ');
                        var find = false;
                        for (int i = 0; i < split_description.Length; i++)
                        {                            
                            if (i < split_description.Length - 2)
                            {
                                var new_word = split_description[i] + " " + split_description[i + 1] + " " + split_description[i + 2];
                                if (dbActionName.ContainsKey(new_word))
                                {
                                    description = description.Replace(new_word, dbActionName[new_word]);
                                    find = true;
                                    continue;
                                }
                            }
                            if (i < split_description.Length - 1)
                            {
                                var new_word = split_description[i] + " " + split_description[i + 1];
                                if (dbActionName.ContainsKey(new_word))
                                {
                                    description = description.Replace(new_word, dbActionName[new_word]);
                                    find = true;
                                    continue;
                                }
                            }
                            if (dbActionName.ContainsKey(split_description[i]))
                            {
                                description = description.Replace(split_description[i], dbActionName[split_description[i]]);
                                find = true;
                            }

                        }
                        if (find)
                        {
                            db[原始description] = description;
                            增加搜索 = false;
                        }
                    }


                    if (增加搜索)
                    {
                        try
                        {
                            var replaceOption = fancyName.Replace(" Option", "");

                            if (db.ContainsKey($"{replaceOption}"))
                            {
                                fancyName = db[$"{replaceOption}"];
                            }

                            if (db.ContainsKey($"{replaceOption}"))
                            {
                                description = db[$"{replaceOption}"];
                            }
                        }
                        catch (Exception e)
                        {
                            // PluginLog.Information($"log fancyName:{fancyName} description:{description} {e.Message}");

                            // Console.WriteLine(e);
                            // throw;
                        }
                    }
                }
            }
            if (fancyName == "等待翻译")
            {
                fancyName = 原始fancyName;
            }

            if (description == "等待翻译")
            {
                description = 原始description;
            }


            // if (fancyName .Equals("No Mercy AOE Option.") )
            // {
            //     fancyName = "我是你爹啊";
            // }


            FancyName = fancyName;
            Description = description;
            JobID = jobID;
            Order = order;
            MemeName = memeName;
            MemeDescription = memeDescription;
        }

        /// <summary> Gets the display name. </summary>
        public string FancyName { get; }

        ///<summary> Gets the meme name. </summary>
        public string MemeName { get; }

        /// <summary> Gets the description. </summary>
        public string Description { get; }

        /// <summary> Gets the meme description. </summary>
        public string MemeDescription { get; }

        /// <summary> Gets the job ID. </summary>
        public byte JobID { get; }

        /// <summary> Gets the display order. </summary>
        public int Order { get; }

        /// <summary> Gets the job name. </summary>
        public string JobName => JobIDToName(JobID);

        /// <summary> Gets the meme job name. </summary>
        public string MemeJobName => MemeJobIDToName(JobID);

        private static string JobIDToName(byte key) =>
            key switch
            {
                0 => "冒险者(通用设置)",
                1 => "Gladiator",
                2 => "Pugilist",
                3 => "Marauder",
                4 => "Lancer",
                5 => "Archer",
                6 => "Conjurer",
                7 => "Thaumaturge",
                8 => "Carpenter",
                9 => "Blacksmith",
                10 => "Armorer",
                11 => "Goldsmith",
                12 => "Leatherworker",
                13 => "Weaver",
                14 => "Alchemist",
                15 => "Culinarian",
                16 => "Miner",
                17 => "Botanist",
                18 => "捕鱼人",
                19 => "骑士",
                20 => "武僧",
                21 => "战士",
                22 => "龙骑士",
                23 => "诗人",
                24 => "白魔法师",
                25 => "黑魔法师",
                26 => "秘术师",
                27 => "召唤师",
                28 => "学者",
                29 => "双剑师",
                30 => "忍者",
                31 => "机工士",
                32 => "暗黑骑士",
                33 => "占星术士",
                34 => "武士",
                35 => "赤魔法师",
                36 => "青魔法师",
                37 => "绝枪战士",
                38 => "舞者",
                39 => "钐镰客",
                40 => "贤者",
                99 => "Global",
                DOH.JobID => "Disciples of the Hand",
                DoL.JobID => "大地使者",
                _ => "Unknown",
            };

        private static string MemeJobIDToName(byte key) =>
            key switch
            {
                0 => "Adventurer",
                1 => "Gladiator",
                2 => "Pugilist",
                3 => "Marauder",
                4 => "Lancer",
                5 => "Archer",
                6 => "Conjurer",
                7 => "Thaumaturge",
                8 => "Carpenter",
                9 => "Blacksmith",
                10 => "Armorer",
                11 => "Goldsmith",
                12 => "Leatherworker",
                13 => "Weaver",
                14 => "Alchemist",
                15 => "Culinarian",
                16 => "Miner",
                17 => "Botanist",
                18 => "捕鱼人",
                19 => "骑士",
                20 => "武僧",
                21 => "战士",
                22 => "龙骑士",
                23 => "诗人",
                24 => "白魔法师",
                25 => "黑魔法师",
                26 => "秘术师",
                27 => "召唤师",
                28 => "学者",
                29 => "双剑师",
                30 => "忍者",
                31 => "机工士",
                32 => "暗黑骑士",
                33 => "占星术士",
                34 => "武士",
                35 => "赤魔法师",
                36 => "青魔法师",
                37 => "绝枪战士",
                38 => "舞者",
                39 => "钐镰客",
                40 => "贤者",
                99 => "Global",
                DOH.JobID => "Disciples of the Hand",
                DoL.JobID => "大地使者",
                _ => "Unknown",
            };
    }
}