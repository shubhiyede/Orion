using UnityEngine;
using System.Collections;

public class ObjectPanel : MonoBehaviour {

	public GameObject obj;

	public void createObject () {
		Vector3 newPosition=new Vector3(Random.Range(-1.0F, 1.0F), 0.0F, Random.Range(-1.0F, 1.0F));
		GameObject cloneObj = MonoBehaviour.Instantiate(obj, newPosition, Quaternion.identity ) as GameObject;
		//GameObject cloneObj = MonoBehaviour.Instantiate(obj.GetComponent<Rigidbody>(), newPosition, Quaternion.identity ) as GameObject;

	}
		
}
