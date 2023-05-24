using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinnerLoader : MonoBehaviour
{
    public static SinnerLoader instance;
    public List<GameObject> sinners;
    public List<GameObject> selectedSinners;

    public void Awake()
    {
        Init();

        foreach(GameObject sinner in sinners)
        {
            sinner.GetComponent<SkillScript>().Init();
            sinner.GetComponent<EgoScript>().Init();
            sinner.GetComponent<SinnerScript>().Init();
        }   
    }

    private void Init()
    {
        if (instance)
        {
            Destroy(this);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void BattleInit()
    {
        foreach (GameObject sinner in selectedSinners)
        {
            BattleManager.instance.sinners.Add(Instantiate(sinner));
        }
    }

    
        
}
