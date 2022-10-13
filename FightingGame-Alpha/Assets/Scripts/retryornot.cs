using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryornot : MonoBehaviour
{
    


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.DeleteAll();
    }

    public void quitapp()
    {
        Application.Quit();
    }
}
