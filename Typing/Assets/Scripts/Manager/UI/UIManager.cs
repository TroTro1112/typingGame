using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    Text m_Text_Press;
    bool m_IsAlpha;
    bool m_IsPress;
    float m_Alpha;
    Color m_Color;
    [SerializeField]
    float m_AlphaSpeed;

    // Start is called before the first frame update
    void Start()
    {
        m_Text_Press = GameObject.Find("Text_Press").GetComponent<Text>();
        m_IsAlpha = false;
        m_IsPress = false;
        m_Alpha = m_Text_Press.color.a;
        m_Color = m_Text_Press.color;
    }

    // Update is called once per frame
    void Update()
    {
        // 早期リターン、シーン遷移された
        if (m_IsPress) return;

        //テキストの透明度を変更する
        m_Text_Press.color = new Color(m_Color.r, m_Color.g, m_Color.b, m_Alpha);

        // a_flagがtrueの間実行する
        m_Alpha += m_IsAlpha == true ?
            -Time.deltaTime * m_AlphaSpeed :
            Time.deltaTime * m_AlphaSpeed;

        //透明度が0になったら終了する。
        if (m_Alpha < 0.3f)
        {
            m_Alpha = 0.3f;
            m_IsAlpha = false;
        }
        else if (m_Alpha > 1.0f)
        {
            m_Alpha = 1.0f;
            m_IsAlpha = true;
        }

        // シーン遷移
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.gameObject.GetComponent<FadeManager>().LoadScene("Game", 0.8f);

            // 音量を0にする
            this.gameObject.GetComponent<SoundManager>().VolumeChange_Mute();

            m_IsPress = true;
        }
    }
}