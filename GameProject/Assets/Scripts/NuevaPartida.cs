using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NuevaPartida : MonoBehaviour {

    public Button nuevaPartida, cargarPartida;
    string username;
    private string[] Lines;
    private bool existe;
    private static string password = Login.gPassword;
    private static string email = Login.gEmail;
    private static string form;

    // Use this for initialization
    void Start () {
        username = Login.gUsername;
        if (System.IO.File.Exists(@"C:/UnityTestFolder/" + username + ".txt"))
        {
            Lines = System.IO.File.ReadAllLines(@"C:/UnityTestFolder/" + username + ".txt");
            if (Lines[6] == "True")
            {
                cargarPartida.interactable = false;
            }
            else
            {
                nuevaPartida.interactable = false;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void NuevaPartida1()
    {
        if(System.IO.File.Exists(@"C:/UnityTestFolder/" + username + ".txt"))
        {
            form = (username + Environment.NewLine + email + Environment.NewLine + password + Environment.NewLine +
            0 + Environment.NewLine + 0 + Environment.NewLine + 0 + Environment.NewLine + false + Environment.NewLine + true
            + Environment.NewLine + true);
            System.IO.File.WriteAllText(@"C:/UnityTestFolder/" + username + ".txt", form);
        }
    }
}
