using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SettingManager : MonoBehaviour
{
    // 表示設定
    [SerializeField] Toggle m_togRoma;
    [SerializeField] Toggle m_togKana;
    [SerializeField] Toggle m_togKeyBoard;
    // 時間設定
    [SerializeField] ToggleGroup m_togGroupu_Time;

    // セレクト画面
    GameObject m_SettingPanel;


    public bool GetSettingPanelActive
    {
        get { return m_SettingPanel.activeSelf; }
    }

    // Start is called before the first frame update
    void Start()    // 設定画面を非表示にするため、Awakeではない
    {
        m_SettingPanel = GameObject.Find("Canvas/Setting");
        m_SettingPanel.SetActive(false);
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
        // 設定保存
        {
            // 表示設定を保存
            PlayerPrefs.SetInt("Display_Roma", m_togRoma.isOn == true ? 1 : 0);
            PlayerPrefs.SetInt("Display_Kana", m_togKana.isOn == true ? 1 : 0);
            PlayerPrefs.SetInt("Display_KeyBoard", m_togKeyBoard.isOn == true ? 1 : 0);

            // 時間設定を保存
            Debug.Log(m_togGroupu_Time.ActiveToggles().FirstOrDefault().name);
            PlayerPrefs.SetString("Time", m_togGroupu_Time.ActiveToggles().FirstOrDefault().name);
        }

        // 表示非表示を表示
        m_SettingPanel.SetActive(false);
    }
}