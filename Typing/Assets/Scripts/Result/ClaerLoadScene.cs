using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClaerLoadScene : MonoBehaviour
{
    //判定用の文字列取得用
    private TypeObj m_Type;

    private Timer m_Time;
    // Start is called before the first frame update
    void Start()
    {
        m_Type = FindObjectOfType<TypeObj>();
        m_Time = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Type.m_clearFlgShaere == true || m_Time.TimeUpShare == true) 
        {
            SceneManager.LoadScene("Result");
        }
    }
}
