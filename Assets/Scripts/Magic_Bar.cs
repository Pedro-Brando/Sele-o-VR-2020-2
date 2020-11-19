using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magic_Bar : MonoBehaviour
{
    //Barra de mana do Player
    void Update()
    {
        adjustMagicBar();
        
    }

void adjustMagicBar(){

    if (Player_Controls.magicFuel >0.001) {
        gameObject.transform.localScale = new Vector3 (Player_Controls.magicFuel, 1, 1);
    }

}

}
