using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public Text gameOverCountdown;
    public float countTimer = 5;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Stop();
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
                Player.isDead = false;
                Baguette.nombreDeBaguette = 0;
                RestartGame();
                gameOverCountdown.gameObject.SetActive(false);
            }
        }
    }
    public void StartGame()
    {
        audioSource.Play();
        startButton.SetActive(false);
        Time.timeScale = 1;

    }
    public static void GameOver()
    {
        Time.timeScale = 0;
    }
    public void RestartGame()
    {
        EditorSceneManager.LoadScene(0);
        audioSource.Stop();
    }
}