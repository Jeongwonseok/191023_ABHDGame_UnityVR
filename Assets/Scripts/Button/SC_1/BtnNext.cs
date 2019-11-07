using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnNext : MonoBehaviour
{

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
        isnext = true;

        // 일단 임시로
        //SceneManager.LoadScene("Scene2_room");
    }
}
