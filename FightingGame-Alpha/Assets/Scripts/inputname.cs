using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inputname : MonoBehaviour
{
    public TextMeshProUGUI p1name;
    public TextMeshProUGUI p2name;

    void Start()
    {
        p1name.text = PlayerPrefs.GetString("p1sn");
        p2name.text = PlayerPrefs.GetString("p2sn");
    }


}
