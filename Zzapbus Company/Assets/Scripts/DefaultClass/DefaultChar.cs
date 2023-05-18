using System.Collections.Generic;

public class DefaultChar
{
    public struct Speed { public int min, max; }

    public struct Tolerance
    {
        public SkillType tol, endure, normal, val;
    }

    public Type charType;
    
    public string name;

    public float hp;

    public Speed speed;

    public Tolerance tolerance;

    public List<Skill> skills;

    public List<Passive> passives;

}
