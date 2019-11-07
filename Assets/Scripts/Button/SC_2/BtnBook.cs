using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBook : MonoBehaviour
{
    [SerializeField] GameObject Book;
    [SerializeField] GameObject Book_UI;
    [SerializeField] GameObject Book_Hint;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Btn_OpenBook()
    {
        Book_UI.SetActive(false);
        // 여기에 애니메이션 실행해야함 >> 일단 임시로!!

        // 책 힌트 제공
        Book_Hint.SetActive(true);
        
    }
}
