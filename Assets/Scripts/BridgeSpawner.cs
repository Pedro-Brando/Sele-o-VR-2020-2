using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSpawner : MonoBehaviour
{
    //Spawner para o prefab da ponte, spawnando infinitamente
    public GameObject bridge;
    private float bridgeSpawnTimer = 1.7f;
    private bool hasSpawned = false;
    void Start()
    {
        
    }
    void Update()
    {
        //Timer para spawnar a próxima ponte, e impedir que a ponte que já criou sua próxima crie mais pontes
        bridgeSpawnTimer -= Time.deltaTime;
        if (bridgeSpawnTimer < 0.01 && GameInit.gameIsPlaying == true && hasSpawned == false) {
            SpawnBridge();
            hasSpawned = true;
        }     
        
    }

    void SpawnBridge () {
        Instantiate (bridge, new Vector3 (bridge.transform.position.x + 23.14f, bridge.transform.position.y, bridge.transform.position.z), Quaternion.identity);
        bridgeSpawnTimer = 1.7f;
    }
}
