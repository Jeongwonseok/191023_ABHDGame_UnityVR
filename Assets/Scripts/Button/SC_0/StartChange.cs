using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartChange : MonoBehaviour
{
    //public bool isStart = false;

    LevelChanger changer;

    // Start is called before the first frame update
    void Start()
    {
        changer = FindObjectOfType<LevelChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChange_Start()
    {
        changer.FadeToNextLevel();
        //SceneManager.LoadScene("Scene1_dialog");
    }
}
