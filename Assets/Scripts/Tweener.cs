using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(activeTween.Target.position, activeTween.EndPos);

        if (distance > 0.1f)
        {
            float tF = (Time.time - activeTween.StartTime) / activeTween.Duration;
            tF = tF * tF * tF;
            activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, tF);
        }

        else
        {
            activeTween.Target.position = activeTween.EndPos;
            activeTween = null;
        }
    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (activeTween == null)
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }

        
}
