using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LevelLock : MonoBehaviour {

    
    public Button level1, level2;
    string username;
    private string[] Lines;
    private bool existe;
    private static string password = Login.gPassword;
    private static string email = Login.gEmail;
    private static string form;
    // Use this for initialization
    void Start () {
        level1.interactable = false;
        level2.interactable = false;
    }

    void Update()
    {
        if(PickingScript.unlockLevel1 == true)
        {
            level1.interactable = true;
        }
        if(PickingScript.unlockLevel2 == true)
        {
            level1.interactable = true;
            level2.interactable = true;
        }
        username = Login.gUsername;
        if (System.IO.File.Exists(@"C:/UnityTestFolder/" + username + ".txt"))
        {
            Lines = System.IO.File.ReadAllLines(@"C:/UnityTestFolder/" + username + ".txt");
            if (Lines[7] == "False")
            {
                level1.interactable = true;
            }
            else if(Lines[8] == "False")
            {
                level1.interactable = true;
                level2.interactable = true;
            }
        }
        if (BorrarPartida.lvLock == true)
        {
            level1.interactable = false;
            level2.interactable = false;
        }
    }

    // Update is called once per frame
    public void resetPlayerPrefs()
    {
        level1.interactable = false;
        level2.interactable = false;
        PickingScript.unlockLevel1 = false;
        PickingScript.unlockLevel2 = false;
        PickingScript.tutorial = false;
        PickingScript.level1 = false;
        PickingScript.level2 = false;

        if (System.IO.File.Exists(@"C:/UnityTestFolder/" + username + ".txt"))
        {
            form = (username + Environment.NewLine + email + Environment.NewLine + password + Environment.NewLine +
            0 + Environment.NewLine + 0 + Environment.NewLine + 0 + Environment.NewLine + false + Environment.NewLine + true 
            + Environment.NewLine + true);
            System.IO.File.WriteAllText(@"C:/UnityTestFolder/" + username + ".txt", form);
        }

        PlayerPrefs.DeleteAll();
    }
}
