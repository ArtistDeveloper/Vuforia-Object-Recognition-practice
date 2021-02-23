using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperButton : MonoBehaviour
{
    private GameObject PaperList;
    private bool PaperFlag;
    bool isTracked;
    void Start()
    {
        PaperList = GameObject.Find("PaperList");
        //PaperFlag가 false면 논문리스트가 꺼져있음. true면 논문 리스트가 켜져있음.
        PaperFlag = false; 
        isTracked = false;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {   
            //PaperList가 Null인지 확인.
            if (PaperList) {
                //paperFlag가 false면 버튼을 활성화시키고 flag를 true로 바꿈.
                if (PaperFlag == false) 
                {
                    PaperList.SetActive(true);
                    PaperFlag = true;
                }

                else
                {
                    PaperList.SetActive(false);
                    PaperFlag = false;
                }
            }

            else 
            {
                Debug.Log("PaperList가 존재하지 않습니다.");
            }
        }
    }
}
