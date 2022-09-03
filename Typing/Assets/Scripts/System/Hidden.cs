using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hidden : MonoBehaviour
{
    //���[�}���\�L
    [SerializeField]
    private GameObject m_ShowStr;
    //���{��\�L
    [SerializeField]
    private GameObject m_InputStr;

    // Start is called before the first frame update
    void Start()
    {
        //�ݒ��ʂ̑I�����ꂽ�{�^���ŕς���
        m_ShowStr.SetActive(true);
        m_InputStr.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //�ݒ��ʂ̑I�����ꂽ�{�^���ŕς���
            m_ShowStr.SetActive(false);
            m_InputStr.SetActive(false);
            Debug.Log("false");
        }

        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            //�ݒ��ʂ̑I�����ꂽ�{�^���ŕς���
            m_ShowStr.SetActive(true);
            m_InputStr.SetActive(true);
            Debug.Log("true");
        }
    }
}
