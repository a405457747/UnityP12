using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning(" t2");
    }

    void Awake()
    {
        print("awake");
    }

    private void OnEnable()
    {
        print("OnEnable");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init()
    {
       print("init");
    }
}
