using System.Collections.Generic;
using UnityEngine;

public class Sinner3 : MonoBehaviour
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

        sinner.name = "LCB ������";

        sinner.hp = 134;

        sinner.sanity = 0;

        sinner.rumpled = new int[] { 110, 70, 20 };

        sinner.speed.min = 3;
        sinner.speed.max = 6;

        sinner.tolerance.tol = SkillType.penetrate;
        sinner.tolerance.normal = SkillType.slash;
        sinner.tolerance.val = SkillType.hit;

        //sinner.skills = ;
        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.donquixote;

        //sinner.ego = ;
    }
}