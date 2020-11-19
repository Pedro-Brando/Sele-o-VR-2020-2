using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] coins;
    public GameObject [] enemy;
    public GameObject [] tree;
    public GameObject [] house;
    public GameObject [] rock;
    public GameObject [] powerUp;
    private float coinSpawnTimer = 4.0f;
    private float enemySpawnTimer = 7.0f;
    private float powerUpSpawnTimer = 10.0f;
    private float treeSpawnTimer = 1.0f;
    private float houseSpawnTimer = 1.0f;
    private float rockSpawnTimer = 1.0f;

    void Update()
    {
        coinSpawnTimer -= Time.deltaTime;
        enemySpawnTimer -= Time.deltaTime;
        treeSpawnTimer -= Time.deltaTime;
        houseSpawnTimer -= Time.deltaTime;
        rockSpawnTimer -= Time.deltaTime;
        powerUpSpawnTimer -= Time.deltaTime;

        if (coinSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
            SpawnCoins();
        }     
        if (enemySpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
            SpawnEnemy();
        }
        if (treeSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
            SpawnTree();
        }
        if (houseSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
            SpawnHouse();
        }
        if (rockSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
            SpawnRock();
        }
        if (powerUpSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
            SpawnPowerUp();
                        
    }

    void SpawnCoins () {
        Instantiate (coins[(Random.Range (0, coins.Length))], new Vector3 (Player.transform.position.x + 30, Random.Range(0, 7), 0), Quaternion.identity);
        coinSpawnTimer = Random.Range (1.0f, 3.0f);
    }

    void SpawnEnemy () {
        Instantiate (enemy[(Random.Range (0, enemy.Length))], new Vector3 (Player.transform.position.x + 30, Random.Range (2, 8), 0), Quaternion.Euler(0, -90, 0));
        enemySpawnTimer = Random.Range (1, 3);
    }

    void SpawnTree () {
        Instantiate (tree [(Random.Range (0, tree.Length))], new Vector3 (Player.transform.position.x + 70, transform.position.y + 2, Random.Range (11,13)), Quaternion.identity);
        treeSpawnTimer = Random.Range (0.5f, 1.2f);
    }

    void SpawnHouse () {
        Instantiate (house [(Random.Range (0, house.Length))], new Vector3 (Player.transform.position.x + 140, transform.position.y + 2, Random.Range (21,58)), Quaternion.Euler (0, Random.Range (0, 360), 0));
        houseSpawnTimer = Random.Range (1.0f, 2.3f);

    }

    void SpawnRock () {
        Instantiate (rock [(Random.Range (0, rock.Length))], new Vector3 (Player.transform.position.x + 140, transform.position.y + 2, Random.Range (44,78)), Quaternion.identity);
        rockSpawnTimer = Random.Range (1.0f, 2.3f);

    }

    void SpawnPowerUp() {
        Instantiate (powerUp[(Random.Range (0, powerUp.Length))], new Vector3 (Player.transform.position.x + 30, Random.Range (6, 14), 0), Quaternion.identity);
        powerUpSpawnTimer = Random.Range (7, 10);
    }
}
}
