using System.Collections.Generic;

public class DefaultChar
{
    public struct Speed { public int min, max; }

    public struct Tolerance
    {
        public SkillType tol, endure, normal, vul;
    }

    public Type charType;
    
    public string name;

    public float hp;

    public float dmg;

    public float defense;

    public int sanity;

    public float[] rumpled;

    public Speed speed;

    public Tolerance tolerance;

    public SkillScript skills;

    public List<Passive> passives;

}
