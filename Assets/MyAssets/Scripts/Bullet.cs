using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///弾の動きを管理するクラス
/// </summary>

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb2D ;
    public float BulletSpeed; 
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2D.velocity = transform.right * BulletSpeed *1;
    }
}
