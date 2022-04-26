using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public InputHandler inputHandler;
    public GameObject Menu;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.GetInstance().OnGameOverAction += gameOver;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Menu.SetActive(false);
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        GameManager.GetInstance().pauseGame();
    }

    public void Retry(string nama)
    {

        gameOverMenu.SetActive(false);
        Menu.SetActive(true);
        GameManager.GetInstance().retry();
    }

    public void Resumegame()
    {
        pauseMenu.SetActive(false);
        GameManager.GetInstance().resumeGame();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void gameOver()
    {
        gameOverMenu.SetActive(true);
    }

    private void OnEnable()
    {
        inputHandler.OnPauseAction += PauseGame;
    }

    private void OnDisable()
    {
        inputHandler.OnPauseAction -= PauseGame;
    }
}
