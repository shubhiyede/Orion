using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {

	void Update() {
        //Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        //Debug.DrawRay(transform.position, forward, Color.green);
        
        //RaycastHit hit;
        //Physics.Raycast(transform.position, -Vector3.up, out hit, 10.0f);
    }
    void OnDrawGizmosSelected() {
    	//Debug.Log("Inside OnDrawGizmosSelected");
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 10;
        Gizmos.DrawRay(transform.position, direction);
    }
	void OnCollisionEnter (Collision collision) {
		
		if(collision.gameObject.name == "BrushHand_L" || collision.gameObject.name == "BrushHand_R") {
			Debug.Log("Velocity of "+ this.gameObject.name + " is " + this.GetComponent<Rigidbody>().velocity.magnitude);
		}
	}
}
