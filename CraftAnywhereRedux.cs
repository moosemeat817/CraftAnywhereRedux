using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;
using Il2CppTLD.Gear;
using ComplexLogger;

namespace CraftAnywhereRedux
{
	public class CraftAnywhereReduxMain : MelonMod
	{

        internal static ComplexLogger<CraftAnywhereReduxMain> Logger = new();
        public override void OnInitializeMelon()
		{
            Logger.Log("CraftAnywhere is online.", FlaggedLoggingLevel.None);
            Settings.OnLoad();          
        }
        
    }
}