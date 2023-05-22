using UnityEngine;

public class Ego4 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    public void Init()
    {
        skill = new();

        skill.sinner = SinnerType.ryosyu;
        skill.dmg = 32f;

        skill.egoResource = new() {
            { SinType.ira, 2 },
            { SinType.luxuria, 2 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.luxuria;
        skill.tolerance.vul = new() { SinType.gula, SinType.invidia };
        skill.dialog = "모.불.아.위. (모든 것을 불살라서라도, 아름다움을 위해.)";

        skill.name = "삼라염상";
        skill.sprite = sprite;
        skill.type = SkillType.slash;
        skill.sinType = SinType.superbia;
        skill.ratio = 0;
        skill.defaultDmg = 18f;
        skill.coin = 1;
        skill.coinDmg = 6f;
    }
}
