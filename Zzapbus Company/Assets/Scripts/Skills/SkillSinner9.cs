﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSinner9 : MonoBehaviour
{
    public List<Skill> skills;
    public List<Sprite> sprites;

    private void Init()
    {
        Skill skill1 = new();
        skill1.name = "내려찍기";
        skill1.sprite = sprites[0];
        skill1.type = SkillType.slash;
        skill1.sinType = SinType.gula;
        skill1.ratio = 3;
        skill1.defaultDmg = 3f;
        skill1.coin = 1;
        skill1.coinDmg = 7f;
        skills.Add(skill1);

        Skill skill2 = new();
        skill2.name = "연속베기";
        skill2.sprite = sprites[1];
        skill2.type = SkillType.slash;
        skill2.sinType = SinType.superbia;
        skill2.ratio = 2;
        skill2.defaultDmg = 4f;
        skill2.coin = 2;
        skill2.coinDmg = 4f;
        skills.Add(skill2);

        Skill skill3 = new();
        skill3.name = "처단";
        skill3.sprite = sprites[2];
        skill3.type = SkillType.slash;
        skill3.sinType = SinType.ira;
        skill3.ratio = 1;
        skill3.defaultDmg = 2;
        skill3.coin = 4;
        skill3.coinDmg = 2f;
        skills.Add(skill3);

        DefenseSkill defenseSkill = new DefenseSkill("반격", SkillType.counter, 7f, 4f);
        skills.Add(defenseSkill);
    }
}