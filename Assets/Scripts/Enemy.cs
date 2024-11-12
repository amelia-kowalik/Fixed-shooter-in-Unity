using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject); //zniszcz pocisk/gracza
            Destroy(this.gameObject); //zniszcz enemy 
            ScoreManager.instance.UpdateScore();
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}

