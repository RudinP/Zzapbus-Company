using UnityEngine;

public class Ego11 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    private void Init()
    {
        skill = new();

        skill.sinner = SinnerType.outis;
        skill.dmg = 38f;

        skill.egoResource = new() {
            { SinType.pigritia, 2 },
            { SinType.superbia, 2 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.superbia;
        skill.tolerance.vul = new() { SinType.luxuria, SinType.invidia };
        skill.dialog = "���࿣ ������ �־���������";

        skill.name = "�� ���佺 ���佺";
        skill.sinType = SinType.superbia;
        skill.sprite = sprite;
        skill.type = SkillType.penetrate;
        skill.ratio = 0;
        skill.defaultDmg = 20f;
        skill.coin = 1;
        skill.coinDmg = 3f;
    }
}
