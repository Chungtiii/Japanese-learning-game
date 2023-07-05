using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public GameObject dialogPanel;
    public float delayTime = 2f;

    private int levelNum;

    private void Start()
    {
        // 隱藏對話面板
        dialogPanel.SetActive(false);
    }

    public void OnLevelButtonClick(int num)
    {
        // 顯示對話面板
        dialogPanel.SetActive(true);

        // 設定要學習的關卡數值
        levelNum = num;

        // 停止兩秒後執行下一個動作
        Invoke("LoadLevel", delayTime);
    }

    private void LoadLevel()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            // 設定關卡數值到GameManager
            gameManager.learnlevel(levelNum);
        }
        // 跳轉到關卡畫面
        SceneManager.LoadScene("LearnLevel");
    }
}
