using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 8f;

    private AudioSource bulletAudioSource;

    // Use this for initialization
    void Start () {
        bulletAudioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("com.byron:.PrimaryIndexTrigger");
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Space key was pressed.");
        }
            
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.name = "Bullet";

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
        bulletAudioSource.Play();
        // Destroy the bullet after 2 seconds
        Destroy(bullet, 1.0f);
    }
}
