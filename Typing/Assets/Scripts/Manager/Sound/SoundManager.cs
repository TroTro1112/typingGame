using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    // オーディオソース
    [SerializeField] AudioSource m_AudioSource_BGM; // BGM
    [SerializeField] AudioSource m_AudioSource_SE;  // SE
    [SerializeField] AudioClip m_AudioClip_Click_SE;    // クリックSE

    // 音量の落ちる速度
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
        m_AudioSource_SE = FindObjectOfType<AudioSource>();

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

        m_AudioSource_BGM.volume = (m_Slider_BGM.value / 100.0f);
        m_AudioSource_SE.volume = (m_Slider_SE.value / 100.0f);
    }

    // SE関数の原型
    public void PlaySE()
    {
        // クリックSE
        m_AudioSource_SE.PlayOneShot(m_AudioClip_Click_SE);
        Debug.Log("SE");
    }

    public void VolumeChange_Mute()
    {
        m_IsMute = true;
        // 音量を最後まで下げる
        StartCoroutine("Down_Volume");
    }

    IEnumerator Down_Volume()
    {
        while (m_AudioSource_SE.volume > 0f)
        {
            m_AudioSource_SE.volume -= m_Speed_VolumeDown;
            yield return new WaitForSeconds(m_Speed_VolumeDown);

            // オーディオソースがなかったら
            if (m_AudioSource_SE == null) yield break;
        }
    }
}
