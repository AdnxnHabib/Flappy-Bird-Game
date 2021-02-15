using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    //specify common data that is universal to the game

    public GameObject gameOverCanvas;
    public GameObject score;
    public GameObject getReadyImg;
    public GameObject pauseBtn;
    public Animator blackFadeAnim;

    public static Vector2 bottomLeft;
    //game states 

    public static bool gameOver;
    public static bool gameHasStarted;
    public static bool gameIsPaused;

    private void Awake()
    {
        //bottom left is the bottom left of the camera object
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameHasStarted = false;
        gameIsPaused = false;

    }

    public void GameHasStarted()
    {
        gameHasStarted = true;
        score.SetActive(true);
        getReadyImg.SetActive(false);
        pauseBtn.SetActive(true);
    }

   public void GameOver()
    {
        gameOver = true;
        score.SetActive(false); //remove the score
        gameOverCanvas.SetActive(true); //make the menu appear
        pauseBtn.SetActive(false);
       
    }

    public void OnOkBtnPressed()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }

    public void onMenuBtnPressed()
    {
        // SceneManager.LoadScene("Menu");
        blackFadeAnim.SetTrigger("FadeIn2");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
