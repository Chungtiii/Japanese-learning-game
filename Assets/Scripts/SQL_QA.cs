using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
 
public class SQL_QA : MonoBehaviour
{
    public GameManager GM;
    public GameObject waitPanel;
    public GameObject fightPanel;
    public attack ATK;
    public int timer = 0;
    public int startTime;
    int wordS, wordE;
    public int level;
    int quesNum;
    int quesStyle;

    public int wrongAns;
    public int starNum;

    public Text timerTxt;
    public Text ques;
    public Text[] option;
    List<Ques> QuesList = new List<Ques>();
    List<string> ansList = new List<string>();

    public Sprite[] monsterPic;
    public Image monster;
    public GameObject volume;
    public AudioSource soundQues; 
    public AudioClip soundQuesClip;

    List<string> hiraAns = new List<string>() {"", "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ", "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と", "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ", "ま", "み", "む", "め", "も", "や", "ゆ", "よ", "ら", "り", "る", "れ", "ろ", "わ", "を", "ん"};
    List<string> kataAns = new List<string>() {"", "ア", "イ", "ウ", "エ", "オ", "カ", "キ", "ク", "ケ", "コ", "サ", "シ", "ス", "セ", "ソ", "タ", "チ", "ツ", "テ", "ト", "ナ", "ニ", "ヌ", "ネ", "ノ", "ハ", "ヒ", "フ", "ヘ", "ホ", "マ", "ミ", "ム", "メ", "モ", "ヤ", "ユ", "ヨ", "ラ", "リ", "ル", "レ", "ロ", "ワ", "ヲ", "ン"};
    List<string> romanAns = new List<string>() {"", "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko", "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to", "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho", "ma", "mi", "mu", "me", "mo", "ya", "yu", "yo", "ra", "ri", "ru", "re", "ro", "wa", "wo", "n"};
    
    void Start()
    {
        wrongAns = 0;
        startTime = (int)Time.time;
        SQL_TEST();

        if (GameManager.charN == 1)
        {
            quesStyle = 6;
        }
        else if (GameManager.charN == 3)
        {
            quesStyle = 4;
        }
        else if (GameManager.charN == 5)
        {
            quesStyle = 2;
        }
        else
        {
            quesStyle = 0;
        }

        level = PlayerPrefs.GetInt("Level");
        // Debug.Log(level);
        starNum = 3;
        if (level == 3)
        {
            wordS = 1;
            wordE = 10;
            monster.sprite = monsterPic[0];
        }
        else if (level == 6)
        {
            wordS = 11;
            wordE = 20;
            monster.sprite = monsterPic[1];
        }
        else if (level == 9)
        {
            wordS = 21;
            wordE = 30;
            monster.sprite = monsterPic[2];
        }
        else if (level == 12)
        {
            wordS = 31;
            wordE = 38;
            monster.sprite = monsterPic[3];
        }
        else if (level == 15)
        {
            wordS = 39;
            wordE = 46;
            monster.sprite = monsterPic[4];
        }
        else if (level == 16)
        {
            wordS = 1;
            wordE = 15;
            monster.sprite = monsterPic[5];
        }
        else if (level == 17)
        {
            wordS = 16;
            wordE = 30;
            monster.sprite = monsterPic[6];
        }
        else if (level == 18)
        {
            wordS = 31;
            wordE = 46;
            monster.sprite = monsterPic[7];
        }
        else if (level == 19)
        {
            wordS = 1;
            wordE = 25;
            monster.sprite = monsterPic[8];
            starNum = 4;
        }
        else if (level == 20)
        {
            wordS = 26;
            wordE = 46;
            monster.sprite = monsterPic[9];
            starNum = 4;
        }
        else
        {
            wordS = 1;
            wordE = 46;
            monster.sprite = monsterPic[10];
            starNum = 4;
        }

        randomQues();
        QuesVol();
    }
     
    void Update()
    {
        if(timer < 15)
        {
            timerTxt.text = (15 - timer).ToString();
            timer = (int)Time.time - startTime;
        }
        else
        {
            waitPanel.SetActive(true);
            fightPanel.SetActive(false);
            monsterTurn();
            randomQues();
        }
    }

    public void SQL_TEST()
    {
        // 連接伺服器字串
        string constr = "server=sql9.freemysqlhosting.net;port=3306;User Id=sql9615925;password=dpmPiYtVzj;Database=sql9615925;charset=utf8";
        // 建立連接
        MySqlConnection mycon = new MySqlConnection(constr);
        // 打開連接
        mycon.Open();
        // 查詢數據
        string selstr = "select * from HIRAGANA8";
        MySqlCommand cmd = new MySqlCommand(selstr, mycon); // 查詢語句, 創建的連接
        MySqlDataReader reader = cmd.ExecuteReader(); // 讀取游標
        string _num;
        string _quesiton;
        string _answer;
        string _answerstyle;
        string _tip;
        string _tipstyle;
 
        while(reader.Read())
        {
            _num = reader[0].ToString(); // 題號
            _quesiton = reader[1].ToString(); // 題目
            _answer = reader[2].ToString(); // 答案
            _answerstyle = reader[3].ToString(); // 答案樣式
            _tip = reader[4].ToString(); // 提示
            _tipstyle = reader[5].ToString(); // 提示樣式
            QuesList.Add(new Ques(_num, _quesiton, _answer, _answerstyle, _tip, _tipstyle));
        }
        mycon.Close();
    }

