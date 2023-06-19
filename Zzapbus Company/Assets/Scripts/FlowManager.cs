using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowManager : MonoBehaviour
{
    public static FlowManager instance;
   
    private void Awake()
    {
        Init();
    }
    void Init()
    {
        if (instance)
        {
            Destroy(this);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);

        Application.targetFrameRate = 60;
        SetResolution();
    }

    public void SetResolution()
    {
        int setWidth = 1920;
        int setHeight = 1080;

        Screen.SetResolution(setWidth, setHeight, false);
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && SceneManager.GetActiveScene().name == "StartMenu")
            ToCharacterSelect();
    }

    private void ToCharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");
    } 

    public void ToBattle()
    {
        SceneManager.LoadScene("Battle");
    }

}
