using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour
{
    // Start is called before the first frame update\
    public float animationSmooth = 0.1f;
    NavMeshAgent agent;
    Animator animator;
    public bool isDead = false;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float speedPercent = agent.velocity.magnitude / agent.speed;
        animator.SetFloat("speedPercent", speedPercent , animationSmooth, Time.deltaTime);
        if (isDead == true)
        {
            animator.SetBool("isDead", true);//this will lauch the animation for dying.
        }

    }
}