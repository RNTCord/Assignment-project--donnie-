using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider healthbarSlider;
    public float maxhealth = 100f;
    public float health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(healthbarSlider.value != health)
        {
            healthbarSlider.value = health;
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            health -= 10;
        }
    }   
}
