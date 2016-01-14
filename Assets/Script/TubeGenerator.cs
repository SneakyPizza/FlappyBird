using UnityEngine;
using System.Collections;

public class TubeGenerator : MonoBehaviour {
    public GameObject tube;
    public float spawnSpeed;
    public float horizontalSpawnDistance;
    public GameObject tubeContainer;

    private float oldX = 0;
    private float maxY = 4;
    private float minY = -4;
    private float currentSpawnTimer = 0;
    void Update()
    {
        if(currentSpawnTimer < Time.time)
        {
            currentSpawnTimer = spawnSpeed + Time.time;
            Vector3 spawnPos = new Vector3(horizontalSpawnDistance + oldX, Random.Range(minY, maxY), 0);
            GameObject newTube = Instantiate(tube, spawnPos, Quaternion.identity) as GameObject;
            newTube.transform.parent = tubeContainer.transform;
            oldX = newTube.transform.position.x;
        }
    }
}
