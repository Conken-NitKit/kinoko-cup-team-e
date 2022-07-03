using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private GameObject ScorePrint;

    int Score;

    void Update()
    {
        int Score = ScoreCounter.GetScore();
        Text Score_text = ScorePrint.GetComponent<Text>();
        Score_text.text = "スコア " + Score;
    }
}
