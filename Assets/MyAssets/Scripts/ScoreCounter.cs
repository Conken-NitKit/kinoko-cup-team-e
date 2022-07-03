using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    protected static int Score = 0;

    [SerializeField]
    private int PlusScore;

    [SerializeField]
    private int EnemyLife;

    int count = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            count += 1;
            if(count >= EnemyLife)
            Destroy(this.gameObject);
            Score += PlusScore;
        }
    }

    public static int GetScore()
    {
        return Score;
    }

   
}
