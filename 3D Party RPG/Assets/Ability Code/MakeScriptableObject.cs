using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MakeScriptableObject{
	[MenuItem("Assets/Create/Ability")]
	public static void CreateMyAsset()
	{
		CommandAbilityDescription asset = ScriptableObject.CreateInstance<CommandAbilityDescription> ();

		AssetDatabase.CreateAsset (asset, "Assets/Ability Code/Abilities/NewAbility.asset");
		AssetDatabase.SaveAssets ();

		EditorUtility.FocusProjectWindow ();

		Selection.activeObject = asset;
	}
}
