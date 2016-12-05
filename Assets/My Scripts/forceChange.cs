using UnityEngine;
using System.Collections;

public class forceChange : MonoBehaviour {

	public GameObject normalReaction;
	public GameObject friction;

	void OnCollisionEnter (Collision collision) {
		if(gameObject.name == "ball" && collision.gameObject.name == "floor") {
			normalReaction.GetComponent<DrawLine>().direction = Vector3.up;
			friction.GetComponent<DrawLine>().direction = Vector3.left;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
