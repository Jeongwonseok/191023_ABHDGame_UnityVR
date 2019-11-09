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
        go_Back_UI.SetActive(false);
        go_Main_UI.SetActive(true);
        //SceneManager.LoadScene("Scene1_dialog");
    }
}
