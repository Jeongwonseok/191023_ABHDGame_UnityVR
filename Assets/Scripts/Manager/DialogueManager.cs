using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject go_DialogueBar;

    [SerializeField] Text txt_Dialogue;

    [SerializeField] GameObject btn_next; // 다음 대사로 넘기는 버튼
    [SerializeField] GameObject btn_exit; // 다음 씬으로 넘기는 버튼

    BtnNext theNext;

    bool isNext = true;

    int contextCount = 0;

    [Header("텍스트 출력 딜레이")]
    [SerializeField] float textDelay;

    [SerializeField] string[] sound_dialog;

    string[] arr_context = {"음~ 개운한 아침~",
                                "응? 잠깐만. 개운..해..? 지금 몇시지?",
                                "8시 30분? ㅈ댓다 오늘 1교신데!!!!",
                                ".... .",
                                "...!!?!??",
                                "?!?!?!?!?!?!?!?!?!",
                                "아~ 왜 이렇게 카톡이 울려.",
                                "어 근데 내 폰 어딨지?"};

    void Start()
    {
        theNext = FindObjectOfType<BtnNext>();

        txt_Dialogue.text = arr_context[contextCount];

        // 일단 처음에 새소리 재생
        SoundManager.instance.PlaySE(sound_dialog[contextCount]);

        SettingUI(true); // 일단 true 세팅 

    }

    void Update()
    {
        if (isNext)
        {
            if (theNext.isnext) //BtnNext 스크립트에서 isnext값 받아오기
            {
                // 잠시 다 없애고
                SoundManager.instance.StopSE(sound_dialog[contextCount]);
                isNext = false;
                theNext.isnext = false;
                txt_Dialogue.text = "";
                SettingUI(false);
                btn_next.SetActive(false); // 일단 다음버튼 없애기

                // 만약 배열 마지막 인덱스 보다 작으면 인덱스 반복적으로 증가
                if (contextCount < arr_context.Length - 1)
                {
                    ++contextCount;
                    // 대사나오면서 사운드 재생하는 부분
                    SoundManager.instance.PlaySE(sound_dialog[contextCount]);
                    StartCoroutine(TypeWriter());
                }
            }
        }

    }

    IEnumerator TypeWriter()
    {
        SettingUI(true);

        // 만약에 배열 인덱스가 마지막 배열이면 게임시작 버튼 true
        if(contextCount == arr_context.Length - 1)
        {

            string t_ReplaceText = arr_context[contextCount];


            // 텍스트 한글자씩 딜레이 출력
            for (int i = 0; i < t_ReplaceText.Length; i++)
            {
                txt_Dialogue.text += t_ReplaceText[i];
                yield return new WaitForSeconds(textDelay);
            }

            btn_exit.SetActive(true); // 게임 시작 버튼

            isNext = true;
            theNext.isnext = false;
        }
        else // 아니면 다음 버튼 true
        {

            string t_ReplaceText = arr_context[contextCount];


            // 텍스트 한글자씩 딜레이 출력
            for (int i = 0; i < t_ReplaceText.Length; i++)
            {
                txt_Dialogue.text += t_ReplaceText[i];
                yield return new WaitForSeconds(textDelay);
            }

            btn_next.SetActive(true); // 다음 대사 버튼

            isNext = true;
            theNext.isnext = false;
        }

        
    }

    // UI Setting 메서드
    void SettingUI(bool p_flag)
    {
        go_DialogueBar.SetActive(p_flag);
    }
}
