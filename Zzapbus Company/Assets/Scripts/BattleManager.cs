using System.Collections;
using System.Collections.Generic;
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
    }

    void InitNode()
    {
        
    }

    

}
