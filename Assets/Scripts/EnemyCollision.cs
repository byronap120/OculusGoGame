using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bullet")
        {
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
