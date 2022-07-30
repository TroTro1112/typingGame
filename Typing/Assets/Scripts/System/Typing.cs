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
    private bool m_correct;
    public bool CorretShare
    {
        set { m_correct = value; }
        get { return m_correct; }
    }

    public Text TextShare
    {
        set { m_text = value; }
        get { return m_text; }
    }
    // Start is called before the first frame update
    void Start()
    {
        m_Type = FindObjectOfType<TypeObj>();
        m_correct = false;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (string key in keys)
        {
            //一斉削除
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_text.text = "";
            }

            //入力
            if (Input.GetKeyDown(key))
            {
                m_text.text += key;
                if (m_Type.ShowStrShare.text == m_text.text)
                {
                    m_text.color = Color.white;
                    m_correct = true;
                }
            }
        }
    }
}
