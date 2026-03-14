using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class TestMathf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float min = 10f;
        float max = 110f;
        float f1, f2 = 0f;
        f1 = Mathf.SmoothStep(min, max, Time.time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
