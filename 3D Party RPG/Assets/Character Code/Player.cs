using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	Character character;
	CommandAbilityExecutor executor;

	// Use this for initialization
	void Start () {
		executor = GetComponent<CommandAbilityExecutor>();
		character = GetComponent<Character>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			executor.ExecuteAbility ("Fireball", null, (transform.Find("Camera")).transform.forward);
		}
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			executor.ExecuteAbility ("Darkball", null, (transform.Find("Camera")).transform.forward);
		}
		if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			executor.ExecuteAbility ("Waterball", null, (transform.Find("Camera")).transform.forward);
		}

		if(Input.GetKey(KeyCode.W))
			transform.Translate(new Vector3(0,0,1) * character.moveSpeed);
		if(Input.GetKey(KeyCode.A))
			transform.Translate(new Vector3(-1,0,0) * character.moveSpeed);
		if(Input.GetKey(KeyCode.S))
			transform.Translate(new Vector3(0,0,-1) * character.moveSpeed);
		if(Input.GetKey(KeyCode.D))
			transform.Translate(new Vector3(1,0,0) * character.moveSpeed);
	}
}
