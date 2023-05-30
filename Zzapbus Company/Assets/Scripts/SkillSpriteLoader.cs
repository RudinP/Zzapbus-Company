using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSpriteLoader : MonoBehaviour
{

    public List<Sprite> sinSprites;
    public List<Sprite> skillTypeSprites;

    public static SkillSpriteLoader instance;

    private void Awake()
    {
        instance = this;
    }

    public Sprite ReturnSinSprite(SinType sinType)
    {
        return sinSprites[(int)sinType];
    }

    public Sprite ReturnSkillTypeSprite(SkillType skillType)
    {
        return skillTypeSprites[(int)skillType];
    }
}
