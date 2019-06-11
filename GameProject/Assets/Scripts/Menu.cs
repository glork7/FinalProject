using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public static bool Facil = false;
    public static bool Normal = true;
    private bool pauseEnabled = false;

    // Update is called once per frame
    /*void Update () {
		
	}*/

    public void SendToMenu()
    {
        SceneManager.LoadScene(4);
    }

    public void SendToCargarPartida () {
        SceneManager.LoadScene(1);
    }

    public void SendToOptionMenu() {
        SceneManager.LoadScene(2);
    }
    
    public void SendToCrearPartida() { 
        SceneManager.LoadScene(3);
    }

    public void SendToLogin()
    {
        SceneManager.LoadScene(0);
    }

    public void SendToNivel1()
    {
        SceneManager.LoadScene(5);
    }

    public void SendToTutorial()
    {
        SceneManager.LoadScene(6);
    }

    public void SendToNivel2()
    {
        SceneManager.LoadScene(7);
    }

    public void SelectDificult()
    {
        SceneManager.LoadScene(8);
    }

    public void Easy()
    {
        SceneManager.LoadScene(9);
    }

    public void Ranking()
    {
        SceneManager.LoadScene(10);
    }
    public void DificultadFacil()
    {
        Facil = true;
        Normal = false;
    }
    public void DificultadNormal()
    {
        Normal = true;
        Facil = false;
    }
    public void Pause()
    {   
            if (pauseEnabled == false)
            {
                Time.timeScale = 0;
            }

        pauseEnabled = true;
    }
    public void UnPause()
    {
        if (pauseEnabled == true)
        {
            Time.timeScale = 1;
        }

        pauseEnabled = false;
    }

}

