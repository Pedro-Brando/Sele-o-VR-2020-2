using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFX : MonoBehaviour
{

    public AudioClip death;
    public AudioClip magic;
    public AudioClip coin;
	public AudioClip footStep;
    public AudioClip energy;
    public AudioClip speed;
    //public AudioClip fireCast;
    private bool isAlive = true;

    public GameObject player;
    
    Player_Col Player_Col;
    
    void Start(){
        GetComponent<Player_Col>();
    }

    void Update()
    {
        
        if (Input.GetButton ("Jump") && Player_Controls.magicFuel >= 0.001f && isAlive == true){
            GetComponent<AudioSource>().PlayOneShot (magic, 0.05f);
        }
        
    }

    void OnCollisionEnter (Collision col){
        
        if ((col.gameObject.tag == "Enemy") && isAlive == true){
        GetComponent<AudioSource>().PlayOneShot (death, 0.5f);
        isAlive = false;

        }

    }

    void OnTriggerEnter (Collider trig){
        if ((trig.gameObject.tag == "Coin") && isAlive == true){
        GetComponent<AudioSource>().PlayOneShot (coin, 0.8f);

        }

        else if ((trig.gameObject.tag == "Energy") && isAlive == true){
        GetComponent<AudioSource>().PlayOneShot (energy, 1.0f);

        }
        
        else if ((trig.gameObject.tag == "Fireball") && isAlive == true && Player_Col.hasFireball == false){
        GetComponent<AudioSource>().PlayOneShot (energy, 1.0f);
        }

        else if ((trig.gameObject.tag == "Speed") && isAlive == true){
        GetComponent<AudioSource>().PlayOneShot (speed, 0.7f);
        }

    }


    
}
