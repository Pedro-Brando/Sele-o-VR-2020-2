using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadToScene (string sceneToLoad) {
        Initiate.Fade(sceneToLoad, Color.white, 1.0f);
        //SceneManager.LoadScene (sceneToLoad);
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log ("Quit Game!");
    }

    public void OpenTutorial(GameObject tutorialMenu){
        tutorialMenu.gameObject.SetActive (true);
    }
    public void CloseTutorial(GameObject tutorialMenu){
        tutorialMenu.gameObject.SetActive (false);
    }
 
 
}
