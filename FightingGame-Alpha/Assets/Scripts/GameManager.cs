using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public float p1health, p2health, p1max, p2max;
    public int rand;
    public int p1ctr;
    public int p2ctr;
    
    private void Start() 
    {
        p1health = PlayerPrefs.GetFloat("p1hp");
        p2health = PlayerPrefs.GetFloat("p2hp");
        p1ctr = PlayerPrefs.GetInt("p1ctr");
        p2ctr = PlayerPrefs.GetInt("p2ctr");
        p1max = PlayerPrefs.GetFloat("p1m");
        p2max = PlayerPrefs.GetFloat("p2m");
        healthcheck();
    }

    private void Update() 
    {
        PlayerPrefs.SetFloat("p1hn", p1health);
        PlayerPrefs.SetFloat("p2hn", p2health);
        PlayerPrefs.SetFloat("p1max", p1max);
        PlayerPrefs.SetFloat("p2max", p2max);
        PlayerPrefs.SetInt("p1ctr",p1ctr);
        PlayerPrefs.SetInt("p2ctr",p2ctr);
    }

    public void healthcheck()
    {
        if (p1health < 1f)
        {
            SceneManager.LoadScene(22);
        }
        if (p2health < 1f)
        {
            SceneManager.LoadScene(21);
        }
    }

    public void p1lp()
    {
        rand = Random.Range(0,100);
        if(rand <= 75)
        {
        SceneManager.LoadScene(2);
        p2health -= 3f;
        }
        else
        {
        SceneManager.LoadScene(3);
        }
    }

    public void p1hp()
    {
        rand = Random.Range(0,100);
        if(rand <= 55)
        {
        SceneManager.LoadScene(4);
        p2health -= 8f;
        }
        else
        {
        SceneManager.LoadScene(5);
        }
    }

    public void p1lk()
    {
        rand = Random.Range(0,100);
        if(rand <= 65)
        {
        SceneManager.LoadScene(6);
        p2health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(7);
        }
    }
    public void p1hk()
    {
        rand = Random.Range(0,100);
        if(rand <= 45)
        {
        SceneManager.LoadScene(8);
        p2health -= 12f;
        }
        else
        {
        SceneManager.LoadScene(9);
        }
    }
    public void p1s()
    {
        if (p1ctr>=1) {
            SceneManager.LoadScene(10);
            p2health -= 25f;
            p1ctr--;
        }
    }
    
    public void p2lp()
    {
        rand = Random.Range(0,100);
        if(rand <= 75)
        {
        SceneManager.LoadScene(12);
        p1health -= 3f;
        }
        else
        {
        SceneManager.LoadScene(13);
        }
    }

    public void p2hp()
    {
        rand = Random.Range(0,100);
        if(rand <= 55)
        {
        SceneManager.LoadScene(14);
        p1health -= 8f;
        }
        else
        {
        SceneManager.LoadScene(15);
        }
    }

    public void p2lk()
    {
        rand = Random.Range(0,100);
        if(rand <= 65)
        {
        SceneManager.LoadScene(16);
        p1health -= 6f;
        }
        else
        {
        SceneManager.LoadScene(17);
        }
    }
    
    public void p2hk()
    {
        rand = Random.Range(0,100);
        if(rand <= 45)
        {
        SceneManager.LoadScene(18);
        p1health -= 12f;
        }
        else
        {
        SceneManager.LoadScene(19);
        }
    }

     // public void p2s()
    {
        if (p2ctr>=1) {
            SceneManager.LoadScene(20);
            p1health -= 25f;
            p2ctr--;
        }
    } //
}