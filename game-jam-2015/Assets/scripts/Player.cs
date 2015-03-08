using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public bool hasFireball;
	public bool hasRocket;
	public GameState points;
	public GameObject[]  powerUps;
	public GameObject powerUp;
	int randomNum;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hasFireball == true){
			Debug.Log("fireball");
			hasFireball = false;
		}
		else if(hasRocket == true){
			Debug.Log("rocket");
			hasRocket = false;
		}
	}

	void OnTriggerEnter2D(Collider2D collider){
//		playerScript = (Player)GameObject.FindGameObjectWithTag("player").GetComponent<Player>();
				points = (GameState)GameObject.FindGameObjectWithTag ("stateManager").GetComponent<GameState> ();
				//		GameState gameStateScript =(GameState)points.GetComponent<GameState> ();
				//If player collides with the coin
				if (collider.gameObject.tag == "coin") {
						points.points += 1;	
						Destroy (collider.gameObject);
				}
				//If the player collides with a powerUp box
				if (collider.gameObject.tag == "powerUp") {
						randomNum = Random.Range (0, powerUps.Length);
						powerUp = powerUps [randomNum];
						Debug.Log (powerUp.name.ToString ());
						if (powerUp.name == "fireball") {
								hasFireball = true;
						} else if (powerUp.name == "rocket") {
								hasRocket = true;
						}
				}
		}
}
