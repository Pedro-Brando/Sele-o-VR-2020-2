using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public static int playerSpeed = 10;

    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.forward * playerSpeed * Time.fixedDeltaTime);
        
    }

}

