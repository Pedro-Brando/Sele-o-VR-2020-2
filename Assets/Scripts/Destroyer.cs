using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Script de autodestruição para não lotar a memória do game
    private float timeTilDestroy = 40.0f;

    void Update()
    {
        timeTilDestroy -= Time.deltaTime;
        if (timeTilDestroy < 0.01 && GameInit.gameIsPlaying == true){
            Destroy (gameObject);
        }
        
    }

    void OnCollisionEnter (Collision col){
    if ((col.gameObject.tag == "Player")){
        timeTilDestroy = 40.0f;
    }
}
}
