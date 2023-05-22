using UnityEngine;

public class Ego1 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    public void Init()
    {
        skill = new();

        skill.sinner = SinnerType.yisang;
        skill.dmg = 26f;

        skill.egoResource = new() {
            { SinType.ira, 1 },
            { SinType.pigritia, 3 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;
        skill.tolerance.endure = SinType.pigritia;
        skill.tolerance.vul = new() { SinType.melancholy, SinType.invidia };
        skill.dialog = "이상이 무엇이라 생각하시오.";

        skill.name = "오감도";
        skill.sprite = sprite;
        skill.type = SkillType.penetrate;
        skill.sinType = SinType.pigritia;
        skill.ratio = 0;
        skill.defaultDmg = 18f;
        skill.coin = 1;
        skill.coinDmg = 6f;
    }
}
