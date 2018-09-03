using UnityEngine;

public class BulletCollision : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        Destroy(this.gameObject);
    }
}
