using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float m_time;
    [SerializeField]
    private Text m_timerText;
    private bool m_timeUp;

    //シーン遷移用
    public bool TimeUpShare
    {
        get { return m_timeUp; }
    }
    // Start is called before the first frame update
    void Start()
    {
        m_time = 30.0f;
        m_timerText.text = "0.00";
        m_timeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        //設定画面で30秒だったら
        //if()

        //設定画面で60秒だったら
        //if()

 
        m_timerText.text = m_time.ToString("0.00");

        if (m_time >= 0) 
        {
            m_time -= Time.deltaTime;
        }
        else
        {
            m_timeUp = true;
        }
    }
}
