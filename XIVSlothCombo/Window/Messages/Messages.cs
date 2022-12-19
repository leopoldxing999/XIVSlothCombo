using Dalamud.Interface.Colors;
using ImGuiNET;
using XIVSlothCombo.Services;

namespace XIVSlothCombo.Window.MessagesNS
{
    internal static class Messages
    {
        internal static bool PrintBLUMessage(string jobName)
        {
            if (jobName == Attributes.CustomComboInfoAttribute.JobIDToName(36)) //Blue Mage ID
            {
                if (Service.Configuration.ActiveBLUSpells.Count == 0)
                {
                    ImGui.Text("请打开你的青魔法师技能书，拖选激活一些技能后再启用功能");
                    return false;
                }

                else
                {
                    ImGui.TextColored(ImGuiColors.ParsedPink, $"请注意，即便有些需求的技能你还没学会，你仍然可以使用这些功能。\n任何你没学会的技能都会被跳过，所以如果某项功能不能按预期工作，\n那么请尝试学会更多所需的青魔法技能。");
                }
            }

            return true;
        }
    }
}
