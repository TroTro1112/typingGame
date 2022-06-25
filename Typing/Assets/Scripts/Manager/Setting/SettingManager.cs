using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
    // セレクト画面
    GameObject m_SettingScreen;

    // Start is called before the first frame update
    void Start()
    {
        m_SettingScreen = GameObject.Find("Canvas/Setting");
        m_SettingScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 設定選択画面へ
    public void OnClick_ChangeScreen_Setting()
    {
        // 表示非表示を表示
        m_SettingScreen.SetActive(true);
    }

    // 設定選択画面から音量調整画面へ
    public void OnClick_ChangeScreen_Volume()
    {
        // 設定選択画面のUIを消去
        GameObject.Find("Canvas/Setting/Select").SetActive(false);

        // 音量調整画面のUIを表示
    }
}
