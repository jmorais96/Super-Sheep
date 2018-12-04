using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour {

    // Background sounds 
    public AudioSource Background1;
    public AudioSource Background2;
    public AudioSource BackgroundRockslide;

    // Player sounds 
    public AudioSource PlayerJump;
    public AudioSource PlayerAttack;
    public AudioSource PlayerDeath;

    // Power-Ups
    public AudioSource AmmunitionPowerUp;
    public AudioSource LifePowerUp;

    // Enemy sounds (alien - grounded and spaceship)
    public AudioSource EnemyAlienJump;
    public AudioSource EnemyAlienLightRay;
    public AudioSource EnemyAlienDeath;
    public AudioSource EnemyAlienSpaceshipEngine;
    public AudioSource EnemyAlienSpaceshipDoor;

    // Enemy sounds (fox)
    public AudioSource EnemyFoxJump;
    public AudioSource EnemyFoxDeath;

    // Enemy sounds (wolf)
    public AudioSource EnemyWolfJump;
    public AudioSource EnemyWolfDeath;
       
    // Background sounds - playing actions
    public void playBackground1()
    {
        Background1.Play();
    }

    public void playBackground2()
    {
        Background2.Play();
    }

    public void playBackgroundRockslide()
    {
        BackgroundRockslide.Play();
    }

    // Player sounds - playing actions
    public void playPlayerJump()
    {
        PlayerJump.Play();
    }


    public void playPlayerAttack()
    {
        PlayerAttack.Play();
    }

    public void playPlayerDeath()
    {
        PlayerDeath.Play();
    }

    // Power-Ups sounds - playing actions
    public void playAmmunitionPowerUp()
    {
        AmmunitionPowerUp.Play();
    }

    public void playLifePowerUp()
    {
        LifePowerUp.Play();
    }

    // Alien sounds (grounded and spaceship) - playing actions 
    public void playEnemyAlienJump()
    {
        EnemyAlienJump.Play();
    }

    public void playEnemyAlienLightRay()
    {
        EnemyAlienLightRay.Play();
    }

    public void playEnemyAlienDeath()
    {
        EnemyAlienDeath.Play();
    }

    public void playEnemyAlienSpaceshipEngine()
    {
        EnemyAlienSpaceshipEngine.Play();
    }

    public void playEnemyAlienSpaceshipDoor()
    {
        EnemyAlienSpaceshipDoor.Play();
    }

    // Fox sounds - playing methods
    public void playEnemyFoxJump()
    {
        EnemyFoxJump.Play();
    }

    public void playEnemyFoxDeath()
    {
        EnemyFoxDeath.Play();
    }

    // Wolf sounds - playing methods
    public void playEnemyWolfJump()
    {
        EnemyWolfJump.Play();
    }

    public void playEnemyWolfDeath()
    {
        EnemyWolfDeath.Play();
    }

}