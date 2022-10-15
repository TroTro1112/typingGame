using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClaerCount : MonoBehaviour
{
    // Start is called before the first frame update
    int m_claerflg;
    //ローマ字表記
    //[SerializeField]
    //private Text m_Text;

    [SerializeField]
    private Text m_claerCount;

    [SerializeField]
    private Text m_missCount;

    private int m_count;


    void Start()
    {
        //m_claerflg = PlayerPrefs.GetInt("clear");
        m_claerCount.text =  PlayerPrefs.GetInt("clearcount").ToString();
        
        //highscoretext.text = PlayerPrefs.GetInt("Highscore").ToString();
        m_missCount.text = PlayerPrefs.GetInt("miss").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //if(m_claerflg == 1)
        //{
        //    m_Text.text = "全入力成功!!";
        //}
    }
}
