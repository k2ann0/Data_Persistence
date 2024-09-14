using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Security.Policy;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField _usernameField;


 


    void Start()
    {
        LoadData();
        
    }



    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SaveData()
    {
        Menu.Instance.SaveData();
    }
    public void LoadData()
    {
        Menu.Instance.LoadData();
    }
}


