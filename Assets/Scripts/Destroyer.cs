using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private float timeTilDestroy = 40.0f;

    // Update is called once per frame
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
