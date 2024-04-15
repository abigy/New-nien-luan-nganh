using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashDame : MonoBehaviour
{
    //private bool collided;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Enemy" || collision.gameObject.tag != "Player")
        {
            //EnemyState enemyState = collision.gameObject.GetComponent<EnemyState>();
            //enemyState.TakeDame(25);
            //collided = true;
            Debug.Log("Dash dame");
        }
    }
}
