using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickingScript : MonoBehaviour
{

    private float invulnerability = 6.0f;
    public static int tPuntuation = 100000;
    public static int puntuation1 = 100000;
    public static int puntuation2 = 100000;
    public static bool unlockLevel1 = false;
    public static bool unlockLevel2 = false;
    public static bool tutorial = false;
    public static bool level2 = false;
    public static bool level1 = false;

    void Update()
    {
        invulnerability += 0.15f;
    }
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUpHealth"))
        {
            HealthController.health += 1;
        }
        else if (collision.gameObject.CompareTag("PickUpDiamond"))
        {
            DController.diamond += 1;
        }
        else if (collision.gameObject.CompareTag("PickUpFinal"))
        {

            tPuntuation = tPuntuation - Tpuntuation.tPuntuation;

            Puntuation.WritePuntuation(tPuntuation, Register.puntuationn1, Register.puntuationn2);

            unlockLevel1 = true;

            if(Menu.Normal == true)
            {
                SceneManager.LoadScene(1);
            }
            else if(Menu.Facil == true)
            {
                SceneManager.LoadScene(9);
            }

            tutorial = true;
            level1 = false;
            level2 = false;

        }
        else if (collision.gameObject.CompareTag("PickUpFinal1"))
        {

            puntuation1 = puntuation1 - Puntuation1.puntuation1;

            Puntuation.WritePuntuation(Register.tPuntuationn, puntuation1, Register.puntuationn2);

            unlockLevel2 = true;

            if (Menu.Normal == true)
            {
                SceneManager.LoadScene(1);
            }
            else if (Menu.Facil == true)
            {
                SceneManager.LoadScene(9);
            }

            tutorial = false;
            level1 = true;
            level2 = false;
        }
        else if (collision.gameObject.CompareTag("PickUpFinal2"))
        {

            puntuation2 = puntuation2 - Puntuation2.puntuation2;

            Puntuation.WritePuntuation(Register.tPuntuationn, Register.puntuationn1, puntuation2);

            if (Menu.Normal == true)
            {
                SceneManager.LoadScene(1);
            }
            else if (Menu.Facil == true)
            {
                SceneManager.LoadScene(9);
            }

            tutorial = false;
            level1 = false;
            level2 = true;
        }
        else if (collision.gameObject.CompareTag("EnemyTouch") && invulnerability >= 6.0f)
        {
            HealthController.health -= 1;
            invulnerability = 0.0f;

        } else if (collision.gameObject.CompareTag("EnemyShootEnemy"))
        {
            HealthController.health -= 1;
        }
        
    }
}
