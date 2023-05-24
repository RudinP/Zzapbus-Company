using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    List<GameObject> sinners;
    List<SinnerScript> sinnerScripts;

    List<int> skillEgoCount;
    List<int> egoSkillCount;

    SinnerLoader sinnerLoader;

    public GameObject sinnerBox;
    public List<Toggle> selection;
    public List<TMP_Text> sinBoxTxt;
    public GameObject sinnerInfoCanvas;
    public GameObject startBtn;

    int totalSinner;
    bool isFull;
    public int sinnerLimit;

    private float clickTime;
    private float minClickTime = 1;
    private bool isClick;

    private void Start()
    {
        sinnerLoader = SinnerLoader.instance;

        sinnerScripts = new();
        sinners = sinnerLoader.sinners;
        
        foreach(GameObject sinner in sinners)
        {
            sinnerScripts.Add(sinner.GetComponent<SinnerScript>());
        }

        SinnerView();

        InitSin();
        SinView();

        totalSinner = 0;
        isFull = false;
    }

    private void Update()
    {
        if (isClick)
        {
            clickTime += Time.deltaTime;
        }
        else
        {
            clickTime = 0;
        }
        StartBtn();
    }

    public void MouseDown()
    {
        isClick = true;
    }

    public void MouseUp(int index)
    {
        isClick = false;
        
        if(clickTime >= minClickTime)
        {
            selection.ForEach(x => x.enabled = false);
            SinnerInfo(index);
        }
    }

    public void Selection(int i)
    {

        if (selection[i].isOn)
        {
            sinnerLoader.selectedSinners.Add(sinners[i]);
            totalSinner++;

            AddSin(i);
            SinView();
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

        }
        //제한초과
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
                transform.GetChild(0).GetComponent<Image>().sprite = sinnerScripts[index].portrait;
        }
    }

    private void SinnerInfo(int index)
    {
        GameObject img = sinnerInfoCanvas.transform.GetChild(0).GetChild(0).gameObject;
        GameObject info = sinnerInfoCanvas.transform.GetChild(0).GetChild(1).gameObject;

        img.GetComponent<Image>().sprite = sinnerScripts[index].portrait;
        info.transform.GetChild(1).GetComponent<TMP_Text>().text = sinnerScripts[index].nameStr + " " + sinnerScripts[index].sinnerType;

        sinnerInfoCanvas.SetActive(true);
    }

    public void CloseSinnerInfo()
    {
        selection.ForEach(x => x.enabled = true);
        sinnerInfoCanvas.SetActive(false);
    }

    private void StartBtn()
    {
        if (totalSinner < 5)
            startBtn.GetComponent<Button>().interactable = false;
        else
            startBtn.GetComponent <Button>().interactable = true;
    }

}
