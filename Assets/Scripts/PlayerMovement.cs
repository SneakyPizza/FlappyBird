using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	private Rigidbody2D _rigid;
	// Use this for initialization
	void Start () {
		_rigid = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			_rigid.velocity += new Vector2(0,3);
		}
	}
}
