using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour {
	private Character NPCCharacter;
	private Image healthBar;

	// Use this for initialization
	void Start () {
		NPCCharacter = GetComponent<Character>();
		healthBar = transform.FindChild("Canvas").FindChild("HealthBG").FindChild("Health").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateHealth();
	}

	public void UpdateHealth()
	{
		healthBar.fillAmount = ((float)NPCCharacter.currentHealth)/NPCCharacter.baseHealth;
	}
}
