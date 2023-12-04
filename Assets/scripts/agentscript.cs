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
    public int maxHealth = 100;
    private int currentHealth;
    private bool isAlive = true;

    public gamecontroller gameController;
    public SimpleShoot simpleshoot;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentHealth = maxHealth;


    }

    // Update is called once per frame
    void Update()
    {

        agent.destination = goal.position;

        if (isDead == false)
        {
            animator.SetFloat("Speed_f", agent.velocity.magnitude);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            
            gameController.AddScore(10);

            currentHealth -= 50;
            




           
        }
        if (currentHealth <= 0)
        {
            isDead = true;

        }
        if (isDead == true)
        {
            animator.SetInteger("DeathType_int", 1);
            animator.SetBool("Death_b", true);
            agent.speed = 0;
            Destroy(other);
            
            agent.speed = 0;
        }
        
    }

    



}
