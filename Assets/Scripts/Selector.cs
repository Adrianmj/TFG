using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class  Selector : MonoBehaviour
{

    public GameObject direccion;


    private RaycastHit hit;
    public float distance = 1000;
    public GameObject botones;
    private bool showingPanel = false;

    public GameObject pointer;

    // Use this for initialization
    void Start()
    {
        pointer.transform.GetComponent<Renderer>().material.color = Color.blue;

    }

    void setPanel(string nombreFosil)
    {

        TextAsset text = (TextAsset)Resources.Load(nombreFosil, typeof(TextAsset));


        Debug.Log(text.text);
        string[] lineas = text.text.Split("\n"[0]);
        //titulo.text = lineas[0];
        //texto.text = lineas[1];
        showingPanel = true;


    }
    // Update is called once per frame
    void Update()
    {


        if (Physics.Raycast(transform.position, (direccion.transform.position - transform.position), out hit, distance))
        {
            if (hit.transform.tag == "Fosiles" && !showingPanel)
            {
                pointer.transform.GetComponent<Renderer>().material.color = Color.red;
                NombreGlobal.nombre = hit.transform.name;
                botones.SetActive(true);

            }
            else
            {
                pointer.transform.GetComponent<Renderer>().material.color = Color.blue;
                NombreGlobal.nombre = "";
                botones.SetActive(false);

            }
        }

        if (Input.GetKeyDown("joystick button 1"))
        {
            showingPanel = false;
            //panel.SetActive(false);
        }
    }


    public static class NombreGlobal
    {
        public static string nombre;

    }

}
