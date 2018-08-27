using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour {

    public int count = 0;
    private TextMeshPro textmeshPro;

    // Use this for initialization
    void Start()
    {
        textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText("Score:{0}", count);
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void updateText()
    {
        count++;
        textmeshPro.SetText("Score:{0}", count);
    }
}
