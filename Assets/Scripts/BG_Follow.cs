using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Follow : MonoBehaviour
{
    //Script para prender o background a câmera, dando a ilusão de fundo infinito

    private GameObject cam;
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag ("MainCamera");
        
    }

    void FixedUpdate()
    {
        Vector3 camPos = transform.position;
        camPos.x = cam.transform.position.x;
        transform.position = Vector3.Lerp (transform.position, camPos, 3 * Time.fixedDeltaTime);
        
    }
}
