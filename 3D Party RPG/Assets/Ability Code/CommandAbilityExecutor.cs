using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandAbilityExecutor : MonoBehaviour {
	public void ExecuteAbility(string abilityName, GameObject[] targets, Vector3 direction)
	{
		Debug.Log ("Looking for file in " + "Ability Code/Abilities/" + abilityName);
		CommandAbilityDescription command = (CommandAbilityDescription)Resources.Load ("Abilities/" + abilityName);
		Execute (command, targets, direction);
	}

	private void Execute(CommandAbilityDescription command, GameObject[] targets, Vector3 direction)
	{
		switch (command.aType) 
		{
			case CommandAbilityDescription.AbilityType.Damage:
			{
				switch (command.tType) 
				{
					case CommandAbilityDescription.TargetType.SkillShot:
					{
						GameObject projectile = (GameObject)Resources.Load ("Ability Object/" + command.displayName);
						GameObject obj = Instantiate(projectile, this.transform.position, this.transform.rotation);

						Physics.IgnoreCollision(obj.GetComponent<Collider>(), GetComponent<Collider>());

						obj.AddComponent<Projectile>();
						obj.GetComponent<Projectile>().damage = command.effectValue;
						obj.GetComponent<Projectile>().speed = command.speed;
						obj.GetComponent<Projectile>().direction = direction;



						break;
					}
				}
				break;
			}
		}
	}
}
