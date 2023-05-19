using System.Collections.Generic;
using UnityEngine;

public class Sinner2 : MonoBehaviour
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

        sinner.hp = 171;

        sinner.dmg = 28f;

        sinner.sanity = 0;

        sinner.rumpled = new int[] { 110, 70, 20 };

        sinner.speed.min = 2;
        sinner.speed.max = 4;

        sinner.tolerance.tol = SkillType.penetrate;
        sinner.tolerance.normal = SkillType.hit;
        sinner.tolerance.val = SkillType.slash;

        sinner.skills = this.GetComponent<SkillSinner2>().skills;
        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.faust;

        //sinner.ego = ;
    }
}
