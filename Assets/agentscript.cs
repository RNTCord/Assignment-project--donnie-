using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms.Impl;

public class agentscript : MonoBehaviour
{
    NavMeshAgent agent;
    public Animator animator;
    public Transform goal;
    bool isDead = false;

    public gamecontroller gameController;
    

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
       

        
    }

    // Update is called once per frame
    void Update()
    {
        
        agent.destination = goal.position;

        if(isDead == false)
        {
            animator.SetFloat("Speed_f", agent.velocity.magnitude);
        }
        if(isDead == true)
        {
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "bullet")
        {

            gameController.AddScore(10);

            animator.SetInteger("DeathType_int", 1);
            animator.SetBool("Death_b", true);
            isDead = true;
            agent.speed = 0;

           
            
        }
    }
}
