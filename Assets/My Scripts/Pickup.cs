using UnityEngine;
using System.Collections;
using Leap.Unity;

public class Pickup : MonoBehaviour {

	GameObject _target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setTarget(GameObject target) {
		if (_target == null) {
			_target = target;
		}
	}

	public void pickupTarget() {
		if (_target) {
			StartCoroutine(changeParent());
			Rigidbody rb = _target.gameObject.GetComponent<Rigidbody>();
			if(rb != null) {
				rb.isKinematic = true;
			}
		}
	}

	//Avoids object jumping when passing from hand to hand.
	IEnumerator changeParent() {
		yield return null;
		if(_target != null)
			_target.transform.parent = transform;
	}

	public void releaseTarget() {
		if (_target && _target.activeInHierarchy) {
			if (_target.transform.parent == transform) { //Only reset if we are still the parent
				Rigidbody rb = _target.gameObject.GetComponent<Rigidbody>();
				if (rb != null) {
					rb.isKinematic = false;
				}
				_target.transform.parent = null;
			}
			_target = null;
		}
	}

	public void clearTarget(){
		_target = null;
	}
}
