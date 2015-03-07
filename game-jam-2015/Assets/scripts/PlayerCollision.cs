using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
	public GameState points;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		points = (GameState)GetComponent<GameState> ();
		//If player collides with the coin
		if (coll.gameObject.tag == "coin") {
			points.points += 1;		
		}
	}
}
