using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSinner5 : MonoBehaviour
{
    public List<Skill> skills;
    public List<Sprite> sprites;

    private void Init()
    {
        Skill skill1 = new();
        skill1.name = "¿ø, Åõ";
        skill1.sprite = sprites[0];
        skill1.type = SkillType.hit;
        skill1.sinType = SinType.pigritia;
        skill1.ratio = 3;
        skill1.defaultDmg = 2f;
        skill1.coin = 2;
        skill1.coinDmg = 4f;
        skills.Add(skill1);

        Skill skill2 = new();
        skill2.name = "ÁÖ¸Ô²È±â";
        skill2.sprite = sprites[1];
        skill2.type = SkillType.hit;
        skill2.sinType = SinType.superbia;
        skill2.ratio = 2;
        skill2.defaultDmg = 5f;
        skill2.coin = 1;
        skill2.coinDmg = 8f;
        skills.Add(skill2);

        Skill skill3 = new();
        skill3.name = "¿¬°Ý";
        skill3.sprite = sprites[2];
        skill3.type = SkillType.hit;
        skill3.sinType = SinType.melancholy;
        skill3.ratio = 1;
        skill3.defaultDmg = 4;
        skill3.coin = 4;
        skill3.coinDmg = 1f;
        skills.Add(skill3);
    }
}
