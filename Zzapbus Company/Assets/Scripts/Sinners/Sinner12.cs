using System.Collections.Generic;
using UnityEngine;

public class Sinner12 : MonoBehaviour
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

        sinner.hp = 146;

        sinner.sanity = 0;

        sinner.rumpled = new int[] { 110, 70, 20 };

        sinner.speed.min = 3;
        sinner.speed.max = 7;

        sinner.tolerance.tol = SkillType.penetrate;
        sinner.tolerance.normal = SkillType.slash;
        sinner.tolerance.val = SkillType.hit;

        //sinner.skills = ;
        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.gregor;

        //sinner.ego = ;
    }
}
