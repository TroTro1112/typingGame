using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�Q�[���V�X�e���n�N���X
public class TypeSystem : MonoBehaviour
{
    public string m_RememberStr;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(m_RememberStr);
        m_RememberStr = "error";
        Debug.Log(m_RememberStr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetInputString(string settext)
    {
        m_RememberStr = settext;
    }

    public string GetInputString()
    {
        return m_RememberStr;
    }
}
