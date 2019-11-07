using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnGame : MonoBehaviour
{
    //public bool isGame = false;

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

    public void Game_2()
    {
        changer.FadeToNextLevel();
        //SceneManager.LoadScene("Scene2_room");
    }
}
