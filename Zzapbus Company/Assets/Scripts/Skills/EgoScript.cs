using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EgoScript : MonoBehaviour
{
    public Ego skill;

    public SinnerType sinnerType;
    public float dmg;
    public List<SinType> sinTypes;
    public List<int> sinCounts;
    public EgoGrade grade;
    public int sanity;
    public List<SinType> endure;
    public List<SinType> vul;
    public string dialog;
    public string name;
    public Sprite sprite;
    public SkillType type;
    public SinType sinType;
    public int defaultDmg;
    public int coinDmg;

    public void Init()
    {
        skill = new();

        skill.sinner = sinnerType;
        skill.dmg = dmg;

        skill.egoResource = new(); 
        for(int index = 0; index < sinTypes.Count; index++)
        {
            skill.egoResource.Add(sinTypes[index], sinCounts[index]);
        }

        skill.grade = grade;
        skill.sanity = sanity;
        skill.tolerance.endure = endure;
        skill.tolerance.vul = sinTypes;
        skill.dialog = dialog;

        skill.name = name;
        //skill.sprite = sprite;
        skill.type = type;
        skill.sinType = sinType;
        skill.ratio = 0;
        skill.defaultDmg = defaultDmg;
        skill.coin = 1;
        skill.coinDmg = coinDmg;
    }
}
