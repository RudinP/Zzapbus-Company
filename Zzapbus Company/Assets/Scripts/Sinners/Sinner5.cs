using System.Collections.Generic;
using UnityEngine;

public class Sinner5 : MonoBehaviour
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

        sinner.hp = 183;

        sinner.dmg = 26f;

        sinner.sanity = 0;

        sinner.rumpled = new int[] { 110, 70, 20 };

        sinner.speed.min = 2;
        sinner.speed.max = 3;

        sinner.tolerance.tol = SkillType.hit;
        sinner.tolerance.normal = SkillType.slash;
        sinner.tolerance.val = SkillType.penetrate;

        //sinner.skills = ;
        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.meursault;

        //sinner.ego = ;
    }
}
