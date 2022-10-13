using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victorytimer : MonoBehaviour
{   

    public GameObject vtimer;

    void Start()
    {
        StartCoroutine(victory());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator victory()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(23);
        Destroy(vtimer.gameObject);
    }
}
