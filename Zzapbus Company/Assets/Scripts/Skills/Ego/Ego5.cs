using UnityEngine;

public class Ego5 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    private void Init()
    {
        skill = new();

        skill.sinner = SinnerType.meursault;
        skill.dmg = 28f;

        skill.egoResource = new() {
            { SinType.pigritia, 1 },
            { SinType.melancholy, 1 },
            { SinType.invidia,2 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.superbia;
        skill.tolerance.vul = new() { SinType.luxuria, SinType.gula };
        skill.dialog = "수많은 것들이 옥죄어 온다···";

        skill.name = "타인의 사슬";
        skill.sprite = sprite;
        skill.type = SkillType.hit;
        skill.sinType = SinType.superbia;
        skill.ratio = 0;
        skill.defaultDmg = 19f;
        skill.coin = 1;
        skill.coinDmg = 3f;
    }
}
