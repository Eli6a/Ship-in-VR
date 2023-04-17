using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    public GameObject pointLightsParent;
    [SerializeField]
    private float pointIntensityMax = 1500f;

    public GameObject spotLightsParent;
    [SerializeField]
    private float spotIntensityMax = 40000f;

    public GameObject areaLightsParent;
    [SerializeField]
    private float areaIntensityMax = 40000f;

    public void ChangeIntensity(float intensity)
    {
        if (spotLightsParent != null || spotLightsParent.transform.childCount < 1)
        {
            ChangeChildrenIntensity(pointLightsParent, intensity);
        }
        if (pointLightsParent != null || pointLightsParent.transform.childCount < 1)
        {
            ChangeChildrenIntensity(spotLightsParent, intensity);
        }
        if (areaLightsParent != null || areaLightsParent.transform.childCount < 1)
        {
            ChangeChildrenIntensity(areaLightsParent, intensity);
        }
    }

    void ChangeChildrenIntensity(GameObject parent, float intensity)
    {
        float newIntensity;

        if (parent == pointLightsParent)
        {
            newIntensity = pointIntensityMax * intensity;
        }
        else
        {
            newIntensity = spotIntensityMax * intensity;
        }

        for (int i = 0; i < parent.transform.childCount; i++)
        {
            parent.transform.GetChild(i).GetComponent<Light>().intensity = newIntensity;
        }
    }
}
