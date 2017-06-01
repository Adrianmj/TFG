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
	private bool showingPanel=false;
	// Use this for initialization
	void Start () {
	}

	void setPanel(){
		
		//TextAsset level = Resources.Load("Resources/Textos/Persististrombus_latus.txt") as TextAsset; 

		
		TextAsset text = (TextAsset) Resources.Load( "Persististrombuslatus", typeof( TextAsset ) );


		Debug.Log (text.text);
		string [] lineas = text.text.Split("\n"[0]);
		titulo.text = lineas[0];
		texto.text = lineas[1];
		showingPanel = true;
	}
	// Update is called once per frame
	void Update () {
		
		if (Physics.Raycast (transform.position, (direccion.transform.position - transform.position), out hit, distance)) {
			if (hit.transform.tag == "Fosiles" && !showingPanel) {
				botones.active =true;
				if (Input.GetKeyDown("joystick button 0")) {
					setPanel ();
					panel.active =true;       
				}

			} else {
				botones.active = false;

			}
		}

		if(Input.GetKeyDown("joystick button 1")){
			showingPanel = false;
			panel.active = false;
		}
	}


}
