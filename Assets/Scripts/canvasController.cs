using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasController : MonoBehaviour
{

    public Camera camara;
    public Camera underWaterCamera;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (camara.enabled)
        {
            transform.LookAt(camara.transform);
        }
        else
        {
            transform.LookAt(underWaterCamera.transform);
        }



    }
}
