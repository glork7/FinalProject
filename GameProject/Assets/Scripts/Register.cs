using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using System;

public class Register : MonoBehaviour
{
    public GameObject username;
    public GameObject email;
    public GameObject password;
    public GameObject confirmPassword;
    public static int tPuntuationn;
    public static int puntuationn1;
    public static int puntuationn2;
    private string Username;
    private string Email;
    private string Password;
    private string ConfirmPassword;
    private string form;
    public Text uR, e, pR, cPR;
    private bool EmailValid = false;
    public bool nuevaPartida = true;
    public bool level1lock = true;
    public bool level2lock = true;
    private string[] Characters = {"a","b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                   "u","v", "w", "x", "y", "z","A","B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
                                   "P", "Q", "R", "S", "T", "U","V", "W", "X", "Y", "Z",
                                   "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "_", "-"};

    // Use this for initialization
    void Start(){

    }

    public void RegisterButton(){
        bool UN = false;
        bool EM = false;
        bool PW = false;
        bool CPW = false;
        if (!System.IO.Directory.Exists(@"C:/UnityTestFolder/"))
        {
            System.IO.Directory.CreateDirectory(@"C:/UnityTestFolder/");
        }
            if (Username != "")
            {
                if (!System.IO.File.Exists(@"C:/UnityTestFolder/" + Username + ".txt"))
                {
                    UN = true;
                    uR.text = "";
                }
                else
                {
                    uR.text = "Username Taken";
                    Debug.LogWarning("Username Taken.");
                }
            }
            else
            {
                uR.text = "Username field Empty";
                Debug.LogWarning("Username field Empty.");
            }
            if (Email != "")
            {
                EmailValidation();
                if (EmailValid)
                {
                    if (Email.Contains("@"))
                    {
                        if (Email.Contains("."))
                        {
                            EM = true;
                            e.text = "";
                        }
                        else
                        {
                            e.text = "Email is Incorrect";
                            Debug.LogWarning("Email is Incorrect.");
                        }
                    }
                    else
                    {
                        e.text = "Email is Incorrect";
                        Debug.LogWarning("Email is Incorrect.");
                    }
                }
                else
                {
                    e.text = "Email is Incorrect";
                    Debug.LogWarning("Email is Incorrect.");
                }
            }
            else
            {
                e.text = "Email Field Empty";
                Debug.LogWarning("Email Field Empty.");
            }
            if (Password != "")
            {
                if (Password.Length > 5)
                {
                    PW = true;
                    pR.text = "";
                }
                else
                {
                    pR.text = "Password must be atleast 6 characters long";
                    Debug.LogWarning("Password must be atleast 6 characters long.");
                }

            }
            else
            {
                pR.text = "Password Field is Empty";
                Debug.LogWarning("Password Field is Empty.");
            }
            if (ConfirmPassword != "")
            {
                if (ConfirmPassword == Password)
                {
                    cPR.text = "";
                    CPW = true;
                }
                else
                {
                    cPR.text = "Password don't match";
                    Debug.LogWarning("Password don't match.");
                }
            }
            else
            {
                cPR.text = "Confirmation password field is Empty";
                Debug.LogWarning("Confirmation password field is Empty.");
            }
            if (UN == true && EM == true && PW == true && CPW == true)
            {
                bool Clear = true;
                int i = 1;
                foreach (char c in Password)
                {
                    if (Clear)
                    {
                        Password = "";
                        Clear = false;
                    }
                    i++;
                    char Encrypted = (char)(c * 1);
                    Password += Encrypted.ToString();
                }
            }
        
            //Password Encryptment



            byte[] data = System.Text.Encoding.ASCII.GetBytes(Password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);

            tPuntuationn = Tpuntuation.tPuntuation;
            puntuationn1 = Puntuation1.puntuation1;
            puntuationn2 = Puntuation2.puntuation2;

            form = (Username + Environment.NewLine + Email + Environment.NewLine + hash + Environment.NewLine +
            tPuntuationn + Environment.NewLine + puntuationn1 + Environment.NewLine + puntuationn2 + Environment.NewLine + nuevaPartida
            + Environment.NewLine + level1lock + Environment.NewLine + level2lock);

            System.IO.File.WriteAllText(@"C:/UnityTestFolder/" + Username + ".txt", form);
            username.GetComponent<InputField>().text = "";
            email.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            confirmPassword.GetComponent<InputField>().text = "";
            print("Registration Complete");
        }
        
    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Tab)){
            if (username.GetComponent<InputField>().isFocused){
                email.GetComponent<InputField>().Select();
            }
            if (email.GetComponent<InputField>().isFocused){
                password.GetComponent<InputField>().Select();
            }
            if (password.GetComponent<InputField>().isFocused){
                confirmPassword.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return)){
            if (Username != "" && Email != "" && Password != "" && ConfirmPassword != ""){
                RegisterButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfirmPassword = confirmPassword.GetComponent<InputField>().text;
    }
    void EmailValidation() {
        bool SW = false;
        bool EW = false;
        for (int i = 0;  i< Characters.Length; i++) {
            if (Email.StartsWith(Characters[i])) {
                SW = true;  
            }
        }
        for (int i = 0; i < Characters.Length; i++)
        {
            if (Email.EndsWith(Characters[i])) {
                EW = true;
            }
        }

        if(SW == true && EW == true) {
            EmailValid = true;
        } else {
            EmailValid = false;
        }
    }
}

