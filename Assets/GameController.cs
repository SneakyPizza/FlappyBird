using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.FindGameObjectWithTag(Tags.PLAYER);
        player.GetComponent<PlayerCollision>().DeathEvent += LoseGame;
        player.GetComponent<PlayerBounds>().DeathEvent += LoseGame;
    }
	
	private void LoseGame()
    {
        //TODO: reset score
        //TODO: reset level
    }
}
