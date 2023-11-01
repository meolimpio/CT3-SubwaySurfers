using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private CharacterController controller;

    public float speed;
    public float jumpHeight;
    private float jumpVelocity;
    public float gravity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.forward * speed;

        if(controller.isGrounded)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                jumpVelocity = jumpHeight;
            }
        }

        else
        {
            jumpHeight -= gravity;
        }

        direction.y = jumpVelocity;

        controller.Move(direction * Time.deltaTime);
    }
}
