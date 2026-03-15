using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DoTweenTest : MonoBehaviour
{
    private Tween t;
    // Start is called before the first frame update
    void Start()
    {
        /*
        Camera camera = Camera.main;
        camera.DOAspect(0.5f, 2f);
        camera.DOColor(Color.red, 2f);
        
        
        t=transform.DOMoveX(2, 2).From(true).SetDelay(13f);
        StartCoroutine(Wait());
        t.SetAutoKill(false);
        t.Pause();
        t.PlayForward();
        t.PlayBackwards();
        */
        DOVirtual.DelayedCall(2, () =>
        {
            print("hhh");
        });
        /*
        //t.DORewind();
        Sequence q =DOTween.Sequence();
        q.AppendInterval(1f);
        q.InsertCallback(3, () => { });
        */
        t.ElapsedPercentage(true);
        t.Duration(true);
        //t.fullPosition
    }

    IEnumerator Wait()
    {
        yield return t.WaitForCompletion();
        yield return new WaitForSeconds(3f);
        print("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
