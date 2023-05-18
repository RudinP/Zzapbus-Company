using System.Collections.Generic;
using UnityEngine;

public class Sinner1 : MonoBehaviour
{
    public Sprite portrait;

    Sinner sinner1;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        sinner1 = new Sinner();

        sinner1.charType = Type.sinner;

        sinner1.name = "LCB ¼ö°¨ÀÚ";

        sinner1.hp = 146;

        sinner1.speed.min = 4;
        sinner1.speed.max = 8;

        sinner1.tolerance.tol = SkillType.penetrate;
        sinner1.tolerance.normal = SkillType.hit;
        sinner1.tolerance.val = SkillType.slash;

        //sinner1.skills = ;
        //sinner1.passives = ;

        sinner1.portrait = portrait;

        sinner1.character = SinnerType.yisang;

        //sinner1.ego = ;
    }
}
