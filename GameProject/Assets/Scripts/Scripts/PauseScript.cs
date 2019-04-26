using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public UnityEngine.UI.Button pauseButton, resumeButton, restartButton, mainButton, quitButton, restartGOButton, mainGOButton, quitGOButton;
    public GameObject PauseMenu, pButton, lifeCounter;

    void Start()
    {
        //PauseMenu.gameObject.SetActive(false);
        resumeButton.onClick.AddListener(ResumeOnClick);
        pauseButton.onClick.AddListener(PauseOnClick);
        //restartButton.onClick.AddListener(RestartOnClick);
        //mainButton.onClick.AddListener(MainOnClick);
        quitButton.onClick.AddListener(QuitOnClick);

        //restartGOButton.onClick.AddListener(RestartGameOverOnClick);
        //mainGOButton.onClick.AddListener(MainGameOverOnClick);
        //quitGOButton.onClick.AddListener(QuitGameOverOnClick);

        pButton.gameObject.SetActive(true);

    }

    void PauseOnClick()
    {
        pButton.gameObject.SetActive(false);
        lifeCounter.gameObject.SetActive(false);
        PauseMenu.gameObject.SetActive(true);
    }

    void ResumeOnClick()
    {
        pButton.gameObject.SetActive(true);
        lifeCounter.gameObject.SetActive(true);
        PauseMenu.gameObject.SetActive(false);
    }

    void RestartOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Reiniciando del juego...");
    }

    void MainOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Saliendo del juego...");
    }

    void OptionsOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Saliendo del juego...");
    }

    void QuitOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Saliendo del juego...");
    }

}
