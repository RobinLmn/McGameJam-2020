using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnnemyAI : MonoBehaviour
{
    public Transform player;
    public int radius = 1;
    public int lookRadius = 4;
    public bool hasTargeted = false;

    public NavMeshAgent agent;

    private void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= lookRadius)
        {
            hasTargeted = true;
        }

        if (hasTargeted)
        {

            agent.SetDestination(player.position);
            Debug.Log(agent.path.status);

            if (distance <= radius)
            {
               // agent.isStopped = true;
                // Kill Player
                PlayerManager.instance.Die();
                hasTargeted = false;
            }

        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

    }




}
