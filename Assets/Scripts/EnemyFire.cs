using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {

    public GameObject enemyPrefab;
    public float enemySpeed = 10f;

    private AudioSource enemyAudioSource;

    // Use this for initialization
    void Start () {
        //Fetch the AudioSource from the GameObject
        enemyAudioSource = GetComponent<AudioSource>();
        StartCoroutine(FireObject());
    }
	
	// Update is called once per frame
	void Update () {
   
    }

    IEnumerator FireObject()
    {
        while (true)
        {
            int timeToWait = Random.Range(1, 7);
            yield return new WaitForSeconds(timeToWait);

            // Create the Bullet from the Bullet Prefab
            var bullet = (GameObject)Instantiate(
                enemyPrefab,
                this.transform.position,
                this.transform.rotation);

            // Add velocity to the bullet
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * enemySpeed;
            enemyAudioSource.Play();
        }

    }
}
