using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField] float m_Speed_VolumeDown = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void VolumeChange()
    {
        StartCoroutine("VolumeDown");
    }

    IEnumerator VolumeDown()
    {
        while (audioSource.volume > 0)
        {
            audioSource.volume -= 0.1f;
            yield return new WaitForSeconds(0.1f);

            // オーディオソースがなかったら
            if (audioSource == null) yield break;
        }
    }
}
