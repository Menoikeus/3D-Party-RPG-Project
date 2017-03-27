using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public float damage;
	public int speed;
	public Vector3 direction;

	void Start()
	{
		
	}

	void Update()
	{
		transform.Translate(direction * speed * Time.deltaTime);
	}
}
