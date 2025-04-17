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

        [Name("     Bushcraft Bow")]
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




        // ----------------------------------------------------------------------------------
        // MODS
        // ----------------------------------------------------------------------------------


        // Wolfscarf
        [Name("Show Wolfscarf")]
        //[Description("Clothing")]
        public bool wolfscarf_enabled = false;


        [Name("     Wolfskin Scarf")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int wolfscarfLocationIndex = 1;



        // Leatherworks
        [Name("Show Leatherworks")]
        //[Description("Clothing")]
        public bool leatherworks_enabled = false;


        [Name("     Flight Jacket")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int jacketleatherLocationIndex = 1;

        [Name("     Improved Down")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int improveddownLocationIndex = 1;

        [Name("     Improved Flight Jacket")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int improvedjacketleatherLocationIndex = 1;

        [Name("     Improved Longjohns")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int improvedlongjohnsLocationIndex = 1;

        [Name("     Improvised Flask")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge")]
        public int improvisedflaskLocationIndex = 1;



        // Northfolk
        [Name("Show Northfolk Clothing")]
        //[Description("Clothing")]
        public bool northfolk_enabled = false;


        [Name("     Bearskin Leggings")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int bearskinleggingsLocationIndex = 1;

        [Name("     Deerskin Gloves")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int deerskincoatLocationIndex = 1;

        [Name("     Deerskin Gloves")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int deerskinglovesLocationIndex = 1;

        [Name("     Wolfskin Boots")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int wolfskinbootsLocationIndex = 1;

        [Name("     Wolfskin Cap")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int wolfskincapLocationIndex = 1;




        // Ammo Tools
        [Name("Show Ammo Tools")]
        //[Description("Clothing")]
        public bool ammotools_enabled = false;


        [Name("     Empty Shell Casing")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int emptyshellcasingLocationIndex = 3;

        [Name("     Flare Gun Ammo")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int flaregunammosingleLocationIndex = 3;

        [Name("     Magnesium")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int magnesiumLocationIndex = 3;

        [Name("     Rifle Cleaning Kit")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int riflecleaningkitLocationIndex = 1;



        // Cannery Manufacturing
        [Name("Show Cannery Manufacturing")]
        //[Description("Clothing")]
        public bool cannery_enabled = false;


        [Name("     Cooking Pot")]
        [Description("The default location is at the Forge.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int cookingpotLocationIndex = 2;

        [Name("     Firelog")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int firelogLocationIndex = 1;

        [Name("     Hatchet")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int hatchetLocationIndex = 3;

        [Name("     Knife")]
        [Description("The default location is at the Ammo Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int knifeLocationIndex = 3;

        [Name("     Scrap Metal")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int scrapmetalLocationIndex = 2;


        // Dead Air
        [Name("Show Dead Air")]
        //[Description("Clothing")]
        public bool deadair_enabled = false;


        [Name("     Improvised Filter")]
        [Description("The default location is at the Forge.")]
        [Choice("Anywhere", "Workbench", "Forge", "Ammo Workbench", "Fire")]
        public int improvisedfilterLocationIndex = 2;


        // Useful Blueprints
        [Name("Show Useful Blueprints")]
        //[Description("Clothing")]
        public bool usefulblueprints_enabled = false;


        [Name("     Wood Matches")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int woodmatchesLocationIndex = 1;

        [Name("     Sewing Kit")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int sewingkitLocationIndex = 1;

        [Name("     Woodwright's Bow")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int bowwoodwrightsLocationIndex = 1;

        [Name("     Rope")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int ropeLocationIndex = 1;

        [Name("     Salt Bag")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int saltbagLocationIndex = 1;

        [Name("     Whetstone")]
        [Description("The default location is at the Workbench.")]
        [Choice("Anywhere", "Workbench")]
        public int sharpeningstoneLocationIndex = 1;



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
            this.SetFieldVisible(GetType().GetField("wolfscarfLocationIndex"), visible);
        }

        protected void SetWolfscarfVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("wolfscarfLocationIndex"), visible);
        }


        protected void SetLeatherworksVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("jacketleatherLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("improveddownLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("improvedjacketleatherLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("improvedlongjohnsLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("improvisedflaskLocationIndex"), visible);
        }

        protected void SetNorthfolkVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("bearskinleggingsLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("deerskincoatLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("deerskinglovesLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("wolfskinbootsLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("wolfskincapLocationIndex"), visible);
        }


        protected void SetAmmoToolsVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("emptyshellcasingLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("flaregunammosingleLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("magnesiumLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("riflecleaningkitLocationIndex"), visible);
        }


        protected void SetCanneryVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("cookingpotLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("firelogLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("hatchetLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("knifeLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("scrapmetalLocationIndex"), visible);
        }


        protected void SetDeadAirVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("improvisedfilterLocationIndex"), visible);
        }



        protected void SetUsefulBlueprintsVisibility(bool visible)
        {
            this.SetFieldVisible(GetType().GetField("woodmatchesLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("sewingkitLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("bowwoodwrightsLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("ropeLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("saltbagLocationIndex"), visible);
            this.SetFieldVisible(GetType().GetField("sharpeningstoneLocationIndex"), visible);
        }


        internal void UpdateVisibility()
        {
            SetToolsVisibility(tools_enabled);
            SetClothingVisibility(clothing_enabled);
            SetWolfscarfVisibility(wolfscarf_enabled);
            SetLeatherworksVisibility(leatherworks_enabled);
            SetNorthfolkVisibility(northfolk_enabled);
            SetAmmoToolsVisibility(ammotools_enabled);
            SetCanneryVisibility(cannery_enabled);
            SetDeadAirVisibility(deadair_enabled);
            SetUsefulBlueprintsVisibility(usefulblueprints_enabled);
        }


        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {

            base.RefreshGUI();
            base.OnChange(field, oldValue, newValue);
            if (field.Name == "tools_enabled") SetToolsVisibility((bool)newValue);
            else if (field.Name == "clothing_enabled") SetClothingVisibility((bool)newValue);
            else if (field.Name == "wolfscarf_enabled") SetWolfscarfVisibility((bool)newValue);
            else if (field.Name == "leatherworks_enabled") SetLeatherworksVisibility((bool)newValue);
            else if (field.Name == "northfolk_enabled") SetNorthfolkVisibility((bool)newValue);
            else if (field.Name == "ammotools_enabled") SetAmmoToolsVisibility((bool)newValue);
            else if (field.Name == "cannery_enabled") SetCanneryVisibility((bool)newValue);
            else if (field.Name == "deadair_enabled") SetDeadAirVisibility((bool)newValue);
            else if (field.Name == "usefulblueprints_enabled") SetUsefulBlueprintsVisibility((bool)newValue);
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