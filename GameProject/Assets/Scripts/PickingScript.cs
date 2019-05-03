using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickingScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUpHealth"))
        {
            HealthController.health += 1;
        }
        else if(collision.gameObject.CompareTag("PickUpDiamond"))
        {
            DController.diamond += 1;
        }
        else if (collision.gameObject.CompareTag("PickUpFinal"))
        {
            SceneManager.LoadScene(1);
        }
        else if (collision.gameObject.CompareTag("PickUpSecret"))
        {
            SceneManager.LoadScene(11);
        }
        else if (collision.gameObject.CompareTag("EnemyTouch"))
        {
            HealthController.health -= 1;
        }
        else
        {
            HealthController.health -= 1;
        }
        
    }
}
