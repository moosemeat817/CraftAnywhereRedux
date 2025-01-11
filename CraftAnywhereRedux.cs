using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;
using Il2CppTLD.Gear;

namespace CraftAnywhereRedux
{
	public class CraftAnywhereReduxMain : MelonMod
	{
		public override void OnInitializeMelon()
		{
            Settings.OnLoad();          
        }
        
    }
}