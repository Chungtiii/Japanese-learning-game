using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Coin : MonoBehaviour
  
    
{
  int coin;
    int Score = PlayerPrefs.GetInt("coin");
    void Start()
    {

        coin = PlayerPrefs.GetInt("coin");
        
    }
    void Update()
    {
     Totalcoins();
   Debug.Log("錢:" + Score);
    }



  //  currentCoins += 5;

    public void Totalcoins()
    {
        //string coinText = GameObject.Find("moneyNum").GetComponentInChildren<Text>().text;
    //  print(enterLevel.coin.ToString());
      //GameObject.Find("moneyNum").GetComponentInChildren<Text>().text = enterLevel.coin.ToString(); // 更新金幣數量文本

    }
}   



