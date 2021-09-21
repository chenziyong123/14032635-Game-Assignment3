using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject man;
    private Tweener tweener;
    public Animator a;
    public AudioSource WalkAudio;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        tweener.AddTween(man.transform, new Vector3(-2.5f, 4.5f, 0f),new Vector3(-2.5f, 4.5f, 0f), 3f);
        man.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        // man move and change animation
        if (man.transform.position == new Vector3(-2.5f, 4.5f, 0f))
        {
            a.SetInteger("Veritical",0);
            a.SetInteger("Hori",1);
            tweener.AddTween(man.transform, man.transform.position, new Vector3(2.5f, 4.5f, 0f), 3f);
           WalkAudio.Play();
           WalkAudio.loop = true;
        }
        
         if (man.transform.position == new Vector3(2.5f, 4.5f, 0f) )
        {
            a.SetInteger("Hori",0);
            a.SetInteger("Veritical",-1);
            tweener.AddTween(man.transform, man.transform.position, new Vector3(2.5f, 0.5f, 0f), 3f);
            WalkAudio.Play();  
            WalkAudio.loop = true;
        }
        
        if (man.transform.position == new Vector3(2.5f, 0.5f, 0f))
        {
            a.SetInteger("Veritical",0);
            a.SetInteger("Hori",-1);
            tweener.AddTween(man.transform, man.transform.position, new Vector3(-2.5f, 0.5f, 0f), 3f);
            WalkAudio.Play();   
            WalkAudio.loop = true;
        }
        
         if (man.transform.position == new Vector3(-2.5f, 0.5f, 0f) )
        {
            a.SetInteger("Hori",0);
            a.SetInteger("Veritical",1);
            tweener.AddTween(man.transform, man.transform.position, new Vector3(-2.5f, 4.5f, 0f), 3f);
            WalkAudio.Play();  
            WalkAudio.loop = true;   
        }
    }
}
