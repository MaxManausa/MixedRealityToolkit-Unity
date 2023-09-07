using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public class LaunchProjectile : MonoBehaviour
{
    [SerializeField] private GameObject launchSpawnPoint;
    //[SerializeField] public Animator launchAnimation;
    [SerializeField] private GameObject placeholderProjectile;
    //[SerializeField] public Text numberOfArrowsFired;
    //[SerializeField] private Text winArrowCount;

    //public float fireRate = 0.5f;
    public GameObject projectilePrefab;
    public float projectileForce = .1f;

    //[SerializeField] private GameObject firingButton;
    
    [SerializeField] private AudioSource projectileAudioSource;
    [SerializeField] private AudioClip projectileFiringSound;
    
/*
    public float arrowsFired;
    public float targetsToHit = 3;
*/

    public void Start()
{
    //firingButton.SetActive(true);
}

    public void OnButtonSmash()
    {
        //Invoke("DrawBack",.1f);
        Invoke("ShootProjectile",.4f);
        Invoke("ReenableProjectile",.8f);
    }

    public void RepeatingButtonSmash()
    {
        // Start the repeating method
        InvokeRepeating("OnButtonSmash", 0.1f, 0.25f);

        // Stop the repeating after 6 seconds
        Invoke("StopRepeatingButtonSmash", 5.0f);
    }

    private void StopRepeatingButtonSmash()
    {
        // Stop the repeating method
        CancelInvoke("OnButtonSmash");
    }

    public void FiveShots()
    {
        int i = 0;
        Invoke("OnButtonSmash", i += 1);
        Invoke("OnButtonSmash", i += 1);
        Invoke("OnButtonSmash", i += 1);
        Invoke("OnButtonSmash", i += 1);
        Invoke("OnButtonSmash", i += 1);
    }

    /*
    public void AnimationThenFire()
    {
        launchAnimation = GetComponent<Animator>();
        launchAnimation.enabled = true;
        launchAnimation.Play("GetShotBoi");
    }
    */

    public void ShootProjectile()
    {
        placeholderProjectile.SetActive(false);
        Transform projectileSpawnPos = launchSpawnPoint.transform;
        //AnimationThenFire();
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPos.position, projectileSpawnPos.rotation);
        Rigidbody projectileRB = projectile.GetComponent<Rigidbody>();
        projectileRB.AddForce(projectileSpawnPos.forward * projectileForce, ForceMode.Impulse);
        PlaySound(projectileFiringSound);
        /*
        arrowsFired = arrowsFired + 1;
        
        numberOfArrowsFired.text = ("Arrows Fired: " + arrowsFired);
       
        float result = (targetsToHit / arrowsFired ) * 100f;
        float roundedResult = Mathf.Round(result * 100f) / 100f;
        string formattedResult = string.Format("{0:0.00}%", roundedResult);
        
        winArrowCount.text = ("It only took you " + arrowsFired + " arrows to hit " + targetsToHit + 
                                 " targets! You were " + formattedResult + " accurate!");                         
        */

        Destroy(projectile, 5f);
        
        //Debug.Log("hi!!!!!!!");
    }

    public void ReenableProjectile()
    {
        placeholderProjectile.SetActive(true);
    }
    
    
    private void PlaySound(AudioClip newSound)
    {
        projectileAudioSource.clip = newSound;
        projectileAudioSource.Play();
    }
/*
    public void ResetArrowsFired()
    {
        arrowsFired = 0;
    }
*/
}