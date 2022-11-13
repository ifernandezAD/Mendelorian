using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    private NavMeshAgent enemyNav;
    public Transform target;

    
    void Start()
    {
        enemyNav = GetComponent<NavMeshAgent>();
        target = ReferenceSingleton.instance.player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemyNav.SetDestination(target.position);
    }
}
