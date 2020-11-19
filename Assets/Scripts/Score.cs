using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{    
    //Código para display do score, se o score atual for maior que o high score, o score atualiza
    public GameObject scoreUI;
    public GameObject highScoreUI;
    
    void Update()
    {

        if (DataManagement.datamanagement.currentScore > DataManagement.datamanagement.highScore){
            DataManagement.datamanagement.highScore = DataManagement.datamanagement.currentScore;
        }
        scoreUI.GetComponent<Text>().text = ("" + DataManagement.datamanagement.currentScore.ToString());        
        highScoreUI.GetComponent<Text>().text = ("High Score: " + DataManagement.datamanagement.highScore.ToString());

    }
}
