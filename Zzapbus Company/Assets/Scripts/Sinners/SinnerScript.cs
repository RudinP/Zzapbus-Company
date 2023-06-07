using System.Collections.Generic;
using UnityEngine;

public class SinnerScript : MonoBehaviour
{

    public string nameStr = "LCB 수감자";
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

    public int Speed { 
        get {  return Random.Range(minSpeed, maxSpeed + 1); }
    }

    public void Init()
    {
        sinner = new Sinner();

        sinner.charType = Type.sinner;

        sinner.nameStr = "LCB 수감자";

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

        sinner.animator = GetComponent<Animator>();

        GetComponent<SkillScript>().character = sinner;
    }

}
