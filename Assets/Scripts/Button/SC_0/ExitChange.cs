using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitChange : MonoBehaviour
{
    [SerializeField] AudioSource sound_Effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SceneChange()
    {
        // 버튼 클릭 사운드 활성화
        sound_Effect.Play();

        // App 종료 코딩 해야함!!
        //Application.Quit();
    }

}
