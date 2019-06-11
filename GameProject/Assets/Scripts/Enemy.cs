
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    private int healt = 300;

    public GameObject deathEffect;
    public GameObject impactEffect;
    public GameObject shoot;
    public GameObject item;
    public GameObject test;
    private int sceneNumber;

    public GameObject prefab;
    
    void Start()
    {
        if (Menu.Facil == true)
        {
            healt = 200;
        }
        else if (Menu.Normal == true)
        {
            healt = 300;
        }
    }
    

    public void TakeDamage(int damage)
    {
        

        healt -= damage;

        if (healt <= 0)
        {
            if (Menu.Facil == true)
            {
                if(PickingScript.tutorial == true)
                {
                    PickingScript.tPuntuation = PickingScript.tPuntuation + 10000;
                }
                if(PickingScript.level1 == true)
                {
                    PickingScript.puntuation1 = PickingScript.puntuation1 + 10000;
                }
                if (PickingScript.level1 == true)
                {
                    PickingScript.puntuation2 = PickingScript.puntuation2 + 10000;
                }
            }
            else if (Menu.Normal == true)
            {
                if (PickingScript.tutorial == true)
                {
                    PickingScript.tPuntuation = PickingScript.tPuntuation + 25000;
                }
                if (PickingScript.level1 == true)
                {
                    PickingScript.puntuation1 = PickingScript.puntuation1 + 25000;
                }
                if (PickingScript.level2 == true)
                {
                    PickingScript.puntuation2 = PickingScript.puntuation2 + 25000;
                }
            }
            Die();
        }
    }

    // Update is called once per frame
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);

        if (Random.Range(0, 100) <= 32)
        {
            Object.Instantiate(item, transform.position, Quaternion.identity);
        }
        
    }




}
