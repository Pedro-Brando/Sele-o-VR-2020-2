using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{    
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
