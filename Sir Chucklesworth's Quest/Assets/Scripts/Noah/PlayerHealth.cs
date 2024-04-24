using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int health;
    public int maxHealth = 5;

    public SpriteRenderer playerSr;
    public PlayerDash playerdash;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    
    public void TakeDamage(int amoungt)
    {
        health -= amoungt;
        if (health <= 0)
        {
            playerSr.enabled = false;
            playerdash.enabled = false;
        }
    }
}