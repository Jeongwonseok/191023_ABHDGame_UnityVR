using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBook : MonoBehaviour
{
    [SerializeField] GameObject Book;
    [SerializeField] GameObject Book_UI;
    [SerializeField] GameObject Book_Hint;
    [SerializeField] Animator Book_anim; // Animator 선언

    [SerializeField] AudioSource sound_Effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Btn_OpenBook()
    {
        // 버튼 클릭 사운드 활성화
        sound_Effect.Play();
        // 책 힌트 UI 활성화
        Book_Hint.SetActive(true);
        // 책 버튼 파괴
        Destroy(Book_UI);
        // 책 멈추기 트리거 발동
        Book_anim.SetTrigger("Stop");
    }
}
