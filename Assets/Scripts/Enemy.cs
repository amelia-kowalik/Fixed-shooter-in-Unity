using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other){
        Destroy(other.gameObject); //zniszcz pocisk
        Destroy(this.gameObject); //zniszcz enemy 
        ScoreManager.instance.UpdateScore();
    }
}
