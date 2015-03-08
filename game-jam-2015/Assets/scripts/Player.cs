using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public bool hasFireball;
	public bool hasRocket;
	public GameState points;
	public GameObject[]  powerUps;
	public GameObject powerUp;
	public GameObject fireball;
	public GameObject missile;
	int randomNum;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hasFireball == true){
			if(Input.GetKeyDown(KeyCode.Space)){
			Instantiate(fireball, new Vector2(transform.position.x + 2, transform.position.y), Quaternion.identity);
			Debug.Log("fireball234");
			hasFireball = false;
			}
		}
		else if(hasRocket == true){
			if(Input.GetKeyDown(KeyCode.Space)){
				Instantiate(missile, new Vector2(transform.position.x + 2, transform.position.y), Quaternion.identity);
			Debug.Log("missile432");
			hasRocket = false;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D collider){
				points = (GameState)GameObject.FindGameObjectWithTag ("stateManager").GetComponent<GameState> ();
				//If player collides with the coin
				if (collider.gameObject.tag == "coin") {
						points.points += 1;	
						Destroy (collider.gameObject);
				}
				//If the player collides with a powerUp box
				if (collider.gameObject.tag == "powerUp") {
						randomNum = Random.Range (0, powerUps.Length);
						powerUp = powerUps [randomNum];
						if (powerUp.name == "fireball") {
								hasFireball = true;
						} else if (powerUp.name == "missile") {
								hasRocket = true;
						}
				}
		}
}
