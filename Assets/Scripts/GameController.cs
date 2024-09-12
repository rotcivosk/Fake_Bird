

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public TMP_Text playerOneScore;

    public int playerOneScoreCounter = 0;
    public int maxScore;
    public GameObject victoryScreen;
    public TMP_Text victoryText;
    public GameObject startScreen;
    private bool startScreenOnline = true;
    void Start(){
        Time.timeScale = 0;

    } 


    void Update(){
        if (startScreenOnline==true){
            if (Input.GetKey(KeyCode.Space)){
             StartGame();
            }
        }

    }

    public void StartGame()
    {
        Time.timeScale = 1; 
        startScreen.SetActive(false);  
        startScreenOnline = false; 
    }
    public void LoseGame(){
            Time.timeScale = 0;
            victoryText.text = "GAME OVER";
            victoryScreen.SetActive(true);
    }

    public void AddPlayerPoint(){
            playerOneScoreCounter++;
            playerOneScore.text = playerOneScoreCounter.ToString();
    }


    public void ReloadScene(){
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
        startScreenOnline = false;

    }
   

}


