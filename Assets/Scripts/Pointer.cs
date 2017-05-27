using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pointer : MonoBehaviour {

	public GameObject direccion;
	private RaycastHit hit;
	public float distance = 1000;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Physics.Raycast (transform.position, (direccion.transform.position - transform.position), out hit, distance)) {
			if (hit.transform.tag == "Fosiles") {
				Debug.Log ("FOSIL TE VEO");
			} else {
				Debug.Log (hit.transform.name);
			}
		}
	}


}
