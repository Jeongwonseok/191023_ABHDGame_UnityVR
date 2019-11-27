using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnAlarm : MonoBehaviour
{
    [SerializeField] GameObject Alarm;
    [SerializeField] GameObject Alarm_UI;

    [SerializeField] AudioSource sound_Alarm;

    [SerializeField] AudioSource sound_Effect;

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
        // 버튼 클릭 사운드 활성화
        sound_Effect.Play();
        // 알람 사운드 Off
        sound_Alarm.Stop();
        // 알람 UI 파괴
        Destroy(Alarm_UI);
    }
}
