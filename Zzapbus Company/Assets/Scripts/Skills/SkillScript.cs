using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

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

    public DefaultChar character;

    public static GameObject skillPanel;

    Skill Skill
    {
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

        for (int i = 0; i < skillCount; i++)
        {
            Skill skill = new();
            skill.nameStr = nameStr[i];
            skill.sprite = sprite[i];
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

    public void Use(int skillNum, DefaultChar sender, DefaultChar receiver)
    {
        Skill skill = availableSkills[skillNum];
        float totalDmg = skill.defaultDmg;

        for(int coin = 0; coin < skill.coin; coin++)
        {
            skillPanel.transform.GetChild(0).GetChild(coin).gameObject.SetActive(true);
        }

        skillPanel.transform.GetChild(1).GetComponent<Text>().text = skill.nameStr;
        skillPanel.transform.GetChild(2).GetChild(0).GetComponent<Image>().sprite = skill.sprite;

        skillPanel.SetActive(true);

        //나중에 여기 코루틴처리 해야할듯
        for(int coin = 0; coin < skill.coin; coin++)
        {
            character.animator.SetTrigger("attack");

            bool coinToss = skill.CoinToss(sender.Sanity);
            
            skillPanel.transform.GetChild(0).GetChild(coin).GetComponent<Image>().color = coinToss ? Color.white : Color.black;
            float dmg =  coinToss? skill.coinDmg : 0;
            
            totalDmg += dmg;
        }

        skillPanel.SetActive(false);

        receiver.Hp -= totalDmg;

        availableSkills.RemoveAt(skillNum);
        availableSkills.Add(Skill);
    }


}
