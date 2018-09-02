using System.Collections;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject enemyPrefab;
    public bool useGravity;
    public float enemySpeed = 10f;
    public int timeToWaitForNextEnemy = 2;

    private AudioSource enemyAudioSource;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        enemyAudioSource = GetComponent<AudioSource>();
        StartCoroutine(FireObject());
    }

    IEnumerator FireObject()
    {
        while (true)
        {
            int timeToWait = Random.Range(1, timeToWaitForNextEnemy);
            yield return new WaitForSeconds(timeToWait);

            // Create the enemy from the enemy Prefab
            var bullet = (GameObject)Instantiate(
                enemyPrefab,
                this.transform.position,
                this.transform.rotation);

            // Add velocity to the enemy
            Rigidbody bulletRigidBody = bullet.GetComponent<Rigidbody>();
            bulletRigidBody.useGravity = useGravity;
            bulletRigidBody.velocity = bullet.transform.forward * enemySpeed;

            // Play sound
            if (enemyAudioSource != null)
            {
                enemyAudioSource.Play();
            }
        }

    }
}
