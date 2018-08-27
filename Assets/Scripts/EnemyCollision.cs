using UnityEngine;
using TMPro;

public class EnemyCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bullet")
        {
            GameObject text = GameObject.Find("TextMeshPro");
            ScoreCount countComponent = text.GetComponent<ScoreCount>();
            countComponent.updateText();
        }
        Destroy(gameObject);
    }
}

