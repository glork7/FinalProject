using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public Transform Bullet;
    public GameObject DefaultBulletPrefab;
    public float defaultFireRate;
    private float nextFire;
    public bool defaultShoot = true;
    // Update is called once per frame

    void Update()
    {
        if(defaultShoot == true && Time.time > nextFire)
        {
            nextFire = Time.time + defaultFireRate;
            Shoot1();
        }

    }
    void Shoot1()
    {
        Instantiate(DefaultBulletPrefab, Bullet.position, Bullet.rotation);
    }
}
