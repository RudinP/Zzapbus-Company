using UnityEngine;

public class Skill
{ 
    public Sprite sprite;

    DmgType dmgType;

    DefenseType defenseType;

    SinType sinType;

    float defaultDmg;
    
    int coin;

    float coinConf;

    string info;

    public virtual void Use(){ }
   
}
