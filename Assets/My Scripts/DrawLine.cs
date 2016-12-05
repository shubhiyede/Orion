using UnityEngine;
using System.Collections;

public class DrawLine : MonoBehaviour {

	private LineRenderer lineRenderer;
	public Transform origin;
	public Vector3 direction;

	// Use this for initialization
	void Start () {
		lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.SetWidth(.05f, .05f);
	}

	// Update is called once per frame
	void Update () {
		lineRenderer.SetPosition(0, origin.position);
		lineRenderer.SetPosition(1, origin.position + direction);
	}

	public void changeForceLine(string force) {
		if(gameObject.name == force) {
			direction = Vector3.up;
		}
	}
}
