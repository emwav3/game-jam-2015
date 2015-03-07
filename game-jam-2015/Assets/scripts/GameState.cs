using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameState : MonoBehaviour {
	public int points;

	// Use this for initialization
	void Start () {
		points = 0;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject guiPoints = GameObject.FindGameObjectWithTag ("guiPoints");
		Text pointsText =guiPoints.GetComponent<Text>();
		pointsText.text = "Score: " + points.ToString();
	}
}
