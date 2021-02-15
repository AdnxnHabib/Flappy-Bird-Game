using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour

{
    //reference to animator object
    public Animator blackFadeAnim;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.gameOver = false;
    }

    // Update is called once per frame

    public void OnPlayBtnPressed()
    {
        //call the trigger of the black fade animator 

        blackFadeAnim.SetTrigger("FadeIn2");
        //SceneManager.LoadScene("GameScene");
    }
}
