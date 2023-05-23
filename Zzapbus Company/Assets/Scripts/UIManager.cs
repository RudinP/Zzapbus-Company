using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    List<GameObject> sinners;

    List<int> skillEgoCount;
    List<int> egoSkillCount;

    SinnerLoader sinnerLoader;

    public GameObject sinnerBox;
    public List<Toggle> selection;
    public List<TMP_Text> sinBoxTxt;

    int totalSinner;
    bool isFull;
    public int sinnerLimit;

    private void Start()
    {
        sinnerLoader = SinnerLoader.instance;
        sinners = sinnerLoader.sinners;

        SinnerView();

        InitSin();
        SinView();

        totalSinner = 0;
        isFull = false;
    }

    public void Selection(int i)
    {

        if (selection[i].isOn)
        {
            sinnerLoader.selectedSinners.Add(sinners[i]);
            totalSinner++;

            AddSin(i);
            SinView();

            Debug.Log($"Selected {sinners[i].name.ToString()}");
        }
        else if (!selection[i].isOn)
        {
            sinnerLoader.selectedSinners.Remove(sinners[i]);
            totalSinner--;

            SubtractSin(i);
            SinView();

            if (isFull)
            {
                foreach(Toggle toggle in selection)
                {
                    if (!toggle.interactable)
                        toggle.interactable = true;
                }
            }
            Debug.Log($"Deselected {sinners[i].name.ToString()}");
        }
        //�����ʰ�
        if (totalSinner >= sinnerLimit)
        {
            foreach(Toggle toggle in selection)
            {
                if(!toggle.isOn)
                    toggle.interactable = false;
            }
            isFull = true;
        }
    }

    private void InitSin()
    {
        egoSkillCount = new()
        {
            0,0,0,0,0,0,0,
        };
        skillEgoCount = new(egoSkillCount);

    }

    private void AddSin(int sinnerNum)
    {
        List<Skill> skills = SinnerLoader.instance.sinners[sinnerNum].GetComponent<SkillScript>().skills;
        foreach (Skill skill in skills)
        {
            if (skill.sinType == SinType.none) continue;
            skillEgoCount[(int)skill.sinType - 1]++;
        }

        EgoScript egoScript = SinnerLoader.instance.sinners[sinnerNum].GetComponent<EgoScript>();
        List<SinType> egoSins = egoScript.sinTypes;
        List<int> egoCount = egoScript.sinCounts;
        for (int index = 0; index < egoSins.Count; index++)
        {
            egoSkillCount[(int)egoSins[index] - 1] += egoCount[index];
        }
    }
    
    private void SubtractSin(int sinnerNum)
    {
        List<Skill> skills = SinnerLoader.instance.sinners[sinnerNum].GetComponent<SkillScript>().skills;
        foreach (Skill skill in skills)
        {
            if (skill.sinType == SinType.none) continue;
            skillEgoCount[(int)skill.sinType - 1]--;
        }

        EgoScript egoScript = SinnerLoader.instance.sinners[sinnerNum].GetComponent<EgoScript>();
        List<SinType> egoSins = egoScript.sinTypes;
        List<int> egoCount = egoScript.sinCounts;
        for (int index = 0; index < egoSins.Count; index++)
        {
            egoSkillCount[(int)egoSins[index] - 1] -= egoCount[index];
        }
    }

    private void SinView()
    {
        for (int index = 0; index < sinBoxTxt.Count; index++)
        {
            sinBoxTxt[index].text = $"X {skillEgoCount[index]}/{egoSkillCount[index]}";
        }
    }

    private void SinnerView()
    {
        for(int index = 0; index < 12; index++)
        {
            sinnerBox.transform.GetChild(index).
                transform.GetChild(0).GetComponent<Image>().sprite = sinners[index++].GetComponent<SinnerScript>().portrait;
        }
    }
}
