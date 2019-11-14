using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePhone : MonoBehaviour
{
    [SerializeField] GameObject Phone;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Phone_UI;

    // 거리 지정 범위
    [SerializeField] float closeDistance;

    // Start is called before the first frame update
    void Start()
    {
        // 게임 시작하자마자 핸드폰 안보이게!!
        Phone.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = Phone.transform.position - Player.transform.position;
        float currentDistance = offset.sqrMagnitude;

        if (currentDistance < closeDistance * closeDistance)
        {
            Phone_UI.SetActive(true);
        }
        else
        {
            Phone_UI.SetActive(false);
        }
    }
}
