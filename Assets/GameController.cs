using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public delegate void NormalDelegate();
    public event NormalDelegate LoseEvent;

    public GameObject tubeContainer;
	// Use this for initialization
	void Start () {
        GameObject player = GameObject.FindGameObjectWithTag(Tags.PLAYER);
        player.GetComponent<PlayerCollision>().DeathEvent += LoseGame;
        player.GetComponent<PlayerBounds>().DeathEvent += LoseGame;
    }
	
    private void StartGame()
    {
        //TODO: on first press start game
    }

	private void LoseGame()
    {
        //TODO: reset score

        if (LoseEvent != null)
            LoseEvent();

        Transform[] childTransforms = tubeContainer.GetComponentsInChildren<Transform>();
        foreach(Transform childTransform in childTransforms)
        {
            if(childTransform != this.transform)
            {
                Destroy(childTransform.gameObject);
            }
        }
    }
}
