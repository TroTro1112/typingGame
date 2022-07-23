using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    AudioSource m_audioSource;
    [SerializeField] float m_Speed_VolumeDown = 0.1f;

    // 音量スライダー
    [SerializeField] Slider m_Slider_BGM;   // BGM
    [SerializeField] Slider m_Slider_SE;    // SE

    // ミュートONOFF
    bool m_IsMute = false;

    // Start is called before the first frame update
    void Start()
    {
        // オーディオソース
        m_audioSource = FindObjectOfType<AudioSource>();

        float max = 100f;
        float now = 100f;

        //スライダーの最大値・最小値の設定
        m_Slider_BGM.maxValue = max;
        m_Slider_BGM.minValue = 0f;
        m_Slider_SE.maxValue = max;
        m_Slider_SE.minValue = 0f;

        //スライダーの現在値の設定
        m_Slider_BGM.value = now;
        m_Slider_SE.value = now;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_IsMute == true) return;

        m_audioSource.volume = (m_Slider_BGM.value/100.0f);
        m_audioSource.volume = (m_Slider_SE.value/100.0f);
    }

    public void VolumeChange_Mute()
    {
        m_IsMute = true;
        // 音量を最後まで下げる
        StartCoroutine("Down_Volume");
    }

    IEnumerator Down_Volume()
    {
        while (m_audioSource.volume > 0)
        {
            m_audioSource.volume -= m_Speed_VolumeDown;
            yield return new WaitForSeconds(m_Speed_VolumeDown);

            // オーディオソースがなかったら
            if (m_audioSource == null) yield break;
        }
    }
}
