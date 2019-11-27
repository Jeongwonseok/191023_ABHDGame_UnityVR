using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPhone : MonoBehaviour
{
    double[] xValue = { -4.452, 0.55, -1.6 };
    double[] yValue = { -5.387, -6.65, -6.676 };
    double[] zValue = { -12.217, -12, -12 };
    int xIndex, yIndex, zIndex;

    [SerializeField] GameObject go_random;


    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(0, 3);

        if(num == 1)
        {
            go_random.transform.localPosition = new Vector3((float)xValue[num], (float)yValue[num], (float)zValue[num]);
            go_random.transform.localRotation = Quaternion.Euler(new Vector3(0, -90, 0));
        }
        else
        {
            go_random.transform.localPosition = new Vector3((float)xValue[num], (float)yValue[num], (float)zValue[num]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
