using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//*****************************************
//创建人： Trigger 
//功能说明：
//***************************************** 
public class FlyingCarpet : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;
    private float lerpSpeed;
    private bool moveDir;

    void Start()
    {
        lerpSpeed = 1;
    }

    void Update()
    {
        if (moveDir)
        {
            transform.position = Vector3.Lerp(transform.position, endPos, lerpSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, endPos) <= 0.1f)
            {
                moveDir = false;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, startPos, lerpSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, startPos) <= 0.1f)
            {
                moveDir = true;
            }
        }
    }
}
