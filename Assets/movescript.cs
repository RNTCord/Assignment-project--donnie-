using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class movescript : MonoBehaviour
{
    public Animator animator;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per framellll
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = (transform.right * x + transform.forward * z) * speed * Time.deltaTime;
        transform.position += move;

        animator.SetFloat("Speed_f", move.magnitude * 5);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetInteger("WeaponType_int", 1);
            animator.SetBool("Shoot_b", true);

        }else if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            animator.SetInteger("WeaponType_int", 0);
            animator.SetBool("Shoot_b", false);
        }
        
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetInteger("Animation_int", 3);
            animator.SetBool("Crouch_b", true) ;
        }else if (Input.GetKeyUp(KeyCode.C))
        {

            animator.SetInteger("Animation_int", 0);
            animator.SetBool("Crouch_b", false) ;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetInteger("Animation_int", 2);
            animator.SetBool("Jump_b", true );
        }else if(Input.GetKeyUp (KeyCode.Space))
        {
            animator.SetInteger("Animator_int", 0);
            animator.SetBool("Jump_b", false ) ;
        }




    }
}
