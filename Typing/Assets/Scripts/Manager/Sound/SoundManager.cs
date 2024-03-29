﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    Slider m_Slider_BGM;   // BGM
    Slider m_Slider_SE;    // SE
    // 音量スライダーの格納オブジェクト
    [SerializeField] GameObject m_obj_BGM;  // BGM
    [SerializeField] GameObject m_obj_SE;   // SE

    // ミュートONOFF
    bool m_IsMute = false;

    // クリック判定
    bool m_IsClick = false;

    // Start is called before the first frame update
    void Awake()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Title":
                // volume
                m_Slider_BGM = m_obj_BGM.GetComponent<Slider>();
                m_Slider_SE = m_obj_SE.GetComponent<Slider>();

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
                break;
            case "Game":
                // データが保存されている
                if (PlayerPrefs.HasKey("Value_BGM"))
                {
                    m_AudioSource_BGM.volume = (PlayerPrefs.GetFloat("Value_BGM") / 100.0f);
                }
                else
                {
                    m_AudioSource_BGM.volume = 0.3f;
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ミュート
        if (m_IsMute == true) return;

        switch (SceneManager.GetActiveScene().name)
        {
            case "Title":
                m_AudioSource_BGM.volume = (m_Slider_BGM.value / 100.0f);
                m_AudioSource_SE.volume = (m_Slider_SE.value / 100.0f);
                // 音量設定を保存
                PlayerPrefs.SetFloat("Value_BGM", m_Slider_BGM.value);
                PlayerPrefs.SetFloat("Value_SE", m_Slider_SE.value);
                break;
        }
        // クリックSE
        if (Input.GetMouseButton(0))
        {
            if (m_IsClick == false)
            {
                m_IsClick = true;
                PlaySE();
            }
        }
        else
        {
            m_IsClick = false;
        }
    }

    // SE関数の原型
    public void PlaySE()
    {
        // クリックSE
        m_AudioSource_SE.PlayOneShot(m_AudioClip_Click_SE);
        Debug.Log("PlaySE");
    }

    public void VolumeChange_Mute()
    {
        m_IsMute = true;
        // 音量を最後まで下げる
        StartCoroutine("Down_Volume");
    }

    IEnumerator Down_Volume()
    {
        while (
            m_AudioSource_SE.volume > 0f ||
            m_AudioSource_BGM.volume > 0f)
        {
            m_AudioSource_SE.volume -= m_Speed_VolumeDown;
            m_AudioSource_BGM.volume -= m_Speed_VolumeDown;
            yield return new WaitForSeconds(m_Speed_VolumeDown);

            // オーディオソースがなかったら
            if (m_AudioSource_SE == null ||
                m_AudioSource_BGM == null) yield break;
        }
    }
}