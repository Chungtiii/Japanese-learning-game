using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class learnLevel : MonoBehaviour
{
    public Sprite[] hiraCard; // 平假圖檔陣列
    public Sprite[] kataCard; // 片假圖檔陣列
    public Sprite[] hiraCardII; // 來源平假圖檔陣列
    public Sprite[] kataCardII; // 來源片假圖檔陣列
    public GameObject hiraCardImg; // 場景上的平假卡片
    public GameObject kataCardImg; // 場景上的片假卡片
    public GameObject hiraCardI;
    public GameObject kataCardI;
    public AudioSource audioSrc; 
    public AudioClip[] clips;
    public int i = 0;
    public int k = 0;
    public int z;
    static public int j = 0;
    
    void Start()
    {
        j = PlayerPrefs.GetInt("Level");
        switch (j)
        {
            case 1:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[0]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[0]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[0]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[0];
                kataCardI.GetComponent<Image>().sprite = kataCardII[0];
                i = 0;
                z = 0;
                k = 5;
                break;
            case 2:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[5]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[5]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[5]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[5];
                kataCardI.GetComponent<Image>().sprite = kataCardII[5];
                i = 5;
                z = 5;
                k = 5;
                break;
            case 4:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[10]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[10]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[10]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[10];
                kataCardI.GetComponent<Image>().sprite = kataCardII[10];
                i = 10;
                z = 10;
                k = 5;
                break;
            case 5:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[15]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[10]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[15]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[15];
                kataCardI.GetComponent<Image>().sprite = kataCardII[15];
                i = 15;
                z = 15;
                k = 5;
                break;
            case 7:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[20]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[20]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[20]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[20];
                kataCardI.GetComponent<Image>().sprite = kataCardII[20];
                i = 20;
                z = 20;
                k = 5;
                break;
            case 8:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[25]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[25]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[25]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[25];
                kataCardI.GetComponent<Image>().sprite = kataCardII[25];
                i = 25;
                z = 25;
                k = 5;
                break;
            case 10:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[30]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[30]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[30]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[30];
                kataCardI.GetComponent<Image>().sprite = kataCardII[30];
                i = 30;
                z = 30;
                k = 5;
                break;
            case 11:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[35]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[35]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[35]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[35];
                kataCardI.GetComponent<Image>().sprite = kataCardII[35];
                i = 35;
                z = 35;
                k = 3;
                break;
            case 13:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[38]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[38]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[38]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[38];
                kataCardI.GetComponent<Image>().sprite = kataCardII[38];
                i = 38;
                z = 38;
                k = 5;
                break;
            case 14:
                hiraCardImg.GetComponent<Image>().sprite = hiraCard[43]; // 讓場景上的卡片變成想要的圖檔
                kataCardImg.GetComponent<Image>().sprite = kataCard[43]; // 讓場景上的卡片變成想要的圖檔
                audioSrc.clip = clips[43]; // 換音檔
                hiraCardI.GetComponent<Image>().sprite = hiraCardII[43];
                kataCardI.GetComponent<Image>().sprite = kataCardII[43];
                i = 43;
                z = 43;
                k = 3;
                break;
        }
    }

    void Update()
    {
       
    }

    public void nextBtn()
    {
        
        if (i < z + (k-1))
        {
            i++;
            hiraCardImg.GetComponent<Image>().sprite = hiraCard[i]; // 讓場景上的卡片變成想要的圖檔
            kataCardImg.GetComponent<Image>().sprite = kataCard[i]; // 讓場景上的卡片變成想要的圖檔
            audioSrc.clip = clips[i]; // 換音檔
            hiraCardI.GetComponent<Image>().sprite = hiraCardII[i];
            kataCardI.GetComponent<Image>().sprite = kataCardII[i];
            
        }
    }

    public void BackBtn()
    {

        if (i > z)
        {
            i--;
            hiraCardImg.GetComponent<Image>().sprite = hiraCard[i]; // 讓場景上的卡片變成想要的圖檔
            kataCardImg.GetComponent<Image>().sprite = kataCard[i]; // 讓場景上的卡片變成想要的圖檔
            audioSrc.clip = clips[i]; // 換音檔
            hiraCardI.GetComponent<Image>().sprite = hiraCardII[i];
            kataCardI.GetComponent<Image>().sprite = kataCardII[i];
            
        }
    }
}
