using UnityEngine;

public class Ego9 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    public void Init()
    {
        skill = new();

        skill.sinner = SinnerType.rodion;
        skill.dmg = 33f;

        skill.egoResource = new() {
            { SinType.melancholy, 1 },
            { SinType.superbia, 3 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.superbia;
        skill.tolerance.vul = new() { SinType.melancholy, SinType.invidia };
        skill.dialog = "모든 걸 거둬들일 수는 없었어···";

        skill.name = "던져지는 것";
        skill.sinType = SinType.superbia;
        skill.sprite = sprite;
        skill.type = SkillType.slash;
        skill.ratio = 0;
        skill.defaultDmg = 15f;
        skill.coin = 1;
        skill.coinDmg = 13f;
    }
}
