using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Follow : MonoBehaviour
{

    private GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag ("MainCamera");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 camPos = transform.position;
        camPos.x = cam.transform.position.x;
        transform.position = Vector3.Lerp (transform.position, camPos, 3 * Time.fixedDeltaTime);
        
    }
}
