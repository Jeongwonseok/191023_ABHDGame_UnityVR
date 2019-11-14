using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePos : MonoBehaviour
{
    [SerializeField] GameObject go_object;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Btn_UI;

    // 거리 지정 범위
    [SerializeField] float closeDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = go_object.transform.position - Player.transform.position;
        float currentDistance = offset.sqrMagnitude;

        if (currentDistance < closeDistance * closeDistance)
        {
            Btn_UI.SetActive(true);
        }
        else
        {
            Btn_UI.SetActive(false);
        }
    }
}
