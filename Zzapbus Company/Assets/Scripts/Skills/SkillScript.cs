using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SkillScript : MonoBehaviour
{
    public List<Skill> skills;
    public List<Skill> availableSkills;

    private int skillCount;
    public List<string> nameStr;
    public List<Sprite> sprite;
    public List<SkillType> type;
    public List<SinType> sinType;
    public List<int> ratio;
    public List<float> defaultDmg;
    public List<int> coin;
    public List<float> coinDmg;
    Skill Skill { 
        get 
        {
            int skillNum = Random.Range(0, skills.Sum(x => x.ratio) + 1);// 1 2 3 ~6

            if (skillNum < skills[2].ratio) // 0
                return skills[2];
            else if (skillNum < skills[2].ratio + skills[1].ratio) // 1 2
                return skills[1];
            else
                return skills[0]; // 3 4 5 
        } 
    }

    public void Init()
    {
        skills = new();
        skillCount = 4;

        for(int i = 0; i < skillCount; i++)
        {
            Skill skill = new();
            skill.nameStr = nameStr[i];
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
    
    public void InitBattleSkill()
    {
        availableSkills = new();

        for (int i = 0; i < 3; i++)
        {
            availableSkills.Add(Skill);
        }
    }

    public void Use(int skillNum)
    {
        availableSkills.RemoveAt(skillNum);
        availableSkills.Add(Skill);
    }
}
