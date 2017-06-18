using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class underwater : MonoBehaviour
{

    public GameObject alturaActual;
    public GameObject waterlevel;

    private bool isUnderWater = true;
    private Color normalColor;
    public Color underWaterColor;
    public Camera camara;
    public Camera underWaterCamera;

    public UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController fps;
    void Start()
    {

        normalColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);

    }

    void Update()
    {


        if ((alturaActual.transform.position.y < waterlevel.transform.position.y - 9) && !isUnderWater)
        {
            SetUnderWater();
            isUnderWater = true;

        }
        else if((alturaActual.transform.position.y > waterlevel.transform.position.y - 9) && isUnderWater)
        {
            SetNormal();
            isUnderWater = false;
        }

    }

    void SetNormal()
    {
        camara.gameObject.SetActive(true);
        camara.tag = "GuiCamera";

        underWaterCamera.tag = "Untagged";
        underWaterCamera.gameObject.SetActive(false);

        

        fps.cam = camara;

        RenderSettings.fogColor = normalColor;
        RenderSettings.fogDensity = 0.002f;

    }
    void SetUnderWater()
    {
        underWaterCamera.gameObject.SetActive(true);
        underWaterCamera.tag = "GuiCamera";

        fps.cam = underWaterCamera;

        camara.tag = "Untagged";
        camara.gameObject.SetActive(false);
        //camara.clearFlags = CameraClearFlags.SolidColor;
        RenderSettings.fogColor = underWaterColor;
        RenderSettings.fogDensity = 0.05f;
    }
}
