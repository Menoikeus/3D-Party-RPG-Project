using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {
	public float healthBarLength;

	void Start()
	{
		healthBarLength = Screen.width / 6;
	}

	void Update()
	{
		//AdjustCurrentHealth(0);
	}
	/*
	public Font font;
	public int fontSize = 8;
	public Vector3 Offset = Vector3.zero;

	public float health = 100;

	private TextMesh bar;

	// Use this for initialization
	void Start () {
		bar = new GameObject("HealthBar").AddComponent("TextMesh") as TextMesh;
		bar.gameObject.addComponent("MeshRenderer");
		bar.gameObject.transform.parent = transform;
		bar.transform.localPosition = Vector3.zero + Offset;

		if(font) bar.font = font;
		else bar.font = GUI.skin.font;

		bar.renderer.material = font.material;
		bar.characterSize = .25f;
		bar.alignment = TextAlignment.Center;
		bar.anchor = TextAnchor.MiddleCenter;
		bar.fontSize = fontSize;
	}
	
	// Update is called once per frame
	void Update () {
		if(bar.text != "HP: " + health.ToString()) bar.text = "HP: " + health;this.ToString();
	}*/
}
