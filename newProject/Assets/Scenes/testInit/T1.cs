using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1 : MonoBehaviour
{
    public T2 t2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning(" t1"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(t2.gameObject);
            t2.Init();
        }
    }
}
