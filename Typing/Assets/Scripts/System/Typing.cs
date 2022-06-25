using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typing : MonoBehaviour
{
    //入力用文字列
    [SerializeField]
    private Text m_text;
    //比較用
    string[] keys = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "-", };
    //判定用の文字列取得用
    private TypeObj m_Type;

    // Start is called before the first frame update
    void Start()
    {
        m_Type = FindObjectOfType<TypeObj>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (string key in keys)
        {
            if (Input.GetKeyDown(key))
            {
                //文字列入力
                m_text.text += key;

                //文字列判定
                if (m_Type.ShowStrShare.text == m_text.text) 
                {
                    m_text.color = Color.white;
                }
            }
        }
    }
}
