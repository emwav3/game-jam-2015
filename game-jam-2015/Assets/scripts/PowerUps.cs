using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {
	public int speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody2D.velocity = transform.up.normalized * speed;
		transform.Translate(speed * Time.deltaTime, 0f, 0f);
	}
}
