
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class APITest1 : MonoBehaviour
{
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        print(this.isActiveAndEnabled);
       // ani.CrossFadeInFixedTime("Run",0.5f);

        for (int i = 0; i < 5; i++)
        {
            print(Random.Range(0,3f));
        }

        Object obj = Resources.Load("sound");
        //AudioClip ac = obj as AudioClip;
        AudioClip ac = (AudioClip)obj;
        AudioSource.PlayClipAtPoint(ac, transform.position);
    }

}
