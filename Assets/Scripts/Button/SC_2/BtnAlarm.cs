using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnAlarm : MonoBehaviour
{
    [SerializeField] GameObject Alarm;
    [SerializeField] GameObject Alarm_UI;

    [SerializeField] AudioSource sound_Alarm;

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
        //Alarm_UI.SetActive(false);
        //// 여기에 애니메이션 실행해야함 >> 일단 임시로!!

        // 알람 사운드 끄기
        sound_Alarm.Stop();

        Destroy(Alarm_UI);
    }
}
