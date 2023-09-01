using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody myrigidbody;
    public float XSpeed, ZSpeed,maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal") * ZSpeed, 0.0f,Input.GetAxis("Vertical") * XSpeed), ForceMode.Impulse);
        if (myrigidbody.velocity.magnitude > maxSpeed)
        {
            myrigidbody.velocity = myrigidbody.velocity.normalized * maxSpeed;
        }
    }
}
