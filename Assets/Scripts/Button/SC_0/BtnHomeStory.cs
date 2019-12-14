using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnHomeStory : MonoBehaviour
{
    [SerializeField] AudioSource sound_Effect;

    [SerializeField] GameObject UI_Story;
    [SerializeField] GameObject UI_Home;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnHome()
    {
        // 버튼 클릭 사운드 활성화
        sound_Effect.Play();

        // Story UI 비활성화
        UI_Story.SetActive(false);

        UI_Home.SetActive(true);
    }
}
