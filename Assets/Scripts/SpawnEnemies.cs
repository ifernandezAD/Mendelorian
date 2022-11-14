using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject peaEnemy;
    public Transform peaEnemySpawn;
    [SerializeField] private float timer;
    [SerializeField] private float maxTime;

    private void Update()
    {

        timer += Time.deltaTime;

        if (timer >= maxTime)
        {
            SpawnPeaEnemy();
            timer = 0;
            --maxTime;
        }
        if(maxTime==0)
        {
            maxTime = 1;
        }
      
    }


    public void SpawnPeaEnemy()
    {
        Instantiate(peaEnemy, peaEnemySpawn.position, peaEnemy.transform.rotation);
    }


}
