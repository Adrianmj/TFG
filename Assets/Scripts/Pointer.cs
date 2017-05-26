using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pointer : MonoBehaviour {

	public Text titulo;
	public Text texto;
	private List<string> colisiones;
	// Use this for initialization
	void Start () {
		colisiones = new List<string> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col){
//		if (col.gameObject.tag == "Fosiles") {
//			Debug.Log ("Nombre: " + col.gameObject.name);
//		}

	}
	void OnCollisionStay(Collision col){
//		if (col.gameObject.tag == "Fosiles") {
//
//			if(!colisiones.Contains(col.gameObject.name)){
//				colisiones.Add(col.gameObject.name);
//			}
//			Debug.Log (colisiones.Count);
//			Debug.Log ("ESTA COLISIONANDO CON: " + col.gameObject.name);
//		}
	}
}
