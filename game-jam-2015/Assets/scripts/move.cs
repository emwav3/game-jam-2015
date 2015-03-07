using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public static float distanceTraveled;
	public float speed = 5f;
	public float jumpPower = 100f;
	public bool grounded = true;
	public bool hasJumped = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		transform.Translate(5f * Time.deltaTime, 0f, 0f);
		//For moving left/right
		float motion = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2 (motion * speed, rigidbody2D.velocity.y);
		//For jumping
		if(!grounded && rigidbody2D.velocity.y == 0) {
			grounded = true;
		}
		if (Input.GetButtonDown("Vertical") && grounded == true) {
			hasJumped = true;
		}

		distanceTraveled = transform.localPosition.x;
	}
	void FixedUpdate (){
		//If the character has jumped
		if(hasJumped){
			rigidbody2D.AddForce(transform.up*jumpPower);
			grounded = false;
			hasJumped = false;
		}
	}
}
