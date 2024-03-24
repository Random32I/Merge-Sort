using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

public class QucikSort : MonoBehaviour
{
    [SerializeField] TextMeshPro[] elements = new TextMeshPro[14];

    List<int> list = new List<int>()
    {
        11, 1, 30, 2, 51, 6, 29, 7, 67, 15, 118, 4, 89, 23
    };

    bool sorted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!sorted)
        {
            List<int> sortedList = Sort(list);

            for (int i = 0; i < sortedList.Count; i++)
            {
                elements[i].text = sortedList[i].ToString();
            }
            sorted = true;
        }
    }

    List<int> Sort(List<int> arr)
    {
        if (arr.Count == 1)
        {
            return arr;
        }

        Debug.Log(arr.Count);   

        int pivot = arr[arr.Count - 1];

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] <= pivot)
            {
                left.Add(arr[i]);
            }
            else
            {
                right.Add(arr[i]);
            }
        }

        left = Sort(left);
        right = Sort(right);

        return arr;
    }
}
