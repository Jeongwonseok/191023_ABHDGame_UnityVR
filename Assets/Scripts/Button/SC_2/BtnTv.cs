using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnTv : MonoBehaviour
{
    // 나중에 이미지 넣을 오브젝트 >> 꺼지도록 구현해야함
    [SerializeField]
    public GameObject Tv_Image;

    [SerializeField]
    public GameObject Tv_UI;

    [SerializeField]
    public AudioSource sound_Tv;

    [SerializeField] AudioSource sound_Effect;

    public void Btn_SoundOffTv()
    {
        // 버튼 클릭 사운드 활성화
        sound_Effect.Play();
        // Tv 사운드 중지
        sound_Tv.Stop();
        Tv_Image.SetActive(false);
    }
}
