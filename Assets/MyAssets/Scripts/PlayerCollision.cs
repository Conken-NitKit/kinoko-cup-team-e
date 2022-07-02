using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject LifeCount1;

    [SerializeField]
    private GameObject LifeCount2;

    [SerializeField]
    private GameObject LifeCount3;

    private int Counter = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Counter += 1;
        }

        if (Counter == 1)
        {
            Destroy(LifeCount1);
        }

        if (Counter == 2)
        {
            Destroy(LifeCount2);
        }

        if (Counter == 3)
        {
            Destroy(LifeCount3);
            Destroy(Player);
            ChangeScene();
        }

        void ChangeScene()
        {
            SceneManager.LoadScene("Gameover");
        }
    }
}
