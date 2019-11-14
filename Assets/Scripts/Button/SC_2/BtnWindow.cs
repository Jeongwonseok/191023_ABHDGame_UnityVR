using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnWindow : MonoBehaviour
{
    [SerializeField] GameObject Window;
    [SerializeField] GameObject Window_UI;
    [SerializeField] AudioSource sound_Window;
    [SerializeField] Animator Window_anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_SoundOffWindow()
    {
        // 창문 사운드 Off
        sound_Window.Stop();
        // 창문 UI 파괴
        Destroy(Window_UI);
        // 창문 Animator 트리거 발동
        Window_anim.SetTrigger("Stop");
    }
}
