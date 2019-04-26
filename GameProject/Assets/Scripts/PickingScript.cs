using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        else
        {
            HealthController.health -= 1;
        }
        
    }
}
