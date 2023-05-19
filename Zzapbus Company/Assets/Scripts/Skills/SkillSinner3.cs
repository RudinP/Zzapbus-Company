using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSinner3 : MonoBehaviour
{
    public List<Skill> skills;
    public List<Sprite> sprites;

    private void Init()
    {
        Skill skill1 = new();
        skill1.name = "찌르기";
        skill1.sprite = sprites[0];
        skill1.type = SkillType.penetrate;
        skill1.sinType = SinType.luxuria ;
        skill1.ratio = 3;
        skill1.defaultDmg = 3f;
        skill1.coin = 1;
        skill1.coinDmg = 7f;
        skills.Add(skill1);

        Skill skill2 = new();
        skill2.name = "모아찌르기";
        skill2.sprite = sprites[1];
        skill2.type = SkillType.penetrate;
        skill2.sinType = SinType.invidia;
        skill2.ratio = 2;
        skill2.defaultDmg = 4f;
        skill2.coin = 1;
        skill2.coinDmg = 10f;
        skills.Add(skill2);

        Skill skill3 = new();
        skill3.name = "정의를 위해!";
        skill3.sprite = sprites[2];
        skill3.type = SkillType.penetrate;
        skill3.sinType = SinType.gula;
        skill3.ratio = 1;
        skill3.defaultDmg = 3;
        skill3.coin = 3;
        skill3.coinDmg = 3f;
        skills.Add(skill3);
    }
}
