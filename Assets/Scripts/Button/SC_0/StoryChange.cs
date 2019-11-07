using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryChange : MonoBehaviour
{
    [SerializeField] GameObject go_Story_UI;

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
        go_Story_UI.SetActive(true);
        //SceneManager.LoadScene("Scene1_dialog");
    }
}
