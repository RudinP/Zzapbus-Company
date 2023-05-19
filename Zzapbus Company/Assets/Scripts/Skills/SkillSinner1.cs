using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSinner1 : MonoBehaviour
{
    public List<Skill> skills;
    public List<Sprite> sprites;

    private void Init()
    {
        Skill skill1 = new();
        skill1.name = "쳐내기";
        skill1.sprite = sprites[0];
        skill1.type = SkillType.slash;
        skill1.sinType = SinType.melancholy;
        skill1.ratio = 3;
        skill1.defaultDmg = 3f;
        skill1.coin = 1;
        skill1.coinDmg = 7f;
        skills.Add(skill1);

        Skill skill2 = new();
        skill2.name = "밀어찌르기";
        skill2.sprite = sprites[1];
        skill2.type = SkillType.penetrate;
        skill2.sinType = SinType.invidia;
        skill2.ratio = 2;
        skill2.defaultDmg = 4f;
        skill2.coin = 2;
        skill2.coinDmg = 4f;
        skills.Add(skill2);

        Skill skill3 = new();
        skill3.name = "연격";
        skill3.sprite = sprites[2];
        skill3.type = SkillType.slash;
        skill3.sinType = SinType.pigritia;
        skill3.ratio = 1;
        skill3.defaultDmg = 6;
        skill3.coin = 3;
        skill3.coinDmg = 1f;
        skills.Add(skill3);

        DefenseSkill defenseSkill = new DefenseSkill("가드", SkillType.defense, 7f, 3f);
        skills.Add(defenseSkill);
    }
}
