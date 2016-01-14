using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
    public delegate void NormalDelegate();
    public event NormalDelegate DeathEvent;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == Tags.TUBE)
        {
            if (DeathEvent != null)
                DeathEvent();
        }
    }
}
