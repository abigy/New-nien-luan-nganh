using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DameCollider : MonoBehaviour
{
    Collider damageCollider;
    PlayerState playerState;
    public int currentHitDamage = 25;
    private AudioSource hitAdudio;
    public AudioClip[] hitAudioClip;
    //public AudioClip hitAudioClip_2;
    private void Awake()
    {
        hitAdudio = GetComponent<AudioSource>();
        playerState = GameObject.Find("Player").GetComponent<PlayerState>();
        damageCollider = GetComponent<Collider>();
        damageCollider.gameObject.SetActive(true);
        damageCollider.isTrigger = true;
        damageCollider.enabled = false;
    }

    public void EnableDamageCollider()
    {
        damageCollider.enabled = true;
    }

    public void DisableDamageCollider()
    {
        damageCollider.enabled = false;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            PlayerState playerStates = collision.GetComponent<PlayerState>();

            if (playerStates != null)
            {
                playerStates.TakeDame(currentHitDamage);
            }
        }

        if(collision.tag == "Enemy")
        {
            EnemyState enemyState = collision.GetComponent<EnemyState>();

            if (enemyState != null)
            {
                hitAdudio.clip = hitAudioClip[Random.Range(0, hitAudioClip.Length)];
                hitAdudio.PlayOneShot(hitAdudio.clip, 1.0f);
                playerState.recoverMana(15);
                enemyState.TakeDame(currentHitDamage);
            }
        }
    }
}
