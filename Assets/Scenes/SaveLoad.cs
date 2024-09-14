using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public TMP_InputField input;
   

    public void SaveData()
    {
        PlayerPrefs.SetString("username", input.text);
    }

    public void LoadData()
    {
        input.text = PlayerPrefs.GetString("username");
    }
    public void DeleteData()
    {
        input.text = "";
        PlayerPrefs.DeleteAll();
    }
}