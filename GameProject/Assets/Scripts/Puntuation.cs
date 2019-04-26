using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuation : MonoBehaviour {

    public static int TutoriaPEasy = Login.TPuntuationEasy;
    public static int Level1PEasy = Login.L1PuntuationEasy;
    public static int Level2PEasy = Login.L2PuntuationEasy;
    public static int TutoriaPNormal = Login.TPuntuationNormal;
    public static int Level1PNormal = Login.L1PuntuationNormal;
    public static int Level2PNormal = Login.L2PuntuationNormal;

    private string Username = Login.gUsername;
    private string Password = Login.gPassword;
    private string Email = Login.gEmail;
    private string form;

    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (System.IO.File.Exists(@"C:/UnityTestFolder/" + Username + ".txt"))
        {
            form = (Username + Environment.NewLine + Email + Environment.NewLine + Password + Environment.NewLine + 
            Puntuation.TutoriaPEasy + Environment.NewLine + Puntuation.Level1PEasy + Environment.NewLine + 
            Puntuation.Level2PEasy + Environment.NewLine + Puntuation.TutoriaPNormal + Environment.NewLine + 
            Puntuation.Level1PNormal + Environment.NewLine + Puntuation.Level2PNormal);
            System.IO.File.WriteAllText(@"C:/UnityTestFolder/" + Username + ".txt", form);
        }
    }
}
