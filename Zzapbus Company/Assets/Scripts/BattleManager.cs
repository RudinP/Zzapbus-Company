using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;

    public List<GameObject> sinners;
    public List<GameObject> abnormalities;

    public List<GameObject> sinnerSpawnPoints;
    public List<GameObject> abnormalitySpawnPoints;

    public List<GameObject> skillList;

    public GameObject skillPanel;

    public GameObject targetArrow;

    Dictionary<GameObject, GameObject> sinnerToAb;
    Dictionary<GameObject, GameObject> abToSinner;

    void Awake()
    {
        instance = this;

        sinners = new();
        SinnerLoader.instance.BattleInit();

        Init();

        Place(sinners, sinnerSpawnPoints);
        Place(abnormalities, abnormalitySpawnPoints);
    }

    void Init()
    {
        for (int i = 0; i < 5; i++)
        {
            var abnormality = Instantiate(abnormalities[i]);

            abnormality.GetComponent<SkillScript>().Init();
            abnormality.GetComponent<AbnormalityScript>().Init();
            abnormality.GetComponent<SkillScript>().InitBattleSkill();

            abnormalities[i] = abnormality;

            var sinner = sinners[i];
            sinner.GetComponent<SkillScript>().Init();
            sinner.GetComponent<SinnerScript>().Init();
            sinner.GetComponent<SkillScript>().InitBattleSkill();
        }

        SkillScript.skillPanel = skillPanel;
        sinnerToAb = new();
    }

    void Place(List<GameObject> characters, List<GameObject> points)
    {
        Dictionary<GameObject, int> speeds = new();

        foreach (GameObject character in characters)
        {
            if (character.tag == "Sinner")
                speeds[character] = character.GetComponent<SinnerScript>().Speed;
            else if (character.tag == "Abnormality")
                speeds[character] = character.GetComponent<AbnormalityScript>().Speed;
        }

        var characterBySpeed = speeds.OrderBy(x => x.Value).ToList();

        for (int i = 0; i < points.Count; i++)
        {
            characterBySpeed[i].Key.transform.parent = points[i].transform;
            characterBySpeed[i].Key.transform.localPosition = Vector3.zero;

            LinkSpeed(points[i], characterBySpeed[i].Value);

            if (characterBySpeed[i].Key.tag == "Abnormality")
            {
                SkillScript skill = characterBySpeed[i].Key.GetComponent<SkillScript>();
                LinkNode(points[i], skill.availableSkills[0]);
            }
        }

        if (characters[0].tag == "Abnormality")
        {
            TargetSinner(sinners.Count);
            return;
        }


        characterBySpeed.Reverse();

        LinkSkillPanel(characterBySpeed);

    }

    void LinkSpeed(GameObject point, int speed)
    {
        point.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = speed.ToString();
    }

    void LinkSkillPanel(List<KeyValuePair<GameObject, int>> characterBySpeed)
    {
        for (int i = 0; i < characterBySpeed.Count; i++)
        {
            skillList[i].transform.
                GetChild(2).
                GetChild(0).GetComponent<Image>().sprite = characterBySpeed[i].Key.GetComponent<SkillScript>().availableSkills[0].sprite;

            skillList[i].transform.
                GetChild(1).
                GetChild(0).GetComponent<Image>().sprite = characterBySpeed[i].Key.GetComponent<SkillScript>().availableSkills[1].sprite;

            skillList[i].transform.
                GetChild(0).
                GetChild(0).GetComponent<Image>().sprite = characterBySpeed[i].Key.GetComponent<SkillScript>().availableSkills[2].sprite;

            skillList[i].transform.
                GetChild(3).GetComponent<TMP_Text>().text = characterBySpeed[i].Value.ToString();

            skillList[i].transform.
                GetChild(4).
                GetChild(0).GetComponent<Image>().sprite = characterBySpeed[i].Key.GetComponent<SinnerScript>().portrait;
        }
    }

    void LinkNode(GameObject characterNode, Skill skill)
    {
        characterNode.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().sprite = skill.sprite;
    }

    void TargetSinner(int sinnerCount)
    {
        abToSinner = new();
        for (int i = 0; i < abnormalities.Count; i++)
        {
            int index = Random.Range(0, sinnerCount);
            abToSinner.Add(abnormalities[i], sinners[index]);

            GameObject targetSinnerNode = sinners[index].transform.parent.GetChild(0).GetChild(0).gameObject;
            GameObject abnormalityNode = abnormalities[i].transform.parent.GetChild(0).GetChild(0).gameObject;
            Instantiate(targetArrow).GetComponent<TargetArrow>().Target(abnormalityNode, targetSinnerNode);
        }
    }

    public void TargetAbnormality(int sinnerIndex, int abnormalityIndex)
    {
        GameObject sinner = sinnerSpawnPoints[sinnerIndex].transform.GetChild(1).gameObject;
        GameObject abnormality = abnormalitySpawnPoints[abnormalityIndex].transform.GetChild(1).gameObject;

        if (!sinnerToAb.TryAdd(sinner, abnormality))
            sinnerToAb[sinner] = abnormality;

        GameObject targetAbnormalityNode = abnormality.transform.parent.GetChild(0).GetChild(0).gameObject;
        GameObject sinnerNode = sinner.transform.parent.GetChild(0).GetChild(0).gameObject;

        Instantiate(targetArrow).GetComponent<TargetArrow>().Target(sinnerNode, targetAbnormalityNode);
    }

    void StartBattle()
    {
        //ToNextTurn()
    }

    void ToNextTurn()
    {
        TargetArrow.Clear();
        TargetSinner(sinners.Count);
        sinnerToAb.Clear();
    }

}
