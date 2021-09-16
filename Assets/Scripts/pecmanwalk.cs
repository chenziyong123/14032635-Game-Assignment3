using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pecmanwalk : MonoBehaviour
{         
    Animator a;
     public Animator animatorController;
    // Start is called before the first frame update
    void Start()
    {
        
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    

    float V= Input.GetAxisRaw("Vertical");
        a.SetInteger("Veritical",(int)V);
    
    float H= Input.GetAxisRaw("Horizontal");
        a.SetInteger("Hori",(int)H);
    }
}
