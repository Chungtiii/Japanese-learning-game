using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class character : MonoBehaviour
{
    public GameObject[] _character;
    public GameObject light;
    public GameObject buy;
    public bool[] buyornot = new bool[7];
    public Text name;
    public Text identity;
    public Text skill;
    public Text getStarTxt;
    public int characterNum;
    public int starN;
    public int starN_;
    public bool[] lightornot = new bool[7];

    void Start()
    {
        //PlayerPrefs.DeleteAll();

        buyornot[0] = false;
        bool[] loadedBuyOrNot = new bool[7];
        for (int i = 1; i < loadedBuyOrNot.Length; i++) // load每個角色買過沒
        {
            int value = PlayerPrefs.GetInt("BuyOrNot_" + i, 0);
            loadedBuyOrNot[i] = value == 0;
            if(loadedBuyOrNot[i] == false)
            {
                _character[i].GetComponent<Image>().color = new Color32(255, 255, 255, 255); // 兌換後把顏色調亮
            }
            buyornot[i] = loadedBuyOrNot[i];
            //Debug.Log(buyornot[i]);
        }

        bool[] loadedLightOrNot = new bool[7];
        for (int i = 0; i < loadedLightOrNot.Length; i++) // load每個角色是否被選擇
        {
            int value = PlayerPrefs.GetInt("LightOrNot_" + i);
            loadedLightOrNot[i] = value == 1;
            if(loadedLightOrNot[i] == true)
            {
                light.transform.position = _character[i].transform.position; // 選擇後把光移到角色位置
            }
        }

        starN = PlayerPrefs.GetInt("totalStar");
        starN_ = PlayerPrefs.GetInt("totalStar_", 0);
        //Debug.Log(starN);
        //Debug.Log(starN_);
        int buyTime = PlayerPrefs.GetInt("BuyTime", 0); //判斷是否買過任何角色
        //Debug.Log(buyTime);
        if (starN != starN_ )
        {
            if (starN_ == 0 & buyTime == 0)  //從來沒買過角色顯示加總星星數量
            {
                getStarTxt.text = starN.ToString();
            }
            else
            {
                starN -= (buyTime * 6);
                starN_ = starN;
                PlayerPrefs.SetInt("totalStar_", starN_);
                getStarTxt.text = starN.ToString();
                //Debug.Log(starN);
                //Debug.Log(starN_);
                //Debug.Log(buyTime);
            }
        }
        else
        {
            getStarTxt.text = starN_.ToString();
            //Debug.Log(buyornot[i]);

        }

    }

    void Update()
    {
        bool[] loadedLightOrNot = new bool[7];
        for (int i = 0; i < loadedLightOrNot.Length; i++) // load每個角色是否被選擇
        {
            int value = PlayerPrefs.GetInt("LightOrNot_" + i);
            loadedLightOrNot[i] = value == 1;
            if (loadedLightOrNot[i] == true)
            {
                GameManager.charN = i;
            }
        }
        //GameManager.charN = characterNum;
    }

    public void choose()
    {
        if(buyornot[characterNum] == false)
        {
            light.transform.position = _character[characterNum].transform.position; // 選擇後把光移到角色位置
            lightornot[characterNum] = true;
            for (int i = 0; i < lightornot.Length; i++)
            {
                int value = lightornot[i] ? 1 : 0;
                PlayerPrefs.SetInt("LightOrNot_" + i, value);
            }
        }
    }

    public void change()
    {
        int buyTime = PlayerPrefs.GetInt("BuyTime", 0);
        //Debug.Log(starN_);
        if (buyTime > 0)
        {
            if (starN_ >= 6)
            {
                starN_ -= 6;
                buyTime += 1;
                PlayerPrefs.SetInt("BuyTime", buyTime);
                buyornot[characterNum] = false;
                PlayerPrefs.SetInt("BuyOrNot_" + characterNum, 1); // 該角色已購買 存進PlayerPrefs; 鍵為"BuyOrNot_" + characterNum; 布林值為1
                _character[characterNum].GetComponent<Image>().color = new Color32(255, 255, 255, 255); // 兌換後把顏色調亮
                //Debug.Log(characterNum);

            }
            PlayerPrefs.SetInt("totalStar_", starN_);
            getStarTxt.text = starN_.ToString();
        }
        else
        {
            if (starN >= 6)
            {
                starN -= 6;
                buyTime += 1;
                PlayerPrefs.SetInt("BuyTime", buyTime);
                PlayerPrefs.SetInt("BuyOnce", 1);
                buyornot[characterNum] = false;
                PlayerPrefs.SetInt("BuyOrNot_" + characterNum, 1); // 該角色已購買 存進PlayerPrefs; 鍵為"BuyOrNot_" + characterNum; 布林值為0
                _character[characterNum].GetComponent<Image>().color = new Color32(255, 255, 255, 255); // 兌換後把顏色調亮
            }
            PlayerPrefs.SetInt("totalStar_", starN);
            getStarTxt.text = starN.ToString();
        }
        //Debug.Log(buyTime);
    }

    public void character_A()
    {
        name.text = "眼鏡男孩";
        identity.text = "聰明";
        skill.text = "無";
        characterNum = 0;
        if (buyornot[0] == true)
        {
            buy.SetActive(true);
        }
        else
        {
            buy.SetActive(false);
        }
    }

    public void character_B()
    {
        name.text = "粉紅女孩";
        identity.text = "溫柔";
        skill.text = "發音題出現機率增加為50%";
        characterNum = 1;
        if (buyornot[1] == true)
        {
            buy.SetActive(true);
        }
        else
        {
            buy.SetActive(false);
        }
    }

    public void character_C()
    {
        name.text = "輪椅女孩";
        identity.text = "悲觀";
        skill.text = "暴擊增加為10%";
        characterNum = 2;
        if (buyornot[2] == true)
        {
            buy.SetActive(true);
        }
        else
        {
            buy.SetActive(false);
        }
    }

    public void character_D()
    {
        name.text = "生氣女孩";
        identity.text = "易怒";
        skill.text = "互換題出現機率增加為50%";
        characterNum = 3;
        if (buyornot[3] == true)
        {
            buy.SetActive(true);
        }
        else
        {
            buy.SetActive(false);
        }
    }

    public void character_E()
    {
        name.text = "公主女孩";
        identity.text = "傲嬌";
        skill.text = "戰鬥關卡金幣增加為12";
        characterNum = 4;
        if (buyornot[4] == true)
        {
            buy.SetActive(true);
        }
        else
        {
            buy.SetActive(false);
        }
    }

    public void character_F()
    {
        name.text = "坐著女孩";
        identity.text = "緊張";
        skill.text = "假名題出現機率增加為50%";
        characterNum = 5;
        if (buyornot[5] == true)
        {
            buy.SetActive(true);
        }
        else
        {
            buy.SetActive(false);
        }
    }

    public void character_G()
    {
        name.text = "讀書男孩";
        identity.text = "文靜";
        skill.text = "讀音題出現機率增加為50%";
        characterNum = 6;
        if (buyornot[6] == true)
        {
            buy.SetActive(true);
        }
        else
        {
            buy.SetActive(false);
        }
    }
}
