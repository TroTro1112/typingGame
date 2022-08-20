using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
    // セレクト画面
    GameObject m_SettingPanel;
    public bool GetSettingPanelActive
    {
        get{ return m_SettingPanel.activeSelf; }
    }

    // Start is called before the first frame update
    void Start()    // 設定画面を非表示にするため、Awakeではない
    {
        m_SettingPanel = GameObject.Find("Canvas/Setting");
        m_SettingPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    // 設定選択画面を表示
    public void OnClick_ChangeScreen_Setting()
    {
        // 表示非表示を表示
        m_SettingPanel.SetActive(true);
    }

    // 設定選択画面を表示
    public void OnClick_ChangeScreen_Title()
    {
        // 表示非表示を表示
        m_SettingPanel.SetActive(false);
    }
}