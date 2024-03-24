using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using TMPro;

public class MergeSort : MonoBehaviour
{
    [SerializeField] TextMeshPro[] elements = new TextMeshPro[14];


    [SerializeField] AudioSource split;
    [SerializeField] AudioSource merge;

    List<int> list = new List<int>() 
    {
        11, 1, 30, 2, 51, 6, 29, 7, 67, 15, 118, 4, 89, 23
    };

    bool sorted;

    void Start()
    {
        for (int i = 0; i < list.Count; i++)
        {
            elements[i].text = list[i].ToString();
        }
    }

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
        if (arr.Count == 1) {
            return arr;
        }

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        for (int i = 0; i < Mathf.Ceil(arr.Count/2); i++)
        {
            left.Add(arr[i]);
        }

        for (int i = arr.Count - 1; i >= Mathf.Ceil(arr.Count / 2); i--)
        {
            right.Add(arr[i]);
        }

        left = Sort(left);
        right = Sort(right);

        split.Play();
        return Merge(left, right);
    }

    List<int> Merge(List<int> left, List<int> right)
    {
        List<int> output = new List<int>();

        int i = 0, j = 0;


        while (i < left.Count && j < right.Count)
        {
            if (left[i] < right[j])
            {
                output.Add(left[i]);
                i += 1;
            }
            else
            {
                output.Add(right[j]);
                j += 1;
            }
        }

        for (; i < left.Count; i++)
        {
            output.Add(left[i]);
        }
        for (; j < right.Count; j++)
        {
            output.Add(right[j]);
        }

        merge.Play();
        return output;
    }
}
