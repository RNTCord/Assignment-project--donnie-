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
        //if (other.tag == "bullet")
        {
            
            gameController.AddScore(10);

            //animator.SetInteger("DeathType_int", 1);
            //animator.SetBool("Death_b", true);
           // isDead = true;
            //agent.speed = 0;



        }
    }
    public void TakeDamage()
    {
        // Implement damage logic here
        currentHealth -= 10; // Example: reduce health by 10

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        // Implement any death effects or logic here
        Destroy(gameObject);
    }
    public bool IsAlive()
    {
        return isAlive;
    }
}
