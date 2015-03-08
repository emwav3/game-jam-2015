using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {
	public int speed;

	// Use this for initialization
	void Start () {
		string name = this.gameObject.name;
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody2D.velocity = transform.up.normalized * speed;
		transform.Translate(speed * Time.deltaTime, 0f, 0f);
	}

	void OnCollisionEnter2D(Collision2D col) {
		GameObject me = this.gameObject;
		if (name == "missile") {
			Destroy (me);
			//play explosion here
		} else {
			if(col.gameObject.tag != "ground"){
				Destroy(me);
			}
		}
	}
}
