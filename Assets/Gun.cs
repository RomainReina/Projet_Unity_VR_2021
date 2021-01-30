using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;

    // Update is called once per frame
    public void Fire()
    {
        GameObject fireBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        fireBullet.GetComponent<Rigidbody>().velocity = speed * barrel.foward;
        Destroy(fireBullet, 2);
    }
}
