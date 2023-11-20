using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agentscript : MonoBehaviour
{
    public NavMeshAgent navmeshagent;
    public Animator animator;
    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        animator.SetFloat("Speed_f", agent.velocity.magnitude);





        
    }
}
