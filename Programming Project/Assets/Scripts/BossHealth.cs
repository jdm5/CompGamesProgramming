/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public MissionComplete mission;
    public Animator anim;
    bool dead;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        anim = GetComponent<Animator>();
        anim.SetBool("isDead", false);
        dead = false;
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth == 0)
        {
            mission.missionComplete(true);
            Die();
        }
    }

    public bool isDead()
    {
        return dead;
    }

    void Die()
    {
        anim.SetBool("isDead", true);
        dead = true;
        this.enabled = false;
        GetComponent<Collider>().enabled = false;
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public Animator anim;
    bool dead;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        anim = GetComponent<Animator>();
        anim.SetBool("isDead", false);
        dead = false;
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth == 0)
        {
            Die();
        }
    }

    public bool isDead()
    {
        return dead;
    }

    void Die()
    {
        anim.SetBool("isDead", true);
        dead = true;
        this.enabled = false;
        GetComponent<Collider>().enabled = false;
    }
}

