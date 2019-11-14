﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartChange : MonoBehaviour
{
    //public bool isStart = false;

    LevelChanger changer;

    // Start is called before the first frame update
    void Start()
    {
        changer = FindObjectOfType<LevelChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChange_Start()
    {
        // 게임 시작 하기!! >> 애니메이션 끝에 Scene 전환 메서드 추가되어있음!!
        changer.FadeToNextLevel();
        //SceneManager.LoadScene("Scene1_dialog");
    }
}
