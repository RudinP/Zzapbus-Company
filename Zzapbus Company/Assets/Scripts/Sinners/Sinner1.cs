using System.Collections.Generic;
using UnityEngine;

public class Sinner1 : MonoBehaviour
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

        sinner.dmg = 28f;

        sinner.sanity = 0;

        sinner.rumpled = new int[]{110, 70, 20};

        sinner.speed.min = 4;
        sinner.speed.max = 8;

        sinner.tolerance.tol = SkillType.penetrate;
        sinner.tolerance.normal = SkillType.hit;
        sinner.tolerance.val = SkillType.slash;
        
        sinner.skills = this.GetComponent<SkillSinner1>().skills;
        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = SinnerType.yisang;

        //sinner.ego = ;
    }

    private void SkillInit()
    {

    }
}
