using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowManager : MonoBehaviour
{
    public static FlowManager instance;

    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
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

    public void ToCharacterInfo(Sinner sinner)
    {
        SceneManager.LoadScene("CharacterInfo");
    }

    public void ToBattle()
    {
        SceneManager.LoadScene("Battle");
    }

}
