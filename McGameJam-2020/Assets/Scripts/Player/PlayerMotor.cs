using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour
{

    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();//getting the agent from this
    }

    // Update is called once per frame
    public void MoveToPoint( Vector3 point)
    {
        agent.SetDestination(point);
    }
}
