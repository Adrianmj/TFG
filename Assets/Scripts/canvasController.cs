using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasController : MonoBehaviour {

	public Camera camara;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(camara.transform);

        //Selector prueba = new Selector();
        //if (Input.GetKeyDown("joystick button 0") && Selector.NombreGlobal.nombre == transform.parent.name)
        //{
        //    Debug.Log(Selector.NombreGlobal.nombre);

        //}
        //transform.LookAt(camara.transform);
        //RectTransform cuadrado = GetComponent<RectTransform>();
        //cuadrado.localPosition = new Vector3(0, cuadrado.localPosition.y, cuadrado.localPosition.z);
    }
}
