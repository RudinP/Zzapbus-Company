using UnityEngine;

public class Ego10 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    private void Init()
    {
        skill = new();

        skill.sinner = SinnerType.sinclair;
        skill.dmg = 38f;

        skill.egoResource = new() {
            { SinType.ira, 1 },
            { SinType.gula, 3 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.gula;
        skill.tolerance.vul = new() { SinType.ira, SinType.superbia };
        skill.dialog = "���� ������ �߶� �� �ִٸ�...";

        skill.name = "���ĳ����� ����";
        skill.sinType = SinType.gula;
        skill.sprite = sprite;
        skill.type = SkillType.slash;
        skill.ratio = 0;
        skill.defaultDmg = 14f;
        skill.coin = 1;
        skill.coinDmg = 15f;
    }
}
