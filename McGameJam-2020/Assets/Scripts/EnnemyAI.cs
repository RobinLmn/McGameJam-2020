using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnnemyAI : MonoBehaviour
{
    public Transform player;
    public int radius = 1;

    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position;

        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= radius)
        {
            // Kill Player
            PlayerManager.instance.Die();
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }


}
