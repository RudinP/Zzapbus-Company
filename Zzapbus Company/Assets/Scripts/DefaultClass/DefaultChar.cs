using System;
using System.Collections.Generic;
using UnityEngine;

public class DefaultChar
{
    public struct Speed { public int min, max; }

    public struct Tolerance
    {
        public SkillType tol, endure, normal, vul;
    }

    public Type charType;
    
    public string nameStr;

    public float hp;

    public float Hp
    {
        get => hp;
        set
        {
            hp = value < 0 ? 0 : value; 
        }
    }

    public float dmg;

    public float defense;

    public int sanity = 0;

    public int Sanity
    {
        get => sanity;
        set
        {
            sanity = Math.Abs(value) <= 45 ? value : (value < 0 ? -45 : 45);
        }
    }

    public float[] rumpled;

    public Speed speed;

    public Tolerance tolerance;

    public SkillScript skills;

    public List<Passive> passives;

    public Animator animator;

    public bool Die 
    {
        get => this.hp < 0 ? true : false;
    }

}
