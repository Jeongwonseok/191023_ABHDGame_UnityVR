using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    [SerializeField] GameObject go_DialogueBar;

    [SerializeField] Text txt_Dialogue;

    [SerializeField] GameObject btn_next; // 다음 이미지로 넘기는 버튼
    [SerializeField] GameObject btn_home; // 홈으로 돌아가는 버튼

    BtnNextStory theNext;

    bool isNext = true;

    int contextCount = 0;

    [Header("텍스트 출력 딜레이")]
    [SerializeField] float textDelay;

    [SerializeField] Image Img_Story;
    [SerializeField] Sprite[] Img_Stories;

    string[] arr_context = {"재민이는 어제 늦게까지 술먹다가 뻗었다. 눈 떠보니 지각위기!",
                                "F를 모면하기 위해 서두르는 재민이",
                                "그런데 휴대폰이 어디갔지? 재민은 자신의 휴대폰을 찾는데...",
                                "휴대폰 소리는 들리는데 잡소리도 같이 들린다. 이걸 어케찾지...?"};

    // Start is called before the first frame update
    void Start()
    {
        theNext = FindObjectOfType<BtnNextStory>();
        txt_Dialogue.text = arr_context[contextCount];
        Img_Story.sprite = Img_Stories[contextCount];
        SettingUI(true); // 일단 true 세팅 
    }

    // Update is called once per frame
    void Update()
    {
        if (isNext)
        {
            if (theNext.isnextimage) //BtnNext 스크립트에서 isnext값 받아오기
            {
                // 잠시 다 없애고
                
                isNext = false;
                theNext.isnextimage = false;
                txt_Dialogue.text = "";
                SettingUI(false);
                btn_next.SetActive(false); // 일단 다음버튼 없애기

                // 만약 배열 마지막 인덱스 보다 작으면 인덱스 반복적으로 증가
                if (contextCount < arr_context.Length - 1)
                {
                    ++contextCount;
                    Img_Story.sprite = Img_Stories[contextCount];
                    StartCoroutine(TypeWriter());
                }
            }
        }
    }

    IEnumerator TypeWriter()
    {
        SettingUI(true);

        // 만약에 배열 인덱스가 마지막 배열이면 게임시작 버튼 true
        if (contextCount == arr_context.Length - 1)
        {

            string t_ReplaceText = arr_context[contextCount];


            // 텍스트 한글자씩 딜레이 출력
            for (int i = 0; i < t_ReplaceText.Length; i++)
            {
                txt_Dialogue.text += t_ReplaceText[i];
                yield return new WaitForSeconds(textDelay);
            }

            btn_home.SetActive(true); // 게임 시작 버튼

            isNext = true;
            theNext.isnextimage = false;
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
            theNext.isnextimage = false;
        }


    }

    // UI Setting 메서드
    void SettingUI(bool p_flag)
    {
        go_DialogueBar.SetActive(p_flag);
    }
}
