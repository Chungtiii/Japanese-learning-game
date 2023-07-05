using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mainChar : MonoBehaviour
{
    static public int charN = 0;
    public Sprite[] charIm;
    public Image _char;

    void Start()
    {
        charN = GameManager.charN;
        _char.sprite = charIm[charN];
    }


    void Update()
    {
        
    }
}
