using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackFade : MonoBehaviour
{
    // Start is called before the first frame update
  
    void OnBlackFadeFinished()
    {
        if(SceneManager.GetActiveScene().name == "Menu")
        {
            SceneManager.LoadScene("GameScene");

        }
        else if(SceneManager.GetActiveScene().name == "GameScene")
        {
            SceneManager.LoadScene("Menu");


        }
    }

}
