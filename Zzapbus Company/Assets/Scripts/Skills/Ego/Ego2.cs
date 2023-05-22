using UnityEngine;

public class Ego2 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    public void Init()
    {
        skill = new();

        skill.sinner = SinnerType.faust;
        skill.dmg = 26f;

        skill.egoResource = new() {
            { SinType.gula, 2 },
            { SinType.superbia, 4 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.superbia;
        skill.tolerance.vul = new() { SinType.luxuria, SinType.gula };
        skill.dialog = "모든 결과들은 파우스트가 알아요.";

        skill.name = "표상방출기";
        skill.sprite = sprite;
        skill.type = SkillType.hit;
        skill.sinType = SinType.superbia;
        skill.ratio = 0;
        skill.defaultDmg = 19f;
        skill.coin = 1;
        skill.coinDmg = 4f;
    }
}
