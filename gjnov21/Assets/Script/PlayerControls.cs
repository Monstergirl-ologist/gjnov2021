using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float movSpeed;
    public float movUp;
    public float movVelocity;

    public bool grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)
            {
                GetComponent<Rigidbody>().velocity = new Vector2(GetComponent<Rigidbody>().velocity.x, movUp);
            }
        }

        movVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            movVelocity = -movSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            movVelocity = movSpeed;
        }

        GetComponent<Rigidbody>().velocity = new Vector2(movVelocity, GetComponent<Rigidbody>().velocity.y);

    }
    //Check if Grounded
    void OnTriggerEnter()
    {
        grounded = true;
    }
    void OnTriggerExit()
    {
        grounded = false;
    }

}
