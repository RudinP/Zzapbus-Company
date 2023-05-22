using UnityEngine;

public class Ego8 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    private void Init()
    {
        skill = new();

        skill.sinner = SinnerType.ishmael;
        skill.dmg = 26f;

        skill.egoResource = new() {
            { SinType.ira, 2 },
            { SinType.melancholy, 2 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.melancholy;
        skill.tolerance.vul = new() { SinType.luxuria, SinType.pigritia };
        skill.dialog = "그 자식은··· 아직 살아있을 거야.";

        skill.name = "작살박이";
        skill.sinType = SinType.melancholy;
        skill.sprite = sprite;
        skill.type = SkillType.hit;
        skill.ratio = 0;
        skill.defaultDmg = 19f;
        skill.coin = 1;
        skill.coinDmg = 4f;
    }
}
