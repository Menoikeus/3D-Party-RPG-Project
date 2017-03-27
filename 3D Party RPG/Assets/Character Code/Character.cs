using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
	public float baseHealth;
	public float baseMana;

	public float currentHealth;
	public float currentMana;

	public float moveSpeed;

	void Start()
	{
		
	}

	void Update()
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Projectile")
		{
			Projectile projectileInfo = other.gameObject.GetComponent<Projectile>();
			currentHealth -= projectileInfo.damage;

			Destroy(other.gameObject, .1f);
		}
		Debug.Log("CONTACT");
	}
}
