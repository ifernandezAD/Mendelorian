using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemies : MonoBehaviour
{
    public GameObject peaEnemy;
    public Transform peaEnemySpawn;

    public void SpawnPeaEnemy()
    {
        Instantiate(peaEnemy, peaEnemySpawn.position, peaEnemy.transform.rotation);
    }
}
