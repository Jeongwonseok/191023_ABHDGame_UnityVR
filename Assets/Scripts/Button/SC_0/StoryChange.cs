using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryChange : MonoBehaviour
{
    [SerializeField] GameObject go_Story_UI;
    [SerializeField] GameObject go_Main_UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChange_Story()
    {
        // Story UI 활성화
        go_Story_UI.SetActive(true);
        // Intro UI 비활성화
        go_Main_UI.SetActive(false);
    }
}
