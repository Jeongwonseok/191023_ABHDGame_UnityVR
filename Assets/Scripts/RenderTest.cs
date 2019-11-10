using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderTest : MonoBehaviour
{
    // 버튼 클릭 시, tv색상 바꾸기 >> 임시 
    [SerializeField]
    public GameObject go_test;

    [SerializeField]
    public GameObject go_UI;

    [SerializeField]
    public AudioSource test;

    //public bool isSoundTv = true;

    /*
    [SerializeField]
    public GameObject go_controller;

    [SerializeField]
    public Canvas cTest;
    */

    public void Test()
    {
        // 이부분에 사운드 끄는거 구현해야함!
        //go_test.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);

        test.Stop();

        //isSoundTv = false;

        // UI 오브젝트 파괴
        Destroy(go_UI);
    }
}
