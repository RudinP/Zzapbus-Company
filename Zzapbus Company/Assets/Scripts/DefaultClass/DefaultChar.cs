using System.Collections.Generic;

public class DefaultChar
{
    struct speed { int min, max; }

    struct tolerance
    {
        DmgType tol;
        DmgType endure;
        DmgType normal;
        DmgType vul;
    }

    Type charType;

    string name;

    float hp;

    float defenseConf;

    List<Skill> skills;

    public virtual void Passive() { }

}
