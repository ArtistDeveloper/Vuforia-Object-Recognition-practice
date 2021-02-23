using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAA : MonoBehaviour
{
    public GameObject secPaper;

    void Start()
    {
        secPaper.SetActive(false);
    }

    public void OnClickPaper()
    {
        secPaper.SetActive(true);
    }
}
