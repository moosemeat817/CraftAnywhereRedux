using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.Gear;
using MelonLoader;
using ModComponent;
using UnityEngine;

namespace CraftAnywhereRedux
{
	internal static class Patches
	{
        [HarmonyPatch(typeof(Panel_Crafting), "ItemPassesFilter")]
        private static class ChangeCraftingLocation
        {
            internal static void Postfix(BlueprintData bpi)
            {
                string? name = bpi?.m_CraftedResultGear?.name?.Substring(5);

                if (name != null)
                {
                    // ----------------------------------------------------------------------------------
                    //TOOLS
                    // ----------------------------------------------------------------------------------

                    if (name == "ArrowShaft")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.arrowshaftLocationIndex;
                    }
                    else if (name == "ArrowHead")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.arrowheadLocationIndex;
                    }
                    else if (name == "BearSkinBedRoll")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.bearskinbedrollLocationIndex;
                    }
                    else if (name == "Bullet")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.bulletLocationIndex;
                    }
                    else if (name == "Bow_Bushcraft")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.bushcraftbowLocationIndex;
                    }
                    else if (name == "GunpowderCan")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.gunpowderLocationIndex;
                    }
                    else if (name == "CougarClawKnife")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.cougarclawknifeLocationIndex;
                    }
                    else if (name == "ArrowHardened")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.firehardenedarrowLocationIndex;
                    }
                    else if (name == "FishingLureD")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.fishinglurewiresLocationIndex;
                    }
                    else if (name == "FishingLureC")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.fishinglureacornsLocationIndex;
                    }
                    else if (name == "FishingLureB")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.fishinglurecasingLocationIndex;
                    }
                    else if (name == "TipUp")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.fishingtipupLocationIndex;
                    }
                    else if (name == "Hook")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.hookLocationIndex;
                    }
                    else if (name == "HatchetImprovised")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.improvisedhatchetLocationIndex;
                    }
                    else if (name == "KnifeImprovised")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.improvisedknifeLocationIndex;
                    }
                    else if (name == "Line")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.lineLocationIndex;
                    }
                    else if (name == "NoiseMaker_A")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.noisemakerLocationIndex;
                    }
                    else if (name == "RevolverAmmoSingle")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.revolvercartridgeLocationIndex;
                    }
                    else if (name == "RifleAmmoSingle")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.riflecartridgeLocationIndex;
                    }
                    else if (name == "Arrow")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.simplearrowLocationIndex;
                    }
                    else if (name == "FishingLureA")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.simplefishinglureLocationIndex;
                    }
                    else if (name == "Snare")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.snareLocationIndex;
                    }
                    else if (name == "Bow")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.survivalbowLocationIndex;
                    }
                    else if (name == "Travois")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.travoisLocationIndex;
                    }



                    // ----------------------------------------------------------------------------------
                    //CLOTHING
                    // ----------------------------------------------------------------------------------

                    else if (name == "BearSkinCoat")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.bearskincoatLocationIndex;
                    }
                    else if (name == "DeerSkinBoots")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.deerskinbootsLocationIndex;
                    }
                    else if (name == "DeerSkinPants")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.deerskinpantsLocationIndex;
                    }
                    else if (name == "ImprovisedCrampons")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.improvisedcramponsLocationIndex;
                    }
                    else if (name == "MooseHideCloak")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.moosehidecloakLocationIndex;
                    }
                    else if (name == "MooseHideBag")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.moosehidesatchelLocationIndex;
                    }
                    else if (name == "RabbitskinHat")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.rabbitskinhatLocationIndex;
                    }
                    else if (name == "RabbitSkinMittens")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.rabbitskinmittsLocationIndex;
                    }
                    else if (name == "WolfSkinCape")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.wolfskincoatLocationIndex;
                    }
                    else if (name == "WolfSkinHat")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.wolfskinhatLocationIndex;
                    }
                    else if (name == "WolfSkinPant")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.wolfskinpantsLocationIndex;
                    }


                    // ----------------------------------------------------------------------------------
                    // MODS
                    // ----------------------------------------------------------------------------------

                    // Wolfscarf
                    else if (name == "WolfScarf")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.wolfscarfLocationIndex;
                    }

                    // Leatherworks
                    else if (name == "JacketLeatherFlightA")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.jacketleatherLocationIndex;
                    }
                    else if (name == "ImprovedDownInsulation")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.improveddownLocationIndex;
                    }
                    else if (name == "ImprovedJacketLeather")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.improvedjacketleatherLocationIndex;
                    }
                    else if (name == "ImprovedLongJohns")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.improvedlongjohnsLocationIndex;
                    }
                    else if (name == "ImprovisedFlask")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.improvisedflaskLocationIndex;
                    }


                    // Northfolk
                    else if (name == "BearskinLeggings")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.bearskinleggingsLocationIndex;
                    }
                    else if (name == "DeerskinCoat")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.deerskincoatLocationIndex;
                    }
                    else if (name == "DeerskinGloves")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.deerskinglovesLocationIndex;
                    }
                    else if (name == "WolfskinBoots")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.wolfskinbootsLocationIndex;
                    }
                    else if (name == "WolfskinCap")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.wolfskincapLocationIndex;
                    }



                    // Ammo Tools
                    else if (name == "EmptyShellCasing")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.emptyshellcasingLocationIndex;
                    }
                    else if (name == "FlareGunAmmoSingle")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.flaregunammosingleLocationIndex;
                    }
                    else if (name == "Magnesium")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.magnesiumLocationIndex;
                    }
                    else if (name == "RifleCleaningKit")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.riflecleaningkitLocationIndex;
                    }


                    // Cannery Manufacturing
                    else if (name == "CookingPot")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.cookingpotLocationIndex;
                    }
                    else if (name == "Firelog")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.firelogLocationIndex;
                    }
                    else if (name == "Hatchet")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.hatchetLocationIndex;
                    }
                    else if (name == "Knife")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.knifeLocationIndex;
                    }
                    else if (name == "ScrapMetal")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.scrapmetalLocationIndex;
                    }



                    // Dead Air
                    else if (name == "ImprovisedFilter")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.improvisedfilterLocationIndex;
                    }



                    // Useful Blueprints
                    else if (name == "WoodMatches")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.woodmatchesLocationIndex;
                    }
                    else if (name == "SewingKit")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.sewingkitLocationIndex;
                    }
                    else if (name == "Bow_Woodwrights")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.bowwoodwrightsLocationIndex;
                    }
                    else if (name == "Rope")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.ropeLocationIndex;
                    }
                    else if (name == "SaltBag")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.saltbagLocationIndex;
                    }
                    else if (name == "SharpeningStone")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.sharpeningstoneLocationIndex;
                    }



                }

                //__instance.RefreshAvailableBlueprints();
            }
        }

	}
}
