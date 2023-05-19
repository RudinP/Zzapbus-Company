using System.Collections.Generic;
using UnityEngine;

public class Sinner8 : MonoBehaviour
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

        sinner.sanity = 0;

        sinner.rumpled = new int[] { 110, 70, 20 };

        sinner.speed.min = 5;
        sinner.speed.max = 8;

        sinner.tolerance.tol = SkillType.hit;
        sinner.tolerance.normal = SkillType.penetrate;
        sinner.tolerance.val = SkillType.slash;

        //sinner.skills = ;
        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.ishmael;

        //sinner.ego = ;
    }
}
