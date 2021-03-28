using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    [Serializable]
    public class HitEvent : UnityEvent<int> { }
    public HitEvent onHit = new HitEvent();
    // Start is called before the first frame update

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            FigureOutScore(collision.transform.position);
        }
    }

    private void FigureOutScore(Vector3 hitPosition)
    {
        float distanceFromCenter = Vector3.Distance(transform.position, hitPosition);
        int score = 0;
        if (distanceFromCenter < 0.25f)
        {
            score = 15;
        }
        else if (distanceFromCenter < 0.5f)
        {
            score = 5;
        }

        onHit.Invoke(score);

    }
}
