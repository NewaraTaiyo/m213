using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int currentHealth = 0;
    public int maxHealth = 100;

    public HealthBar healthBar;

    void Start(){
        currentHealth = maxHealth;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            takeDamage(10);
        }
    }

    public void takeDamage( int damage ){
        currentHealth -= damage;
        PlayerHealthbar.SetHealth(currentHealth);
    }
}
