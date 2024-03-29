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
        //設定画面で30秒だったら
        if (PlayerPrefs.GetString("Time") == "Toggle_30")
        {
            m_time = 30.0f;
        }

        //設定画面で60秒だったら
        if (PlayerPrefs.GetString("Time") == "Toggle_60")
        {
            m_time = 60.0f;
        }

        //設定画面で120秒だったら
        if (PlayerPrefs.GetString("Time") == "Toggle_120")
        {
            m_time = 120.0f;
        }

        m_timerText.text = "0.00";
        m_timeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
 
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
