using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseSkill : Skill
{
    public DefenseSkill(string name,SkillType type, float defaultDmg, float coinDmg)
    {
        this.name = name;
        this.type = type;
        this.defaultDmg = defaultDmg;
        this.coinDmg = coinDmg;

        sinType = SinType.none;
        ratio = 0;
        coin = 1;
        //sprite = Resources.Load<Sprite>("Sprites/ + type.ToString()");
    }
    
}
