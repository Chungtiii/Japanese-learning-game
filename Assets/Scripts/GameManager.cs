using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public int charN = 0;

    public void QAlevel(int num)
    {
        PlayerPrefs.SetInt("Level", num);
        SceneManager.LoadScene("QALevel");
    }

    public void learnlevel(int num)
    {
        PlayerPrefs.SetInt("Level", num);
        SceneManager.LoadScene("LearnLevel");
    }

    public void startGame()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void backToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void toCharacter()
    {
        SceneManager.LoadScene("Character");
    }

    public void toStore()
    {
        SceneManager.LoadScene("Store");
    }
}
