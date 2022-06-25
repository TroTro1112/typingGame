using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource m_audioSource;
    [SerializeField] float m_Speed_VolumeDown = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void VolumeChange_Mute()
    {
        StartCoroutine("Down_Volume");
    }

    IEnumerator Down_Volume()
    {
        while (m_audioSource.volume > 0)
        {
            m_audioSource.volume -= 0.1f;
            yield return new WaitForSeconds(0.1f);

            // オーディオソースがなかったら
            if (m_audioSource == null) yield break;
        }
    }
}
