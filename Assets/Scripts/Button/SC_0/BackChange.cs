using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackChange : MonoBehaviour
{
    [SerializeField] GameObject go_Back_UI;
    [SerializeField] GameObject go_Main_UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChange_Back()
    {
        // Story UI 비활성화
        go_Back_UI.SetActive(false);
        // Intro UI 활성화 
        go_Main_UI.SetActive(true);
    }
}
