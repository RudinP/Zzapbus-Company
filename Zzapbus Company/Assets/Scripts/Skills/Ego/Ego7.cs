using UnityEngine;

public class Ego7 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    public void Init()
    {
        skill = new();

        skill.sinner = SinnerType.heathcliff;
        skill.dmg = 38f;

        skill.egoResource = new() {
            { SinType.luxuria, 2 },
            { SinType.invidia, 2 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.invidia;
        skill.tolerance.vul = new() { SinType.luxuria, SinType.gula };
        skill.dialog = "너도… 이 안에 담아주지!";

        skill.name = "시체자루";
        skill.sinType = SinType.invidia;
        skill.sprite = sprite;
        skill.type = SkillType.hit;
        skill.ratio = 0;
        skill.defaultDmg = 15f;
        skill.coin = 1;
        skill.coinDmg = 9f;
    }
}
