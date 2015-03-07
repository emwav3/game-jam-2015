using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public static float distanceTraveled;
	public float speed;
	public float jumpPower;
	public bool canJump = true;
	public bool hasJumped = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed * Time.deltaTime, 0f, 0f);


		//For jumping
		float vertical = Input.GetAxisRaw ("Vertical");
		if(canJump) {
			if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)){
				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0.0f);
				rigidbody2D.AddForce(Vector2.up * jumpPower);
				canJump = false;
			}
		}
		
		distanceTraveled = transform.localPosition.x;
	}
	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "ground") {
			canJump = true;		
				}
		else {
			canJump = false;
				}
	}
}
