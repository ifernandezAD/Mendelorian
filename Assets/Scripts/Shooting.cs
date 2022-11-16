using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    [SerializeField] float speed=5f;

    
    void Update()
    {
     if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    
    private void Shoot()
    {
        GameObject cB =  Instantiate(bulletPrefab, bulletSpawn.position, bulletPrefab.transform.rotation);
        Rigidbody myRigid = cB.GetComponent<Rigidbody>();

        myRigid.AddForce(bulletSpawn.forward * speed, ForceMode.Impulse);
    }
}
