using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbnormalityScript : MonoBehaviour
{
    public string nameStr;
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
    public SinType vulSin;
    public SkillScript skill;
    
    Abnormality abnormality;
    public int Speed
    {
        get { return Random.Range(minSpeed, maxSpeed + 1); }
    }

    public void Init()
    {
        abnormality = new Abnormality();

        abnormality.charType = Type.abnormality;

        abnormality.nameStr = nameStr;

        abnormality.hp = hp;

        abnormality.dmg = dmg;

        abnormality.defense = defense;

        abnormality.sanity = sanity;

        abnormality.rumpled = rumpled;

        abnormality.speed.min = minSpeed;
        abnormality.speed.max = maxSpeed;

        abnormality.tolerance.tol = tol;
        abnormality.tolerance.normal = normal;
        abnormality.tolerance.vul = vul;
        abnormality.vulSin = vulSin;

        abnormality.skills = skill;

        //abnormality.passives = ;

    }
}
