using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//単語の読み込みクラス
public class Dictionary : MonoBehaviour
{
    List<string> m_words = new List<string>();

    TypeObj m_TypeObj;


    public List<string> WordShare
    {
        get { return m_words; }
    }

    // Start is called before the first frame update
    void Start()
    {
        m_words.Add("絶望の先");
        m_words.Add("終焉の未来");
        m_words.Add("頑丈な鉄の剣");

        m_TypeObj = FindObjectOfType<TypeObj>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetWord()
    {
        //for(int i=0;i<words.Count;i++)
        //{

        //}
        return m_words[m_TypeObj.EnterCountShare];
    }
}
