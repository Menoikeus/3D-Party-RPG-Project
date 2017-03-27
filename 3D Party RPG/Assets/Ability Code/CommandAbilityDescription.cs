using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandAbilityDescription : ScriptableObject {

	public string displayName;

	public enum AbilityType
	{
		Damage,
		Heal,
		Kinetic,
	}
	public enum TargetType
	{
		None,
		SkillShot,
		SingleTarget,
		MultipleTarget,
		Area,
	}

	//[System.Serializable]
	//public class AbilityInfo
	//{
	[Header("Basic Ability Info")]
		
	public AbilityType aType;
	public TargetType tType;

	[Header("Deeper Ability Info")]
	public bool overTime;
	public int effectValue;
	public int duration; //0 if not applicable
	public int speed; //0 if not applicable
	//}
}
