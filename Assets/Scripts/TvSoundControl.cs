using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvSoundControl : MonoBehaviour
{
    public AudioSource audio_tv;
    public AudioClip sound_tv;

    RenderTest rt_test;

    // Start is called before the first frame update
    void Start()
    {
        rt_test = FindObjectOfType<RenderTest>();

        audio_tv = GetComponent<AudioSource>();
        audio_tv.clip = sound_tv;

        //audio_tv.Play();

    }

    // Update is called once per frame
    void Update()
    {
        //if(!rt_test.isSoundTv)
        //{
        //    audio_tv.Stop();
        //}
    }
}
