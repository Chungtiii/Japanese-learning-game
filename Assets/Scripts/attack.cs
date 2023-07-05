using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attack : MonoBehaviour
{
    public Text playerBloodText;
    public Text monsterBloodText;
    public int playerBlood;
    public int monsterBlood;
    public Image playerBloodBar;
    public Image monsterBloodBar;
    public Animator playerAni;
    public Animator monsterAni;
    public GameObject winPanel;
    public GameObject losePanel;
    public int ansTime;

    public GameObject[] star;
    int getStar;
    public SQL_QA QA;

    void Start()
    {
        playerBlood = 100;
        monsterBlood = 100;
        getStar = 0;
    }

    public void monsterAttack()
    {
        monsterAni.SetTrigger("atk");
        Invoke("playerHurt", 0.3f);
    }

    public void playerAttack(int time)
    {
        ansTime = time;
        playerAni.SetTrigger("atk");
        Invoke("monsterHurt", 0.3f);
    }

    private void monsterHurt()
    {
        // 根據時間攻擊血量不同
        if (ansTime <= 5)
        {
            monsterBlood -= 15;
        }
        else if (ansTime <= 10)
        {
            monsterBlood -= 13;
        }
        else
        {
            monsterBlood -= 10;
        }
        // Debug.Log(ansTime);

        // 輪椅女孩多打一滴
        if (GameManager.charN == 2)
        {
            monsterBlood -= 1;
        }

        if (monsterBlood <= 0)
        {
            monsterBlood = 0;
            // 判斷玩家獲得星星數量
            if (QA.starNum == 3)
            {
                if (QA.wrongAns <= 2)
                {
                    getStar = 3;
                }
                else if (QA.wrongAns <= 4)
                {
                    getStar = 2;
                }
                else
                {
                    getStar = 1;
                }
            }
            else
            {
                if (QA.wrongAns <= 1)
                {
                    getStar = 4;
                }
                else if (QA.wrongAns <= 3)
                {
                    getStar = 3;
                }
                else if (QA.wrongAns <= 5)
                {
                    getStar = 2;
                }
                else
                {
                    getStar = 1;
                }
            }

            string levelNum = "starlevel" + (QA.level).ToString();
            int nowStarNum = PlayerPrefs.GetInt(levelNum, 0);
            if (getStar > nowStarNum)
            {
                // 開起星星物件
                for (int i = 0; i < getStar; i++)
                {
                    star[i].SetActive(true);
                }
                // 儲存星星數量
                PlayerPrefs.SetInt(levelNum, getStar);
            }
            
            winPanel.SetActive(true);
        }
        monsterBloodBar.fillAmount = (float)monsterBlood / 100;
        monsterBloodText.text = monsterBlood.ToString();
    }

    private void playerHurt()
    {
        playerBlood -= 10;
        if (playerBlood <= 0)
        {
            playerBlood = 0;
            losePanel.SetActive(true);
        }
        playerBloodBar.fillAmount = (float)playerBlood / 100;
        playerBloodText.text = playerBlood.ToString();
    }
}
