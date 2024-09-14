using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public static Menu Instance { get; private set; }
    public int u_Points;

    public TMP_InputField input;

    public int b_Score = 0;
    public string b_Name;
    
    void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("username", input.text);
    }

    public void LoadData()
    {
        input.text = PlayerPrefs.GetString("username");
    }

    public void BestScoreHandler()
    {
        //if(u_Points > b_Score)
        //{
        //    Debug.Log("u_points > b_score");
        //    PlayerPrefs.SetInt("BestScore" , u_Points);
        //    PlayerPrefs.SetString("BestUser", PlayerPrefs.GetString("username"));
        //}


    }

}
