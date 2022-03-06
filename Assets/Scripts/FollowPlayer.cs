using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // GameObject is a class, it would be like creating a new variable INT number1, or, STRING player
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // transform is for the current object (camera) and offset the camera 
        // so its not in the exact same position as the car
        transform.position = player.transform.position + offset;
    }
}
