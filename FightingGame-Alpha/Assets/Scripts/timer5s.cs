using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class timer5s : MonoBehaviour
{
    public GameObject scenetimer;

    void Update()
    {
        StartCoroutine(ChangeSceneTime());
    }

    IEnumerator ChangeSceneTime()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("IdleFighting 1"); //from 11 to "IdleFighting 1"
        Destroy(scenetimer.gameObject);
    }

}
