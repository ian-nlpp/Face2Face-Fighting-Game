using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class timer3sp2 : MonoBehaviour
{
    public GameObject scenetimer;

    void Update()
    {
        StartCoroutine(ChangeSceneTime());
    }

    IEnumerator ChangeSceneTime()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
        Destroy(scenetimer.gameObject);
    }

}
