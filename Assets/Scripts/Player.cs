using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManagerS gameManager;
    Animator myAnimator;
    
    void Start(){
        myAnimator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy")){
         gameManager.GameOver(); 
         myAnimator.SetBool("isDead", true);
         Destroy(this.gameObject,myAnimator.GetCurrentAnimatorStateInfo(0).length);
        }
    }
}
