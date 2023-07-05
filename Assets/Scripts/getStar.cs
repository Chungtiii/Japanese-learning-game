using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getStar : MonoBehaviour
{
    public GameObject[] starlevel3;
    public GameObject[] starlevel6;
    public GameObject[] starlevel9;
    public GameObject[] starlevel12;
    public GameObject[] starlevel15;
    public GameObject[] starlevel16;
    public GameObject[] starlevel17;
    public GameObject[] starlevel18;
    public GameObject[] starlevel19;
    public GameObject[] starlevel20;
    public GameObject[] starlevel21;
    private int getStar3;
    private int getStar6;
    private int getStar9;
    private int getStar12;
    private int getStar15;
    private int getStar16;
    private int getStar17;
    private int getStar18;
    private int getStar19;
    private int getStar20;
    private int getStar21;
    public int allStar = 0;
    public GameObject winLevel3;
    public GameObject winLevel6;
    public GameObject winLevel9;
    public GameObject winLevel12;
    public GameObject winLevel15;
    public GameObject winLevel18;

    void Start()
    {
        // PlayerPrefs.DeleteAll();

        getStar3 = PlayerPrefs.GetInt("starlevel3", 0);
        // 開起星星物件
        for (int i = 0; i < getStar3; i++)
        {
            starlevel3[i].SetActive(true);
        }
        if (getStar3 > 0)
        {
            winLevel3.SetActive(false);
        }

        getStar6 = PlayerPrefs.GetInt("starlevel6", 0);
        // 開起星星物件
        for (int i = 0; i < getStar6; i++)
        {
            starlevel6[i].SetActive(true);
        }
        if (getStar6 > 0)
        {
            winLevel6.SetActive(false);
        }

        getStar9 = PlayerPrefs.GetInt("starlevel9", 0);
        // 開起星星物件
        for (int i = 0; i < getStar9; i++)
        {
            starlevel9[i].SetActive(true);
        }
        if (getStar9 > 0)
        {
            winLevel9.SetActive(false);
        }

        getStar12 = PlayerPrefs.GetInt("starlevel12", 0);
        // 開起星星物件
        for (int i = 0; i < getStar12; i++)
        {
            starlevel12[i].SetActive(true);
        }
        if (getStar12 > 0)
        {
            winLevel12.SetActive(false);
        }

        getStar15 = PlayerPrefs.GetInt("starlevel15", 0);
        // 開起星星物件
        for (int i = 0; i < getStar15; i++)
        {
            starlevel15[i].SetActive(true);
        }
        if (getStar15 > 0)
        {
            winLevel15.SetActive(false);
        }

        getStar16 = PlayerPrefs.GetInt("starlevel16", 0);
        // 開起星星物件
        for (int i = 0; i < getStar16; i++)
        {
            starlevel16[i].SetActive(true);
        }

        getStar17 = PlayerPrefs.GetInt("starlevel17", 0);
        // 開起星星物件
        for (int i = 0; i < getStar17; i++)
        {
            starlevel17[i].SetActive(true);
        }

        getStar18 = PlayerPrefs.GetInt("starlevel18", 0);
        // 開起星星物件
        for (int i = 0; i < getStar18; i++)
        {
            starlevel18[i].SetActive(true);
        }
        if (getStar16 > 0 && getStar17 > 0 && getStar18 > 0)
        {
            winLevel18.SetActive(false);
        }

        getStar19 = PlayerPrefs.GetInt("starlevel19", 0);
        // 開起星星物件
        for (int i = 0; i < getStar19; i++)
        {
            starlevel19[i].SetActive(true);
        }

        getStar20 = PlayerPrefs.GetInt("starlevel20", 0);
        // 開起星星物件
        for (int i = 0; i < getStar20; i++)
        {
            starlevel20[i].SetActive(true);
        }

        getStar21 = PlayerPrefs.GetInt("starlevel21", 0);
        // 開起星星物件
        for (int i = 0; i < getStar21; i++)
        {
            starlevel21[i].SetActive(true);
        }
        countStar();
    }
    void countStar()
    {
        allStar = (getStar3 + getStar6 + getStar9 + getStar12 + getStar15 + getStar16 + getStar17 + getStar18 + getStar19 + getStar20 + getStar21);
        PlayerPrefs.SetInt("totalStar", allStar);
    }
}
