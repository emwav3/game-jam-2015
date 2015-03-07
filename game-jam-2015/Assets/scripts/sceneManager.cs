using UnityEngine;
using System.Collections.Generic;

public class sceneManager : MonoBehaviour {
	
	public Transform prefab;
	public int numberOfObjects;
	public float recycleOffset;
	public Vector3 startPosition;
	
	private Vector3 nextPosition;
	private Queue<Transform> objectQueue;
	
	void Start () {
		objectQueue = new Queue<Transform>(numberOfObjects);
		nextPosition = startPosition;
		for (int i = 0; i < numberOfObjects; i++) {
			Transform o = (Transform)Instantiate(prefab);
			o.localPosition = nextPosition;
			nextPosition.x += 7.35f;
			objectQueue.Enqueue(o);
		}
	}
	
	void Update () {
		if (objectQueue.Peek().localPosition.x + recycleOffset < move.distanceTraveled) {
			Transform o = objectQueue.Dequeue();
			o.localPosition = nextPosition;
			nextPosition.x += o.localScale.x;
			objectQueue.Enqueue(o);
		}
	}

	private void Recycle () {
		Transform o = objectQueue.Dequeue();
		o.localPosition = nextPosition;
		nextPosition.x += o.localScale.x;
		objectQueue.Enqueue(o);
	}
}