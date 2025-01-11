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
                    else if (name == "CougarWrap")
                    {
                        bpi.m_RequiredCraftingLocation = (CraftingLocation)Settings.options.cougarwrapLocationIndex;
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

                }

                //__instance.RefreshAvailableBlueprints();
            }
        }

	}
}
