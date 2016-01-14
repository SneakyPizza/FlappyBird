using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public delegate void IntDelegate(int scoreTotal);
	public event IntDelegate ScoreChanged;

	private int _score = 0;

	public void AddScore(int amount = 1){
		_score += amount;
		Debug.Log (_score);
		if (ScoreChanged != null) {
			ScoreChanged(_score);
		}
	}

	public int currentScore{
		get{return _score;}
	}
}
