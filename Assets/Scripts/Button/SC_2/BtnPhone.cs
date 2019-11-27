using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnPhone : MonoBehaviour
{
    [SerializeField] GameObject Phone;
    [SerializeField] GameObject Phone_UI;
    [SerializeField] GameObject Clear_UI;
    [SerializeField] AudioSource sound_gameclear;

    [SerializeField] AudioSource sound_Effect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Btn_GameClear()
    {
        // 버튼 클릭 사운드 활성화
        sound_Effect.Play();
        // 핸드폰 렌더러 true
        Phone.GetComponent<Renderer>().enabled = true;
        // Game Clear UI 홣성화
        Clear_UI.SetActive(true);
        // Game Clear 사운드 재생
        sound_gameclear.Play();
        // 5초 뒤 Scene 전환
        Invoke("GameClear", 5.0f);

    }
    // Scene 전환 메서드
    void GameClear()
    {
        SceneManager.LoadScene("Scene0_intro");
    }
}
