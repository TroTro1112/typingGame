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
        //�ݒ��ʂ�30�b��������
        //if()

        //�ݒ��ʂ�60�b��������
        //if()

 
        m_timerText.text = m_time.ToString("0.00");

        if (m_time >= 0) 
        {
            m_time -= Time.deltaTime;
        }
    }
}
