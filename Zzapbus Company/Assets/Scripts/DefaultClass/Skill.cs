using UnityEngine;

public class Skill
{ 
    public Sprite sprite;

    SkillType type;

    SinType sinType;

    float defaultDmg;
    
    int coin;

    float coinConf;

    string info;

    public virtual void Use(){ }
   
}
