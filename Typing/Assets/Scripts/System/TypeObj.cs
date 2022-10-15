using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//文字自体のクラス
public class TypeObj : MonoBehaviour
{
    //ローマ字表記
    [SerializeField]
    private Text m_ShowStr;
    //日本語表記
    [SerializeField]
    private Text m_InputStr;

    TypeSystem m_System;

    private Dictionary m_Dictionary;

    private Typing m_Typing;

    private int m_EnterCount;

    private const int m_Decrement = 1;

    private int m_wordcount = 0;

    private int m_clearCount = 0;
    private bool m_clearFlg = false;

    private string[] m_word =
    {
        "sasisuseso","さしすせそ",
        "tatituteto","たちつてと",
        "naninuneno","なにぬねの",
        "pari","パリ",
        "mirano","ミラノ",
        "samurai","さむらい",
        "",""
    };
    //次に行く用
    public int EnterCountShare
    {
        get { return m_EnterCount; }
    }

    //判定用に送る
    public Text ShowStrShare
    {
        get { return m_ShowStr; }
    }
    public bool m_clearFlgShaere
    {
        get { return m_clearFlg; }
    }
    // Start is called before the first frame update
    void Start()
    {
        ChangeText("kakikukeko", "かきくけこ");

        m_System = FindObjectOfType<TypeSystem>();
        m_Dictionary = FindObjectOfType<Dictionary>();
        m_Typing = FindObjectOfType<Typing>();

        //m_System.SetInputString(m_Dictionary.GetWord());

        //m_InputStr.text = m_System.GetInputString();

        Debug.Log("Value_BGM " + PlayerPrefs.GetFloat("Value_BGM", 101f));
        Debug.Log("Value_SE " + PlayerPrefs.GetFloat("Value_SE", 101f));
    }

    // Update is called once per frame
    void Update()
    {
        //次の文字列にする
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if (m_EnterCount < m_Dictionary.WordShare.Count - m_Decrement) 
            {
                m_EnterCount++;
            }
        }


        //次の問題
        if (m_Typing.CorretShare)
        {
            if (m_wordcount < m_word.Length)
            {
                Debug.Log((m_word[m_wordcount]));
                ChangeText(m_word[m_wordcount], m_word[m_wordcount + 1]);
                m_Typing.CorretShare = false;
                m_Typing.TextShare.text = "";
                m_wordcount += 2;
                m_clearCount++;
            }
            Debug.Log(m_Typing.CorretShare);
        }

        if (m_word.Length == m_wordcount)
        {
            Debug.Log("クリアだよー");
            Debug.Log("カウント:" + m_wordcount);
            m_clearFlg = true;
            PlayerPrefs.SetInt("clear", 1);
        }
        PlayerPrefs.SetInt("clearcount", m_clearCount);
        //m_System.SetInputString(m_Dictionary.GetWord());
        //m_InputStr.text = m_System.GetInputString();
        //Debug.Log(m_EnterCount);
    }

    void ChangeText(string roma, string kana)
    {
        m_ShowStr.text = roma;
        m_InputStr.text = kana;
    }

}
