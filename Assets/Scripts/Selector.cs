using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Selector : MonoBehaviour
{

    public GameObject direccion;


    private RaycastHit hit;
    public float distance = 100;
    public GameObject botones;
    private bool showingPanel = false;
    public GameObject panel;
    public GameObject pointer;
    public Camera camara;

    public Text titulo;
    public Text texto;
    // Use this for initialization
    void Start()
    {
        pointer.transform.GetComponent<Renderer>().material.color = Color.blue;

    }

    void setPanel(string nombreFosil)
    {
        TextAsset text = (TextAsset)Resources.Load(nombreFosil, typeof(TextAsset));

        string[] lineas = text.text.Split("\n"[0]);
        titulo.text = lineas[0];
        texto.text = "";
        for (int i = 1; i < lineas.Length; i++)
        {
            texto.text += ("\n" + lineas[i]);
        }

        showingPanel = true;
        panel.transform.position = new Vector3(hit.transform.position.x, transform.position.y + 5, hit.transform.position.z);
        panel.transform.LookAt(camara.transform);
        panel.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {

        pointer.transform.GetComponent<Renderer>().material.color = Color.blue;
        botones.SetActive(false);
        if (Physics.Raycast(transform.position, (direccion.transform.position - transform.position), out hit, distance))
        {
            if (hit.transform.tag == "Fosiles" /*&& !showingPanel*/)
            {
                pointer.transform.GetComponent<Renderer>().material.color = Color.red;
                botones.SetActive(true);
                if (Input.GetKeyDown("joystick button 0"))
                {


                    setPanel(hit.transform.name);
                }
            }

        }

        if (Input.GetKeyDown("joystick button 1"))
        {
            showingPanel = false;
            panel.SetActive(false);
        }
    }




}
