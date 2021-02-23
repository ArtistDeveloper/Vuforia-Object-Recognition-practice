using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XButton : MonoBehaviour
{
    public GameObject MinkiProfileUI;
    public GameObject SuwonProfileUI;
    public GameObject BeomseokProfileUI;
    public GameObject JongminProfileUI;
    public GameObject YeonggeonProfileUI;
    public GameObject GwoasaProfileUI;


    public GameObject MinkiChan;
    public GameObject SuwonChan;
    public GameObject BeomseokChan;
    public GameObject JongminChan;
    public GameObject YeonggeonChan;
    public GameObject GwoasaChan;


    public GameObject BPaper;
    public GameObject YPaper;

    void Start()
    {
        
    }

    public void OnClickX()
    {
        MinkiProfileUI.SetActive(false);
        SuwonProfileUI.SetActive(false);
        BeomseokProfileUI.SetActive(false);
        JongminProfileUI.SetActive(false);
        YeonggeonProfileUI.SetActive(false);
        GwoasaProfileUI.SetActive(false);

        MinkiChan.SetActive(false);
        MinkiChan.SetActive(true);
        SuwonChan.SetActive(false);
        SuwonChan.SetActive(true);
        BeomseokChan.SetActive(false);
        BeomseokChan.SetActive(true);
        JongminChan.SetActive(false);
        JongminChan.SetActive(true);
        YeonggeonChan.SetActive(false);
        YeonggeonChan.SetActive(true);
        GwoasaChan.SetActive(false);
        GwoasaChan.SetActive(true);

        BPaper.SetActive(false);
        YPaper.SetActive(false);
    }
}
