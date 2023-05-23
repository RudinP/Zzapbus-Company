using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillScript : MonoBehaviour
{
    public List<Skill> skills;

    int skillCount = 3;
    public List<string> name;
    public List<Sprite> sprite;
    public List<SkillType> type;
    public List<SinType> sinType;
    public List<int> ratio;
    public List<float> defaultDmg;
    public List<int> coin;
    public List<float> coinDmg;

    public void Init()
    {
        skills = new();
        for(int i = 0; i < skillCount; i++)
        {
            Skill skill = new();
            skill.name = name[i];
            //skill.sprite = sprite[i];
            skill.type = type[i];
            skill.sinType = sinType[i];
            skill.ratio = ratio[i];
            skill.defaultDmg = defaultDmg[i];
            skill.coin = coin[i];
            skill.coinDmg = coinDmg[i];

            skills.Add(skill);
        }
    }
}
