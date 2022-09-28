using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int scoreCount;


    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreCount.ToString();
    }
}
