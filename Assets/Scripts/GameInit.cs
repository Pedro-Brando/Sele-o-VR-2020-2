using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    public static bool gameIsPlaying;
    void Start()
    {
        gameIsPlaying = true;
        DataManagement.datamanagement.currentScore = 0;
        DataManagement.datamanagement.LoadData();
        
    }
}
