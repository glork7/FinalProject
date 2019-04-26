using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuation : MonoBehaviour {

    public static int TutoriaP = Login.TPuntuation;
    public static int Level1P = Login.L1Puntuation;
    public static int Level2P = Login.L2Puntuation;

    private string Username = Login.gUsername;
    private string Password = Register.gPassword;
    private string Email = Register.gEmail;
    private string form;

    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (System.IO.File.Exists(@"C:/UnityTestFolder/" + Username + ".txt"))
        {
            form = (Username + Environment.NewLine + Email + Environment.NewLine + Password + Environment.NewLine + Puntuation.TutoriaP + Environment.NewLine + Puntuation.Level1P
            + Environment.NewLine + Puntuation.Level2P);
            System.IO.File.WriteAllText(@"C:/UnityTestFolder/" + Username + ".txt", form);
        }
    }
}
