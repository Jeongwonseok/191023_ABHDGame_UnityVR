using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnNext : MonoBehaviour
{
    // 다음 대사 넘기기 여부
    public bool isnext = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next_2()
    {
        // 버튼 누르면 다음 대사 넘어가도록 >> DialogueManager 스크립트 참고
        isnext = true;
    }
}
