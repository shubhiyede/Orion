using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Properties : MonoBehaviour {

	public Text time;
	public Text velocity;
	public Slider mass;
	public Slider friction;
	public Toggle showForces;
	private Rigidbody rb;
	public LineRenderer force1;
	public LineRenderer force2;
	public LineRenderer force3;
	// public Dropdown choseMaterial;
	// public PhysicMaterial metal;
	// public PhysicMaterial concrete;
	// public PhysicMaterial glass;
	// public Material metalShader;
	// private List<PhysicMaterial> physicsMaterials;
	// private Collider coll;
	// private Material shader;

	// Use this for initialization
	void Start () {
		time.text = "";
		velocity.text = "";
		rb = gameObject.GetComponent<Rigidbody>();

		force1.enabled = showForces.isOn;
		force2.enabled = showForces.isOn;
		force3.enabled = showForces.isOn;

		// coll = gameObject.GetComponent<Collider>();
		// shader = gameObject.GetComponent<Material>();
		// Debug.Log("Collider = " + gameObject.GetComponent<Collider>());
		// Debug.Log("Shader = " + gameObject.GetComponent<Shader>());
		// Debug.Log("Physics Material = " + gameObject.GetComponent<PhysicMaterial>().name);
		// physicsMaterials = new List<PhysicMaterial>();
		// physicsMaterials.Add(metal);
		// physicsMaterials.Add(concrete);
		// physicsMaterials.Add(glass);
		// choseMaterial.ClearOptions();
		// choseMaterial.options.Add(new Dropdown.OptionData("metal"));
		// choseMaterial.options.Add(new Dropdown.OptionData("concrete"));
		// choseMaterial.options.Add(new Dropdown.OptionData("glass"));
		// choseMaterial.value = 1;
		//coll.material = physicsMaterials[choseMaterial.value];
		// shader = metalShader;
		// Debug.Log("Shader material = " + shader + " collider physics material = " + coll.material.name);
	}
	
	// Update is called once per frame
	void Update () {
		time.text = Time.time.ToString();
		velocity.text = rb.velocity.ToString();
		rb.mass = mass.value;
		GetComponent<Collider>().material.dynamicFriction = friction.value;
		force1.enabled = showForces.isOn;
		force2.enabled = showForces.isOn;
		force3.enabled = showForces.isOn;
		//coll.material = physicsMaterials[choseMaterial.value];

	}
}
