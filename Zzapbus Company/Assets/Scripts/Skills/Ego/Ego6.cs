using UnityEngine;

public class Ego6 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    private void Init()
    {
        skill = new();

        skill.sinner = SinnerType.honglu;
        skill.dmg = 33f;

        skill.egoResource = new() {
            { SinType.luxuria, 1 },
            { SinType.melancholy, 5 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.melancholy;
        skill.tolerance.vul = new() { SinType.ira, SinType.invidia };
        skill.dialog = "환상의 세계로 들어가 보죠.";

        skill.name = "허환경";
        skill.sinType = SinType.melancholy;
        skill.sprite = sprite;
        skill.type = SkillType.hit;
        skill.ratio = 0;
        skill.defaultDmg = 15f;
        skill.coin = 1;
        skill.coinDmg = 10f;
    }
}
