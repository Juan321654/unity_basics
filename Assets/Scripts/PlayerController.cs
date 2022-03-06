using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // all these can be set to public to be shown in the Unity inspector to see how it works
    private float speed = 10.0f;
    private float turnSpeed = 30f;
    private float horizontalInput;
    private float fowardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Gets the user input
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        // move the vehicle forward
        // transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        // rotates the vehicel on user input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
