using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    //check if game is paused 

    Image img;

    //references 

    public Sprite playSprite;
    public Sprite pausedSprite;

    private void Start()
    {
        img = GetComponent<Image>();
    }

    public void OnPausedGame()
    {
        if(GameManager.gameIsPaused == false)
        {
            Time.timeScale = 0;
            img.sprite = playSprite; //change sprite if game is paused
            GameManager.gameIsPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            img.sprite = pausedSprite;
            GameManager.gameIsPaused = false;
        }
    }

}
