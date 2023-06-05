using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;
    
    public List<GameObject> sinners;
    public List<GameObject> abnormalities;

    public List<GameObject> sinnerSpawnPoints;
    public List<GameObject> abnormalitySpawnPoints;

    void Awake()
    {
        instance = this;
        
        sinners = new();

        for(int i = 0; i < abnormalities.Count; i++)
        {
            var abnormality = Instantiate(abnormalities[i]);
            abnormalities[i] = abnormality;
        }
        
        SinnerLoader.instance.BattleInit();
        
        Place(sinners, sinnerSpawnPoints);
        Place(abnormalities, abnormalitySpawnPoints);
    }

    void Place(List<GameObject> characters, List<GameObject> points)
    {
        Dictionary<GameObject, int> speeds = new();

        foreach(GameObject character in characters)
        {
            if (character.tag == "Sinner")
                speeds[character] = character.GetComponent<SinnerScript>().Speed;
            else if (character.tag == "Abnormality")
                speeds[character] = character.GetComponent<AbnormalityScript>().Speed;
        }

        var characterBySpeed = speeds.OrderBy(x => x.Value).ToList();

        for(int i = 0; i < points.Count; i++)
        {
            characterBySpeed[i].Key.transform.parent = points[i].transform;
            characterBySpeed[i].Key.transform.localPosition = Vector3.zero;
        }
    }


    

}
