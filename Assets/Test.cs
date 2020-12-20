using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int d = 4; d >= 0; d--)
        {
            Debug.Log(array[d]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
