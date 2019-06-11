using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BorrarPartida : MonoBehaviour {


    public Button nuevaPartida, cargarPartida;
    private string username;
    private string[] Lines;
    private bool existe = true;
    public static bool deleteRanking = false;
    private static string password = Login.gPassword;
    private static string email = Login.gEmail;
    private static string form;
    public static bool lvLock = false;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BorrarPartida1()
    {
        username = Login.gUsername;
        lvLock = true;
        if (System.IO.File.Exists(@"C:/UnityTestFolder/" + username + ".txt"))
        {
            form = (username + Environment.NewLine + email + Environment.NewLine + password + Environment.NewLine +
            0 + Environment.NewLine + 0 + Environment.NewLine + 0 + Environment.NewLine + existe + Environment.NewLine + true
            + Environment.NewLine + true);
            System.IO.File.WriteAllText(@"C:/UnityTestFolder/" + username + ".txt", form);
        }
        deleteRanking = true;
    }
}
