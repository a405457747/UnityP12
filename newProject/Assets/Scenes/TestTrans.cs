using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrans : MonoBehaviour
{
    Coroutine cck;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ssk());

        Invoke("gok", 5f);

    }
    void gok()
    {
        print("i am gok");
    }

    IEnumerator ssk()
    {
        yield return new WaitForSeconds(1f);
        print("sk1");
        yield return new WaitForSeconds(1f);
        print("sk2");
        yield return new WaitForSeconds(1f);
        print("sk3");
        yield return new WaitForSeconds(1f);
        print("sk4");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //cck = null;置空还在必须停止
           //StopCoroutine("ssk");//这样无法停止
            print("a");
            StopAllCoroutines();//只会停止自己的脚本上的，别人脚本上停不了

            if (IsInvoking("gok"))
            {
                CancelInvoke("gok");
            }
            else
            {
                print("meiyou");
            }
        }
    }
}
