using System.Collections.Generic;
using UnityEngine;

public class Sinner9 : MonoBehaviour
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

        sinner.hp = 159;

        sinner.dmg = 33f;

        sinner.sanity = 0;

        sinner.rumpled = new int[] { 110, 70, 20 };

        sinner.speed.min = 2;
        sinner.speed.max = 5;

        sinner.tolerance.tol = SkillType.slash;
        sinner.tolerance.normal = SkillType.hit;
        sinner.tolerance.val = SkillType.penetrate;

        sinner.skills = this.GetComponent<SkillSinner9>().skills;
        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.rodion;

        //sinner.ego = ;
    }
}
