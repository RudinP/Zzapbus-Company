using System.Collections.Generic;
using UnityEngine;

public class SinnerScript : MonoBehaviour
{

    //public string name;
    public float hp;
    public float dmg;
    public float defense;
    public int sanity;
    public float[] rumpled;
    public int minSpeed;
    public int maxSpeed;
    public SkillType tol;
    public SkillType normal;
    public SkillType vul;
    public SkillScript skill;
    public EgoScript ego;
    public Sprite portrait;
    public SinnerType sinnerType;

    Sinner sinner;


    public void Init()
    {
        sinner = new Sinner();

        sinner.charType = Type.sinner;

        sinner.name = "LCB ¼ö°¨ÀÚ";

        sinner.hp = hp;

        sinner.dmg = dmg;

        sinner.defense = defense;

        sinner.sanity = sanity;

        sinner.rumpled = rumpled;

        sinner.speed.min = minSpeed;
        sinner.speed.max = maxSpeed;

        sinner.tolerance.tol = tol;
        sinner.tolerance.normal = normal;
        sinner.tolerance.vul = vul;

        sinner.skills = skill;
        sinner.ego = ego;
        //sinner.passives = ;

        sinner.portrait = portrait;

        sinner.character = sinnerType;
    }
}
