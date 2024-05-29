using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public List<int> myList = new List<int>();

    private void Start()
    {
        myList.Add(5);
        myList.Add(10);

        myList.Insert(1, 7);

        myList.Add(15);

        myList.Remove(5);

        myList.RemoveAt(1);

    }
}

