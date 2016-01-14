using UnityEngine;
using System.Collections;

public class ScoreHitter : MonoBehaviour {

	private Score _score;
	private GameObject _player;

	// Use this for initialization
	void Start () {
		_player = GameObject.FindGameObjectWithTag("Player");
		_score = GameObject.FindGameObjectWithTag ("Score").GetComponent<Score> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (_player.gameObject.transform.position.x >= this.gameObject.transform.position.x) {
			_score.AddScore();
			Destroy(this);
		}
	}
}
