using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 逃げる敵の動きを管理するクラス
/// </summary>
public class EnemyB : MonoBehaviour
{
     public float move_speed;
    public Transform Player;
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private float targetVelocity;

    void Start()
    {

    }

    void Update()
    { 
        rb2D.AddForce((GameObject.FindWithTag("Player").transform.position - this.transform.position).normalized * move_speed * -1, ForceMode2D.Force);
    }
}

/*    private GameObject player;
    public float move_speed;
    public Transform Player;
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private float targetVelocity;

    void Start()
    {
        GameObject.FindWithTag("Player");
    }

    void Update()
    {     
        Vector2 enemyposition  = transform.position;
        Vector2 playerposition = Player.position;
        Vector2 force = (playerposition - enemyposition) * (targetVelocity - rb2D.velocity.x) * move_speed * -1;
        rb2D.AddForce(force,ForceMode2D.Force);
    }
    */