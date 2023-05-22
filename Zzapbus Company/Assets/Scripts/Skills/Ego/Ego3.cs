using UnityEngine;

public class Ego3 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    private void Init()
    {
        skill = new();

        skill.sinner = SinnerType.donquixote;
        skill.dmg = 36f;

        skill.egoResource = new() {
            { SinType.luxuria, 2 },
            { SinType.superbia, 2 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.luxuria;
        skill.tolerance.vul = new() { SinType.ira, SinType.melancholy };
        skill.dialog = "달려라 로시난테! 정의는 승리한다!";

        skill.name = "라 샹그레 데 산쵸";
        skill.sprite = sprite;
        skill.type = SkillType.penetrate;
        skill.sinType = SinType.luxuria;
        skill.ratio = 0;
        skill.defaultDmg = 12f;
        skill.coin = 1;
        skill.coinDmg = 11f;
    }
}
