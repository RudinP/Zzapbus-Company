using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;

    public List<GameObject> sinners;

    void Awake()
    {
        instance = this;
        sinners = new();
        SinnerLoader.instance.BattleInit();
    }

}
