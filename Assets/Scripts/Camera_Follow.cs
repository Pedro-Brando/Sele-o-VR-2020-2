using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    private GameObject player;
    public float cameraSpeed = 5.0f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        
    }

    void FixedUpdate()
    {
        //Seguir a posição X do Player
        Vector3 camPos = transform.position;
        camPos.x = player.transform.position.x - -9.0f;
        transform.position = Vector3.Lerp (transform.position, camPos, 3 * Time.fixedDeltaTime);
        
        //Seguir a posição Y do Player
        camPos.y = player.transform.position.y + 5;
        transform.position = Vector3.Lerp (transform.position, camPos, 6.0f * Time.fixedDeltaTime);

        if (GameInit.gameIsPlaying == false){
            camPos.x = player.transform.position.x;
            transform.position = Vector3.MoveTowards (transform.position, camPos, 2);
        }
        
    }

}
