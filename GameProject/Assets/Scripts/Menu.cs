using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    //public Button MyButton = null;
    // Use this for initialization
    /*void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/

    public void SendToCargarPartida () {
        SceneManager.LoadScene(1);
    }
    public void SendToOptionMenu() {
        SceneManager.LoadScene(2);
    }

    public void SendToNuevaPartida() {
        SceneManager.LoadScene(3);
    }

    public void SendToMenu() {
        SceneManager.LoadScene(0);
    }

    public void SendToPartida() {
        SceneManager.LoadScene(4);
    }

    public void SendToCrearPartida() { 
        SceneManager.LoadScene(5);
    }
    public void Partida2()
    {
        SceneManager.LoadScene(7);
    }
    public void login()
    {
        SceneManager.LoadScene(6);
    }
}

