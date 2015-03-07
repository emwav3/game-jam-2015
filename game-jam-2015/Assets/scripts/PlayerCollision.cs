using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
	public GameState points;
	public GameObject[]  powerUps;
	public GameObject powerUp;
	int randomNum;
	public Player playerScript;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){

	}


	void OnTriggerEnter2D(Collider2D collider){
		playerScript = (Player)GetComponent<Player>();
		points = (GameState)GameObject.FindGameObjectWithTag ("stateManager").GetComponent<GameState>();
//		GameState gameStateScript =(GameState)points.GetComponent<GameState> ();
		//If player collides with the coin
		if (collider.gameObject.tag == "coin") {
			points.points += 1;	
			Destroy(collider.gameObject);
		}
		//If the player collides with a powerUp box
		if (collider.gameObject.tag == "Powerup") {
			randomNum = Random.Range(0, powerUps.Length);
			powerUp = powerUps[randomNum];
			if(powerUp.tag == "fireball"){
				playerScript.hasFireball = true;
			}
			else if(powerUp.tag == "rocket"){
				playerScript.hasRocket = true;
			}
		}
	}












}
