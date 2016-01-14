using UnityEngine;
using System.Collections;

public class PlayerBounds : MonoBehaviour {
    public delegate void NormalDelegate();
    public event NormalDelegate DeathEvent;

    public float maxY;
    public float minY;
	void Update ()
    {
	    if(this.transform.position.y > maxY || this.transform.position.y < minY)
        {
            if (DeathEvent != null)
                DeathEvent();
        }
	}
}
