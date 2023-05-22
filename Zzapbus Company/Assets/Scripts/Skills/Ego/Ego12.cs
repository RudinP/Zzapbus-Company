using UnityEngine;

public class Ego12 : MonoBehaviour
{
    public Sprite sprite;
    public Ego skill;

    private void Init()
    {
        skill = new();

        skill.sinner = SinnerType.gregor;
        skill.dmg = 31f;

        skill.egoResource = new() {
            { SinType.luxuria, 3 },
            { SinType.melancholy, 1 }
        };

        skill.grade = EgoGrade.zayin;
        skill.sanity = 0;

        skill.tolerance.endure = SinType.pigritia;
        skill.tolerance.vul = new() { SinType.melancholy, SinType.invidia };
        skill.dialog = "내 팔은··· 변해있었어.";

        skill.name = "어느날 갑자기";
        skill.sinType = SinType.pigritia;
        skill.sprite = sprite;
        skill.type = SkillType.hit;
        skill.ratio = 0;
        skill.defaultDmg = 14f;
        skill.coin = 1;
        skill.coinDmg = 14f;
    }
}
