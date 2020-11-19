using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    //Script que movimenta o player para frente
    public static int playerSpeed = 10;

    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.forward * playerSpeed * Time.fixedDeltaTime);
        
    }

}

