using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float sensetivity = 10f;
    public Transform playerBody;
    float xrotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
     
        float x = sensetivity * Input.GetAxis("Mouse X") * Time.deltaTime;
        float y = sensetivity * Input.GetAxis("Mouse Y") * Time.deltaTime;

        playerBody.Rotate(Vector3.up * x);

        xrotation -= y;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
    }
}
