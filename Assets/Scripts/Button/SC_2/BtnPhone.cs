using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnPhone : MonoBehaviour
{
    [SerializeField] GameObject Phone;
    [SerializeField] GameObject Phone_UI;
    [SerializeField] GameObject Clear_UI;



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
        //Phone_UI.SetActive(false);

        //// 여기에 핸드폰 보이게 렌더러 알파값 255
        //Phone.GetComponent<Renderer>().enabled = true;

        //Clear_UI.SetActive(true);

        StartCoroutine(GameClear());
        
    }

    IEnumerator GameClear()
    {

        // 여기에 핸드폰 보이게 
        Phone.GetComponent<Renderer>().enabled = true;

        //Phone_UI.SetActive(false);

        Clear_UI.SetActive(true);

        yield return new WaitForSeconds(5); //WaitForSeconds객체를 생성해서 반환

        SceneManager.LoadScene("Scene0_intro");
    }
}
