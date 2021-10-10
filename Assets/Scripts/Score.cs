using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text _score;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
    }
    
    void Update()
    {
        _score.text = "Skor: " + score;
    }
}
