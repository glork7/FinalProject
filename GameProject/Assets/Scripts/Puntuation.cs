using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puntuation : MonoBehaviour {


    private static string username = Login.gUsername;
    private static string password = Login.gPassword;
    private static string email = Login.gEmail;
    private static string form;
    private static string[] Lines;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
       
        
        
    }

    public static void WritePuntuation(int tPuntuation, int puntuation1, int puntuation2)
    {
        if(tPuntuation < 0)
        {
            tPuntuation = 0;
        }
        if (puntuation1 < 0)
        {
            puntuation1 = 0;
        }
        if (puntuation2 < 0)
        {
            puntuation2 = 0;
        }
        if (System.IO.File.Exists(@"C:/UnityTestFolder/" + username + ".txt"))
        {
            Lines = System.IO.File.ReadAllLines(@"C:/UnityTestFolder/" + username + ".txt");
            form = (username + Environment.NewLine + email + Environment.NewLine + password + Environment.NewLine +
            PickingScript.tPuntuation + Environment.NewLine + PickingScript.puntuation1 + Environment.NewLine + PickingScript.puntuation2 
            + Environment.NewLine + false + Environment.NewLine + Lines[7] + Environment.NewLine + Lines[8]);
            System.IO.File.WriteAllText(@"C:/UnityTestFolder/" + username + ".txt", form);
            }
    }
}
