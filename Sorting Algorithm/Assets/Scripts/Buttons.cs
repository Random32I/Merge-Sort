using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject merge;
    [SerializeField] GameObject quick;

    public void Merge()
    {
        merge.SetActive(true);
    }

    public void Quick()
    {
        quick.SetActive(true);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
       
    }
}
