using UnityEngine;
using System.Collections.Generic;

public class sceneManager : MonoBehaviour {
	
	public Transform prefab;
	public int numberOfObjects;
	public float offset;
	public Vector3 startPosition;
	
	private Vector3 nextPosition;
	private Queue<Transform> objectQueue;
	
	void Start () {
		objectQueue = new Queue<Transform>(numberOfObjects);
		nextPosition = startPosition;
		for (int i = 0; i < numberOfObjects; i++) {
			Transform o = (Transform)Instantiate(prefab);
			o.localPosition = nextPosition;
			nextPosition.x += offset;
			objectQueue.Enqueue(o);
		}
	}
	
	void Update () {
		if (objectQueue.Peek().localPosition.x + offset * 2 < move.distanceTraveled) {
			nextPosition.x = objectQueue.Peek().localPosition.x + offset * 4;
			Transform trash = objectQueue.Dequeue();
			GameObject t = trash.gameObject;
			Destroy(t);
			//Transform o = objectQueue.Dequeue();
			//o.localPosition = nextPosition;
			//nextPosition.x += o.localScale.x;
			Transform o = (Transform)Instantiate(prefab);
			o.localPosition = nextPosition;
			objectQueue.Enqueue(o);
		}
	}
	
}