using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float m_time;
    [SerializeField]
    private Text m_timerText;

    // Start is called before the first frame update
    void Start()
    {
        m_time = 30.0f;
        m_timerText.text = "0.00";
    }

    // Update is called once per frame
    void Update()
    {
        //設定画面で30秒だったら
        //if()

        //設定画面で60秒だったら
        //if()

        m_time -= Time.deltaTime;
        m_timerText.text = m_time.ToString("0.00");

        if (m_time < 0) 
        {

        }
    }
}
