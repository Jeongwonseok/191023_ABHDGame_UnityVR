using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;

    //StartChange st_c;
    //BtnGame bt_g;

    // 최종적으로 바꿀 씬 인덱스 저장 변수
    private int levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        //st_c = FindObjectOfType<StartChange>();
        //bt_g = FindObjectOfType<BtnGame>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(st_c.isStart)
        //{
        //    FadeToNextLevel();
        //    st_c.isStart = false;
        //}
        //else
        //{
        //    FadeToNextLevel();
        //    bt_g.isGame = false;
        //}
    }

    // 다음 씬 매개변수로 전달
    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // 저장 변수에 매개변수 저장하고 트리거 일단 발생
    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    // 이벤트 정의 >> 다음 씬 넘어가는 이벤트
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
