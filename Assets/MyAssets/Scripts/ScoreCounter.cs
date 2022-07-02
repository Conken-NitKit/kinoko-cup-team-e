using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    protected static int Score = 0;

    [SerializeField]
    private int PlusScore;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Score += PlusScore;
        }
    }

    public static int GetScore()
    {
        return Score;
    }

   
}
