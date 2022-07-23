using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
    // セレクト画面
    GameObject m_SettingPanel;

    // Start is called before the first frame update
    void Start()
    {
        m_SettingPanel = GameObject.Find("Canvas/Setting");
        m_SettingPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    // 設定選択画面へ
    public void OnClick_ChangeScreen_Setting()
    {
        // 表示非表示を表示
        m_SettingPanel.SetActive(true);
    }
}
