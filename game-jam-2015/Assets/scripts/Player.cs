using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public bool hasFireball;
	public bool hasRocket;

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
}
