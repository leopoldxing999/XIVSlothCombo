using Dalamud.Interface.Colors;
using Dalamud.Utility;
using ImGuiNET;
using System.Numerics;

namespace XIVSlothCombo.Window.Tabs
{
    internal class AboutUs : ConfigWindow
    {
        internal static new void Draw()
        {
            ImGui.BeginChild("About", new Vector2(0, 0), true);

            ImGui.TextColored(ImGuiColors.ParsedGreen, $"v3.0.16.5\n- with love from Team Sloth.");
            ImGui.Spacing();
            ImGui.Spacing();
            ImGui.Spacing();
            ImGui.TextWrapped("Brought to you by: \nAki, k-kz, ele-starshade, damolitionn, Taurenkey, Augporto, grimgal and many other contributors!");
            ImGui.Spacing();
            ImGui.Spacing();
            ImGui.Spacing();
            ImGui.PushStyleColor(ImGuiCol.Button, ImGuiColors.ParsedPurple);
            ImGui.PushStyleColor(ImGuiCol.ButtonHovered, ImGuiColors.HealerGreen);

            //if (ImGui.Button("Click here to join our Discord Server!"))
            if (ImGui.Button("点击加入我们的 Discord 服务器!"))
            {
                Util.OpenLink("https://discord.gg/xT7zyjzjtY");
            }

            ImGui.PopStyleColor();
            ImGui.PopStyleColor();

            //if (ImGui.Button("Got an issue? Click this button and report it!"))
            if (ImGui.Button("有什么问题？点我汇报！"))
            {
                Util.OpenLink("https://github.com/Nik-Potokar/XIVSlothCombo/issues");
            }

            ImGui.EndChild();
        }
    }
}
