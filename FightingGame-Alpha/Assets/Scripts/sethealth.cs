using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class sethealth : MonoBehaviour
{
    public GameObject sethealthbutt;
    public TMP_InputField inputfield1;
    public TMP_InputField inputfield2;

    public void setHP100()
    {
        PlayerPrefs.SetFloat("p1hp", 100f);
        PlayerPrefs.SetFloat("p2hp", 100f);
        PlayerPrefs.SetFloat("p1m", 100f);
        PlayerPrefs.SetFloat("p2m", 100f);
        Debug.Log("set health to 100");
    }

    public void setHP50()
    {
        PlayerPrefs.SetFloat("p1hp", 50f);
        PlayerPrefs.SetFloat("p2hp", 50f);
        PlayerPrefs.SetFloat("p1m", 50f);
        PlayerPrefs.SetFloat("p2m", 50f);
        Debug.Log("set health to 50");
    }

    public void saveButtonName()
    {
        PlayerPrefs.SetString("p1sn", inputfield1.text);
        PlayerPrefs.SetString("p2sn", inputfield2.text);
        PlayerPrefs.SetInt("p1ctr", 1);
        PlayerPrefs.SetInt("p2ctr", 1);
        SceneManager.LoadScene(1);    
    }
}
