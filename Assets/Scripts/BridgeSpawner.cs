using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSpawner : MonoBehaviour
{

    public GameObject bridge;
    private float bridgeSpawnTimer = 1.0f;
    private bool hasSpawned = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bridgeSpawnTimer -= Time.deltaTime;
        if (bridgeSpawnTimer < 0.01 && GameInit.gameIsPlaying == true && hasSpawned == false) {
            SpawnBridge();
            hasSpawned = true;
        }     
        
    }

    void SpawnBridge () {
        Instantiate (bridge, new Vector3 (bridge.transform.position.x + 23.14f, bridge.transform.position.y, bridge.transform.position.z), Quaternion.identity);
        bridgeSpawnTimer = 1.0f;
    }
}
