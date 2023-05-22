using System.Collections.Generic;
using UnityEngine;

public class Sinner6 : MonoBehaviour
{
    public Sprite portrait;

    Sinner sinner;

    private void Awake()
    {
        Init();
    }

    private void Init()
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

        sinner.tolerance.tol = SkillType.hit;
        sinner.tolerance.normal = SkillType.penetrate;
        sinner.tolerance.val = SkillType.slash;

        sinner.skills = this.GetComponent<SkillSinner6>().skills;
        sinner.ego = this.GetComponent<Ego6>().skill;

        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.honglu;

        //sinner.ego = ;
    }
}