    public void randomQues()
    {
        quesNum = UnityEngine.Random.Range(wordS*8-7, wordE*8+1); // 在1到368之間隨機取值
        if (GameManager.charN == 1 || GameManager.charN == 3 || GameManager.charN == 5 || GameManager.charN == 6)
        {
            quesNum = GetRandomValue();
        }
        // Debug.Log(quesNum);
        ques.text = QuesList[quesNum].Question;
        Debug.Log(QuesList[quesNum].Answer);
        randomAns();
    }

    // 題目出現機率調整
    int GetRandomValue() {
        float rand = Random.value;
        // Debug.Log(rand);
        if (rand <= .5f)
        {
            while (quesNum % 8 != quesStyle && quesNum % 8 != quesStyle+1)
            {
                quesNum = UnityEngine.Random.Range(wordS*8-7, wordE*8+1); // 在1到368之間隨機取值
            }
        }
        else
        {
            while (quesNum % 8 == quesStyle || quesNum % 8 == quesStyle+1)
            {
                quesNum = UnityEngine.Random.Range(wordS*8-7, wordE*8+1); // 在1到368之間隨機取值
            }
        }
        return quesNum;
    }

    public void randomAns()
    {
        ansList.Clear();
        ansList.Add(QuesList[quesNum].Answer);

        int[] randomArray = new int[3]; // 生成3個隨機數
        int i = 0;

        while (i < 3)
        {
            bool isDifferent = true;
            int randomNum = UnityEngine.Random.Range(wordS, wordE+1); // 在0到45之間隨機取值
            for (int j = 0; j < i; j++)
            {
                if (randomNum == randomArray[j])
                {
                    isDifferent = false;
                    break;
                }
            }
            if(isDifferent)
            {
                if (QuesList[quesNum].AnswerStyle == "hiraAns" && hiraAns[randomNum] != QuesList[quesNum].Answer)
                {
                    randomArray[i] = randomNum;
                    ansList.Add(hiraAns[randomArray[i]]);
                    i++;
                }
                else if (QuesList[quesNum].AnswerStyle == "kataAns" && kataAns[randomNum] != QuesList[quesNum].Answer)
                {
                    randomArray[i] = randomNum;
                    ansList.Add(kataAns[randomArray[i]]);
                    i++;
                }
                else if (QuesList[quesNum].AnswerStyle == "romanAns" && romanAns[randomNum] != QuesList[quesNum].Answer)
                {
                    randomArray[i] = randomNum;
                    ansList.Add(romanAns[randomArray[i]]);
                    i++;
                }
                // Debug.Log(randomArray[i]);
            }
        }
        OutOfOrder(ansList);
        
        for (int k = 0; k < 4; k++)
        {
            option[k].text = ansList[k];
        }

        startTime = (int)Time.time;
        timer = 0;
    }

    // 判斷發音題
    public void QuesVol()
    {
        if (QuesList[quesNum].Question == "聽這個發音是哪個平假名?" || QuesList[quesNum].Question == "聽這個發音是哪個片假名?")
        {
            volume.SetActive(true);
            soundQuesClip = Resources.Load<AudioClip>("Sound/" + QuesList[quesNum].TipStyle);
            soundQues.clip = soundQuesClip;
            soundQues.Play();
        }
        else
        {
            volume.SetActive(false);
        }
    }

    // 打亂列表順序
    public void OutOfOrder<T>(List<T> list)
    {
        int index;
        T temp;
        for (int i = 0; i < list.Count; i++)
        {
            index = UnityEngine.Random.Range(0, list.Count);
            if (index != i)
            {
                temp = list[i];
                list[i] = list[index];
                list[index] = temp;
            }
        }
    }

    public void checkAns(int num)
    {
        if (option[num].text == QuesList[quesNum].Answer)
        {
            ATK.playerAttack(timer);
            Invoke("openFightPanel", 0.6f);
        }
        else
        {
            wrongAns++;
            monsterTurn();
        }
        randomQues();
    }

    public void monsterTurn()
    {
        if (ATK.monsterBlood > 0)
        {
            ATK.monsterAttack();
            Invoke("openFightPanel", 0.6f);
        }
    }

    public void openFightPanel()
    {
        if (ATK.playerBlood > 0 && ATK.monsterBlood > 0)
        {
            waitPanel.SetActive(false);
            fightPanel.SetActive(true);
            QuesVol();
        }
    }

    public class Ques
    {
        string _num;
        string _quesiton;
        string _answer;
        string _answerstyle;
        string _tip;
        string _tipstyle;

        public Ques(string _num, string _quesiton, string _answer, string _answerstyle, string _tip, string _tipstyle)
        {
            this._num = _num;
            this._quesiton = _quesiton;
            this._answer = _answer;
            this._answerstyle = _answerstyle;
            this._tip = _tip;
            this._tipstyle = _tipstyle;
        }

        public string Num
        {
            get { return _num;  }
            set { _num = value; }
        }
        public string Question
        {
            get { return _quesiton; }
            set { _quesiton = value; }
        }
        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }
        public string AnswerStyle
        {
            get { return _answerstyle; }
            set { _answerstyle = value; }
        }
        public string Tip
        {
            get { return _tip; }
            set { _tip = value; }
        }
        public string TipStyle
        {
            get { return _tipstyle; }
            set { _tipstyle = value; }
        }
    }
}