using System;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float distance = 0.5f;
    Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if(!Physics.Raycast(transform.position, transform.right, distance, LayerMask.GetMask("Block"))){
                transform.position += transform.right * (movementSpeed * Time.deltaTime);
            }
            myAnimator.SetBool("isWalking", true);
            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if(!Physics.Raycast(transform.position, -transform.right, distance, LayerMask.GetMask("Block"))){
                transform.position += -transform.right * (movementSpeed * Time.deltaTime);
            }
            myAnimator.SetBool("isWalking", true);
        }
        else
        {
            myAnimator.SetBool("isWalking", false);
        }
        
    }
}
