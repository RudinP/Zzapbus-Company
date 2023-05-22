using System.Collections.Generic;
using UnityEngine;

public class Sinner10 : MonoBehaviour
{
    public Sprite portrait;

    Sinner sinner;

    public void Init()
    {
        sinner = new Sinner();

        sinner.charType = Type.sinner;

        sinner.name = "LCB ������";

        sinner.hp = 122;

        sinner.dmg = 38f;

        sinner.defense = 26f;

        sinner.sanity = 0;

        sinner.rumpled = new int[] { 110, 70, 20 };

        sinner.speed.min = 3;
        sinner.speed.max = 7;

        sinner.tolerance.tol = SkillType.slash;
        sinner.tolerance.normal = SkillType.hit;
        sinner.tolerance.val = SkillType.penetrate;

        sinner.skills = this.GetComponent<SkillSinner10>().skills;
        sinner.ego = this.GetComponent<Ego10>().skill;

        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.sinclair;
    }
}
