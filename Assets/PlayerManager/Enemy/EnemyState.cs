using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    public int healthLevel = 10;
    public int maxHealth;
    public int currentHealth;
    public HealBarEnemy healthBarEnemy;
    public AudioClip dameSound;
    private AudioSource takeDameAudio;

    Collider enemyCollider;

    Animator animator;

    private void Awake()
    {
        takeDameAudio = GetComponent<AudioSource>();
        animator = GetComponentInChildren<Animator>();
    }
    void Start()
    {
        enemyCollider = GetComponentInChildren<Collider>();
        maxHealth = SetMaxHealth_FromHealthLevel_Enemy();
        currentHealth = maxHealth;
        healthBarEnemy.SetMaxHealth_Enemy(maxHealth);
    }

    private int SetMaxHealth_FromHealthLevel_Enemy()
    {
        maxHealth = healthLevel * 10;
        return maxHealth;
    }

    public void TakeDame(int dame)
    {
        currentHealth -= dame;
        healthBarEnemy.SetCurrentHealth_Enemy(currentHealth);
        animator.Play("Dealing");
        takeDameAudio.PlayOneShot(dameSound,1.0f);

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            animator.Play("Death");
            enemyCollider.enabled = !enemyCollider.enabled;
        }
    }
}
