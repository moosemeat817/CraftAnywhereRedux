using Il2Cpp;
using Il2CppTLD.Gear;
using MelonLoader;
using ModSettings;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;
using static UnityEngine.Rendering.SplashScreen;

namespace CraftAnywhereRedux
{
	internal class CraftAnywhereReduxSettings : JsonModSettings
    {
        // ----------------------------------------------------------------------------------
        // TOOLS
        // ----------------------------------------------------------------------------------

        [Name("Show Tools")]
        public bool tools_enabled = false;


        [Name("     Arrow Shaft")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int arrowshaftLocationIndex = 1;

        [Name("     Arrowhead")]
        [Description("The default location is at the Forge.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int arrowheadLocationIndex = 2;

        [Name("     Bearskin Bedroll")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int bearskinbedrollLocationIndex = 1;

        [Name("     Bullet")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int bulletLocationIndex = 3;

        [Name("     Bullet")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int bushcraftbowLocationIndex = 1;

        [Name("     Can of Gunpowder")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench")]
        public int gunpowderLocationIndex = 2;

        [Name("     Cougar Claw Knife")]
        [Description("The default location is at the Forge.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int cougarclawknifeLocationIndex = 2;

        [Name("     Fire Hardened Arrow")]
        [Description("The default location is at a Fire.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int firehardenedarrowLocationIndex = 4;

        [Name("     Fishing Lure - Wires")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int fishinglurewiresLocationIndex = 1;

        [Name("     Fishing Lure - Acorns")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int fishinglureacornsLocationIndex = 1;

        [Name("     Fishing Lure - Revolver Shell Casing")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int fishinglurecasingLocationIndex = 1;

        [Name("     Fishing Tip Up")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int fishingtipupLocationIndex = 1;

        [Name("     Hook")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int hookLocationIndex = 1;

        [Name("     Improvised Hatchet")]
        [Description("The default location is at the Forge.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int improvisedhatchetLocationIndex = 2;

        [Name("     Improvised Knife")]
        [Description("The default location is at the Forge.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int improvisedknifeLocationIndex = 2;

        [Name("     Line")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int lineLocationIndex = 1;

        [Name("     Noisemaker")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int noisemakerLocationIndex = 3;

        [Name("     Revolver Cartridge")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int revolvercartridgeLocationIndex = 3;

        [Name("     Rifle Cartridge")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int riflecartridgeLocationIndex = 3;

        [Name("     Simple Arrow")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int simplearrowLocationIndex = 1;

        [Name("     Simple Fishing Lure")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int simplefishinglureLocationIndex = 1;

        [Name("     Snare")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int snareLocationIndex = 1;

        [Name("     Survival Bow")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int survivalbowLocationIndex = 1;

        [Name("     Travois")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int travoisLocationIndex = 1;





        // ----------------------------------------------------------------------------------
        // CLOTHING
        // ----------------------------------------------------------------------------------

        [Name("Show Clothing")]
        //[Description("Clothing")]
        public bool clothing_enabled = false;


        [Name("     Bearskin Coat")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int bearskincoatLocationIndex = 1;

        [Name("     Cougar Wrap")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int cougarwrapLocationIndex = 1;

        [Name("     Deerskin Boots")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int deerskinbootsLocationIndex = 1;

        [Name("     Deerskin Pants")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int deerskinpantsLocationIndex = 1;


        [Name("     Improvised Crampons")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int improvisedcramponsLocationIndex = 1;

        [Name("     Moosehide Cloak")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int moosehidecloakLocationIndex = 1;

        [Name("     Moosehide Satchel")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int moosehidesatchelLocationIndex = 1;

        [Name("     Rabbitskin Hat")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int rabbitskinhatLocationIndex = 1;

        [Name("     Rabbitskin Mitts")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int rabbitskinmittsLocationIndex = 1;

        [Name("     Wolfskin Coat")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int wolfskincoatLocationIndex = 1;

        [Name("     Wolfskin Hat")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int wolfskinhatLocationIndex = 1;

        [Name("     Wolfskin Pants")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int wolfskinpantsLocationIndex = 1;



        protected void SetToolsVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("arrowshaftLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("arrowheadLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("bearskinbedrollLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("bulletLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("bushcraftbowLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("gunpowderLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("cougarclawknifeLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("firehardenedarrowLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("fishinglurewiresLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("fishinglureacornsLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("fishinglurecasingLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("fishingtipupLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("hookLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("improvisedhatchetLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("improvisedknifeLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("lineLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("noisemakerLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("revolvercartridgeLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("riflecartridgeLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("simplearrowLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("simplefishinglureLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("snareLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("survivalbowLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("travoisLocationIndex"), visible);
        }


        protected void SetClothingVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("bearskincoatLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("cougarwrapLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("deerskinbootsLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("deerskinpantsLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("improvisedcramponsLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("moosehidecloakLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("moosehidesatchelLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("rabbitskinhatLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("rabbitskinmittsLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("wolfskincoatLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("wolfskinhatLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("wolfskinpantsLocationIndex"), visible);
        }

        internal void UpdateVisibility()
        {
            SetToolsVisibility(tools_enabled);
            SetClothingVisibility(clothing_enabled);
        }


        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {

            base.RefreshGUI();
            base.OnChange(field, oldValue, newValue);
            if (field.Name == "tools_enabled") SetToolsVisibility((bool)newValue);
            else if (field.Name == "clothing_enabled") SetClothingVisibility((bool)newValue);

        }



        protected override void OnConfirm()
        {
            base.RefreshGUI();
            base.OnConfirm();
        }
    }

    internal static class Settings
    {
        public static CraftAnywhereReduxSettings options;

        public static void OnLoad()
        {
            options = new CraftAnywhereReduxSettings();
            options.AddToModSettings("Craft Anywhere Redux");
            options.UpdateVisibility();
        }
        public static CraftAnywhereReduxSettings Get()
        {
            return options;
        }
    }
}