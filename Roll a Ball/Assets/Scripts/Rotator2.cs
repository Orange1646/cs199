using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator2 : MonoBehaviour
{
    private int i = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        if (i < 10 && i >= 0)
        {
            transform.Translate(new Vector3(-1, -1, 1) * Time.deltaTime/2);
            i++;
        }
        if (i >= 10)
        {
            i = -10;
        }
        if (i >= -10 && i < 0)
        {
            transform.Translate(new Vector3(1, 1, -1) * Time.deltaTime/2);
            i++;
        }
    }
}