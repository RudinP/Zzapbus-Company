using System.Collections.Generic;
using UnityEngine;

public class Sinner4 : MonoBehaviour
{
    public Sprite portrait;

    Sinner sinner;

    public void Init()
    {
        sinner = new Sinner();

        sinner.charType = Type.sinner;

        sinner.name = "LCB ¼ö°¨ÀÚ";

        sinner.hp = 134;

        sinner.dmg = 36f;

        sinner.defense = 28f;


        sinner.sanity = 0;

        sinner.rumpled = new int[] { 110, 70, 20 };

        sinner.speed.min = 3;
        sinner.speed.max = 6;

        sinner.tolerance.tol = SkillType.slash;
        sinner.tolerance.normal = SkillType.penetrate;
        sinner.tolerance.val = SkillType.hit;

        sinner.skills = this.GetComponent<SkillSinner4>().skills;
        sinner.ego = this.GetComponent<Ego4>().skill;

        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.ryosyu;
    }
}
