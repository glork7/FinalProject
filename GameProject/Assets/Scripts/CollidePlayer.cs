using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePlayer : MonoBehaviour {

    public int damage = 40;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

    }

}
