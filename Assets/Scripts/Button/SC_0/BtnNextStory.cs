using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BtnNextStory : MonoBehaviour
{
    [SerializeField] AudioSource sound_Effect;

    // 다음 대사 넘기기 여부
    public bool isnextimage = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnNext_Image()
    {
        // 버튼 클릭 사운드 활성화
        sound_Effect.Play();

        // 버튼 누르면 다음 대사 넘어가도록 >> DialogueManager 스크립트 참고
        isnextimage = true;
    }
}
