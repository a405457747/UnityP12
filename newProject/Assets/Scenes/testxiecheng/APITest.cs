using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APITest : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ssk());
    }

    IEnumerator ssk()
    {
        yield return new WaitForSeconds(1f);
        print("apisk1");
        yield return new WaitForSeconds(1f);
        print("apisk2");
        yield return new WaitForSeconds(1f);
        print("apisk3");
        yield return new WaitForSeconds(1f);
        print("apisk4");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void Chiji()
    {
        print("Chiji" + this.name);
    }
}
