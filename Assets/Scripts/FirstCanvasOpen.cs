using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCanvasOpen : MonoBehaviour
{
    public GameObject firstCanvas;
    void Start()
    {
        firstCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Animation Convert Key"))   //마우스 좌측 버튼을 누름.
        {
            Debug.Log("터치 터치");
            firstCanvas.SetActive(true);
        }    
    }
}
