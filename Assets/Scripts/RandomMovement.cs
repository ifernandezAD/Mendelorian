using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMovement : MonoBehaviour
{
    public float timer;
    public int randomTime;
    public float speed;
    public NavMeshAgent myAgent;
    public Vector3 Target;

    private void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= randomTime)
        {
            newTarget();
            timer = 0;
        }
    }

    private void newTarget()
    {
        float xPos = Random.Range(-30f, 30f);
        float zPos = Random.Range(-18f,18f);

        Target = new Vector3(xPos, gameObject.transform.position.y, zPos);

        myAgent.SetDestination(Target);
    }
}
