using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hidden : MonoBehaviour
{
    //ローマ字表記
    [SerializeField]
    private GameObject m_ShowStr;
    //日本語表記
    [SerializeField]
    private GameObject m_InputStr;

    // Start is called before the first frame update
    void Start()
    {
        //設定画面の選択されたボタンで変える
        m_ShowStr.SetActive(true);
        m_InputStr.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //設定画面の選択されたボタンで変える
            m_ShowStr.SetActive(false);
            m_InputStr.SetActive(false);
            Debug.Log("false");
        }

        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            //設定画面の選択されたボタンで変える
            m_ShowStr.SetActive(true);
            m_InputStr.SetActive(true);
            Debug.Log("true");
        }
    }
}
