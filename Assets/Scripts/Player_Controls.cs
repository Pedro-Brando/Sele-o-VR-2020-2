using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    //Controles do player, voar e bola de fogo

    public static float magicFuel = 1.5f;
    public float magicForce = 10.0f;
    public Animator anim;
    public ParticleSystem magicParticles;
    public ParticleSystem explosionParticles;
    public GameObject fireBall;
    public GameObject[] inimigos;
    
    Player_Col Player_Col;
    public AudioClip fireCast;


    void Start(){
        GetComponent<Animator>();
        GetComponent<Player_Col>();
    }

    void Update()
    {
        if (Input.GetButton ("Jump") && magicFuel >= 0.001f){
            Voar();
            magicParticles.Play();
            anim.SetTrigger("JumpTrigger");
            anim.ResetTrigger("IdleTrigger");
        }
        else {
            magicParticles.Stop();
        }
        
        if (Input.GetKeyDown (KeyCode.F) && Player_Col.hasFireball == true){
        MatarInimigos();
        explosionParticles.Play();
        Player_Col.hasFireball = false;
        fireBall.gameObject.SetActive (false);
        GetComponent<AudioSource>().PlayOneShot (fireCast, 1.0f);

        }
        else {
            explosionParticles.Stop();
        }
        
    }

    void Voar () {
        magicFuel = Mathf.MoveTowards (magicFuel, 0, Time.fixedDeltaTime);
        GetComponent<Rigidbody> ().AddForce (new Vector3 (0, magicForce));
    }
    
    void MatarInimigos() {
        
        //A bola de fogo cria um array com todos os inimigos e destrói eles
        
        GameObject[] inimigos = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in inimigos)
        GameObject.Destroy(enemy);

    }

    void OnCollisionEnter (Collision Col){
        
        if (Col.gameObject.tag == "Ground"){

            anim.ResetTrigger("JumpTrigger");
            anim.SetTrigger("IdleTrigger");
            magicFuel = 1.5f;

        }
    }
}
