using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int[] myArray2 = { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27 };

    void Start()
    {
        for (int i = 0; i < myArray2.Length; i++)
        {
            print(myArray2[i]);
        }
    }
}