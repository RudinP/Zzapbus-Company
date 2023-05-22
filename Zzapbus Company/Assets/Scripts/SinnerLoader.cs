using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinnerLoader : MonoBehaviour
{
    public List<GameObject> sinners;

    public void Awake()
    {
        foreach(GameObject sinner in sinners)
        {
            sinner.GetComponent<SkillScript>().Init();
            sinner.GetComponent<EgoScript>().Init();
            sinner.GetComponent<SinnerScript>().Init();
        }
    }
}
