using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pointer : MonoBehaviour {

	public GameObject direccion;
	private RaycastHit hit;
	public float distance = 1000;
	public GameObject botones;
	public GameObject panel;
	public Text titulo;
	public Text texto;
	// Use this for initialization
	void Start () {
	}

	void setPanel(){
		TextAsset level = Resources.Load<TextAsset> (Application.persistentDataPath +"Textos/Persististrombus_latus.txt");
		 

		titulo.text = level.text;
		//texto.text = text[1];
	}
	// Update is called once per frame
	void Update () {
		
		if (Physics.Raycast (transform.position, (direccion.transform.position - transform.position), out hit, distance)) {
			if (hit.transform.tag == "Fosiles") {
				botones.active =true;
				if (Input.GetKeyDown("joystick button 0")) {
					setPanel ();
					panel.active =true;       
				}

			} else {
				botones.active = false;

			}
		}
	}


}
