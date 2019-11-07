using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnWindow : MonoBehaviour
{
    [SerializeField] GameObject Window;
    [SerializeField] GameObject Window_UI;

    [SerializeField] AudioSource sound_Window;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_SoundOffAlarm()
    {
        Window_UI.SetActive(false);
        // 여기에 애니메이션 실행해야함 >> 일단 임시로!!

        // 알람 사운드 끄기
        sound_Window.Stop();
    }
}
