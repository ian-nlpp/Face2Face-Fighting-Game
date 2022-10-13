using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class timer5sp2 : MonoBehaviour
{
    public GameObject scenetimer;

    void Update()
    {
        StartCoroutine(ChangeSceneTime());
    }

    IEnumerator ChangeSceneTime()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1); //from 11 to "IdleFighting 1" to 1
        Destroy(scenetimer.gameObject);
    }

}
