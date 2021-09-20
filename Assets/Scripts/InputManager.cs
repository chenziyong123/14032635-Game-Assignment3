using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject man;
    private Tweener tweener;
    private Vector3 endPos;
    private int Step = 0;
    public Animator a;

    // Start is called before the first frame update
    void Start()
    {
        endPos = new Vector3(-2.5f, 4.5f, 0f);
        tweener = GetComponent<Tweener>();
        tweener.AddTween(man.transform, endPos, endPos, 3);
        man.GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        // man move and change animation
        if (man.transform.position == endPos && Step == 0)
        {
            a.SetInteger("Veritical",0);
            a.SetInteger("Hori",1);
            man.transform.rotation = Quaternion.Euler(0, 0, 0);
            endPos = new Vector3(2.5f, 4.5f, 0f);
            tweener.AddTween(man.transform, man.transform.position, endPos, 3);
            Step = 1;
        }
        else if (man.transform.position == endPos && Step == 1)
        {
            a.SetInteger("Hori",0);
            a.SetInteger("Veritical",-1);
            endPos = new Vector3(2.5f, 0.5f, 0f);
            tweener.AddTween(man.transform, man.transform.position, endPos, 3);
            Step = 2;   
        }
        else if (man.transform.position == endPos && Step == 2)
        {
            a.SetInteger("Veritical",0);
            a.SetInteger("Hori",-1);
            endPos = new Vector3(-2.5f, 0.5f, 0f);
            tweener.AddTween(man.transform, man.transform.position, endPos, 3);
            Step = 3;         
        }
        else if (man.transform.position == endPos && Step == 3)
        {
            a.SetInteger("Hori",0);
            a.SetInteger("Veritical",1);
            endPos = new Vector3(-2.5f, 4.5f, 0f);
            tweener.AddTween(man.transform, man.transform.position, endPos, 3);
            Step = 0;       
        }
    }
}
