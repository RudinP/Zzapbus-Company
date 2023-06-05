using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;
    public List<GameObject> sinners;

    public List<GameObject> sinnerSpawnPoints;
    public List<GameObject> AbnormalitySpawnPoints;

    void Awake()
    {
        instance = this;
        sinners = new();
        SinnerLoader.instance.BattleInit();
        
        PlaceSinner();
    }

    void PlaceSinner()
    {
        Dictionary<GameObject, int> speeds = new();

        foreach(GameObject sinner in sinners)
        {
            speeds[sinner] = sinner.GetComponent<SinnerScript>().Speed;
        }

        var sinnerBySpeed = speeds.OrderBy(x => x.Value).ToList();

        for(int i = 0; i < sinnerSpawnPoints.Count; i++)
        {
            sinnerBySpeed[i].Key.transform.parent = sinnerSpawnPoints[i].transform;
            sinnerBySpeed[i].Key.transform.localPosition = Vector3.zero;
        }
    }

    

}
