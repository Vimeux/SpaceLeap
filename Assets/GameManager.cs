using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public Text gameOverCountdown;
    public float countTimer = 5;

    public AudioSource backgroundSound;
    public AudioSource startSoundPesquet;
    public AudioSource restartPesquet;


    void Start()
    {
        backgroundSound.Stop();
        startSoundPesquet.Stop();
        restartPesquet.Stop();

        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
    private void Update()
    {
        if (Player.isDead)
        {
            gameOverCountdown.gameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
            gameOverCountdown.text = "Restarting in " + (countTimer).ToString("0");
            if (countTimer < 0)
            {
                restartPesquet.Play();
                Player.isDead = false;
                Baguette.nombreDeBaguette = 0;
                RestartGame();
                gameOverCountdown.gameObject.SetActive(false);
            }
        }
    }


    public void StartGame()
    {
        backgroundSound.Play();
        startSoundPesquet.Play();
        startButton.SetActive(false);
        Time.timeScale = 1;

    }
    public static void GameOver()
    {
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        backgroundSound.Stop();
        startSoundPesquet.Stop();
        
    }
}