using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float distance = 0.5f;


    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if(!Physics.Raycast(transform.position, transform.right, distance, LayerMask.GetMask("Block"))){
                transform.position += transform.right * (movementSpeed * Time.deltaTime);
            }
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            if(!Physics.Raycast(transform.position, -transform.right, distance, LayerMask.GetMask("Block"))){
                transform.position += -transform.right * (movementSpeed * Time.deltaTime);
            }
        }
        
    }
}
