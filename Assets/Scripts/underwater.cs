using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class underwater : MonoBehaviour
{

    public GameObject alturaActual;
    public GameObject waterlevel;

    private bool isUnderWater = false;
    private Color normalColor;
    public Color underWaterColor;
    public Camera camara;
    void Start()
    {

        normalColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);

    }

    void Update()
    {


        if ((alturaActual.transform.position.y < waterlevel.transform.position.y - 9) != isUnderWater)
        {

            isUnderWater = alturaActual.transform.position.y < waterlevel.transform.position.y - 9;

            if (isUnderWater)
            {
                SetUnderWater();
            }

            if (!isUnderWater)
            {

                SetNormal();
            }

        }

    }

    void SetNormal()
    {
        Debug.Log("OVERWATER");
        camara.farClipPlane = 100;
        RenderSettings.fogColor = normalColor;
        RenderSettings.fogDensity = 0.002f;

    }
    void SetUnderWater()
    {
        Debug.Log("UNDERWATER");
        camara.farClipPlane = 500;
        RenderSettings.fogColor = underWaterColor;
        RenderSettings.fogDensity = 0.01f;

    }
}
