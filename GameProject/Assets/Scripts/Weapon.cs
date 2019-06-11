
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform Bullet;
    public GameObject DefaultBulletPrefab;
    public GameObject FireBulletPrefab;
    public GameObject FireGreenBulletPrefab;
    private float defaultFireRate = 0.3f;
    private float fireRate = 0.5f;
    private float greenFireRate = 0.7f;
    private float nextFire;
    private int defaultMana = 100;
    private int mana = 100;
    private bool fireShoot = false;
    private bool greenFireShoot = false;
    private bool defaultShoot = true;
    private int fireShootMana = 15;
    private int greenFireShootMana = 25;
    private int defaultShootMana = 10;
    // Update is called once per frame
    
    void Update () {
        if (Menu.Facil == true)
        {
            fireShootMana = 0;
            greenFireShootMana = 0;
            defaultShootMana = 0;

        }else if(Menu.Normal == true)
        {
            fireShootMana = 15;
            greenFireShootMana = 25;
            defaultShootMana = 10;
        }

        if (mana > defaultMana)
        {
            mana = defaultMana;
        }
        if (Input.GetButtonDown("SetBullet3"))
        {
            defaultShoot = false;
            fireShoot = false;
            greenFireShoot = true;
        }
        else if (Input.GetButtonDown("SetBullet2"))
        {
            fireShoot = true;
            greenFireShoot = false;
            defaultShoot = false;
        }
        else if (Input.GetButtonDown("SetBullet1"))
        {
            defaultShoot = true;
            fireShoot = false;
            greenFireShoot = false;
        }
            if (Input.GetButtonDown("Bullet1") && Time.time > nextFire) {
            if (defaultShoot == true)
            {
                mana = mana + defaultShootMana;
                if (Menu.Facil == true)
                {
                    nextFire = Time.time + defaultFireRate - 0.15f;
                }
                else if (Menu.Normal == true)
                {
                    nextFire = Time.time + defaultFireRate;
                }
                
                Shoot1();
                
            }
            else if (fireShoot == true && mana >= fireShootMana)
            {
                mana = mana - fireShootMana;
                if (Menu.Facil == true)
                {
                    nextFire = Time.time + fireRate - 0.15f;
                }
                else if (Menu.Normal == true)
                {
                    nextFire = Time.time + fireRate;
                }
                Shoot2();                
            }
            else if(greenFireShoot == true && mana >= greenFireShootMana)
            {
                mana = mana - greenFireShootMana;
                if (Menu.Facil == true)
                {
                    nextFire = Time.time + greenFireRate - 0.15f;
                }
                else if (Menu.Normal == true)
                {
                    nextFire = Time.time + greenFireRate;
                }
                Shoot3();                
            }
        }

    }
    void Shoot1()
    {
        Instantiate(DefaultBulletPrefab, Bullet.position, Bullet.rotation);
    }
    void Shoot2()
    {
        Instantiate(FireBulletPrefab, Bullet.position, Bullet.rotation);
    }
    void Shoot3()
    {
        Instantiate(FireGreenBulletPrefab, Bullet.position, Bullet.rotation);
    }
}