using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ego : Skill
{
    public SinnerType sinner;
    public float dmg;
    public Dictionary<SinType, int> egoResource;
    public EgoGrade grade;
    public int sanity;
    public Tolerance tolerance;
    public string dialog;

    public struct Tolerance
    {
        public SinType endure;
        public List<SinType> vul;
    }
}
