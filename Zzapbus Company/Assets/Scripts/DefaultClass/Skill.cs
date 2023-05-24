using UnityEngine;

public class Skill
{
    public string nameStr;

    public Sprite sprite;

    public SkillType type;

    public SinType sinType;

    public int ratio;

    public float defaultDmg;
    
    public int coin;

    public float coinDmg;

    public virtual void Use(){ }
   
}
