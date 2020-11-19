using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Col : MonoBehaviour
{

    public GameObject RestartUI;
    public GameObject Trail;
    public GameObject fireBall;
    public Animator anim;
    public ParticleSystem magic;

    public float speedBuff = 10.0f;
    
    private bool isAlive = true;
    public static bool hasFireball = false;


void Update () {
    speedBuff -= Time.deltaTime;
    if (speedBuff <= 0.01) {
        Player_Move.playerSpeed = 10;
        Trail.gameObject.SetActive (false);
    }

}

    
void OnCollisionEnter (Collision col){
    if ((col.gameObject.tag == "Enemy") && isAlive == true){
        PlayerDies();
    }
}

void OnTriggerEnter(Collider trig){
    if ((trig.gameObject.tag == "Coin") && isAlive == true){
            DataManagement.datamanagement.coinsCollected ++;
            DataManagement.datamanagement.currentScore ++;
            Destroy (trig.gameObject);
    }

    if ((trig.gameObject.tag == "Energy") && isAlive == true){
        Player_Controls.magicFuel = 1.5f;
        Destroy (trig.gameObject);
    }

    if ((trig.gameObject.tag == "Fireball") && isAlive == true && hasFireball == false){
        fireBall.gameObject.SetActive (true);
        hasFireball = true;
        Destroy (trig.gameObject);
    }

    if ((trig.gameObject.tag == "Speed") && isAlive == true){
        speedBuff = 10.0f;
        Player_Move.playerSpeed = 15;
        Trail.gameObject.SetActive (true);
        Destroy (trig.gameObject);
    }
}



void PlayerDies () {
    isAlive = false;
    GameInit.gameIsPlaying = false;
    anim.SetTrigger("DeathTrigger");
    DataManagement.datamanagement.SaveData();
    RestartUI.gameObject.SetActive (true);
    Player_Move.playerSpeed = 10;
    Trail.gameObject.SetActive (false);
    hasFireball = false;
    //se eu quiser deletar o player:
    //GetComponent<Rigidbody>().isKinematic = true;
    //GetComponent<MeshRenderer>().enabled = false
    GetComponent<Player_Controls>().enabled = false;
    GetComponent<Player_Move>().enabled = false;
    magic.Stop();
}

}
