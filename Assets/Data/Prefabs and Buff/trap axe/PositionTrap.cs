using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTrap : MonoBehaviour
{

    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerState playerState = collision.gameObject.GetComponent<PlayerState>();
            // enemyState.TakeDame(25);
            playerState.TakeDame(25);
            Debug.Log("Chet me may chua ?");
        }else if(collision.gameObject.tag == "Enemy")
        {
            EnemyState enemyState = collision.gameObject.GetComponent<EnemyState>();
            enemyState.TakeDame(25);
            Debug.Log("Enemy lord");
        }
    }
}
