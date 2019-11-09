using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerGameOverLogic : MonoBehaviour
{
    // 초 저장 변수
    int countDownStartValue = 300;
    public Text timerUI;
    [SerializeField] AudioSource sound_gameover;

    [SerializeField]
    public GameObject game_over;



    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            StartCoroutine(GameOver());

            // 이부분에 다음 씬 넘기기!!
            //timerUI.text = "GameOver!";
            
        }
    }

    IEnumerator GameOver()
    {
        sound_gameover.Play();
        game_over.SetActive(true);
        yield return new WaitForSeconds(5); //WaitForSeconds객체를 생성해서 반환
        SceneManager.LoadScene("Scene0_intro");
    }

    
}
