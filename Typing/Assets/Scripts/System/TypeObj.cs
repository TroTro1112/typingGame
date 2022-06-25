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

    private int m_EnterCount;

    private const int m_Decrement = 1;


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

    // Start is called before the first frame update
    void Start()
    {
        ChangeText();

        m_System = FindObjectOfType<TypeSystem>();
        m_Dictionary = FindObjectOfType<Dictionary>();

        //m_System.SetInputString(m_Dictionary.GetWord());
       
        //m_InputStr.text = m_System.GetInputString();
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
        //m_System.SetInputString(m_Dictionary.GetWord());
        //m_InputStr.text = m_System.GetInputString();
        //Debug.Log(m_EnterCount);
    }

    void ChangeText()
    {
        m_ShowStr.text = "kakikukeko";
        m_InputStr.text = "かきくけこ";
    }

}
