using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 真っ直ぐ追いかける敵の動きを管理するクラス
/// </summary>
public class EnemyA : MonoBehaviour
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
        rb2D.AddForce((GameObject.FindWithTag("Player").transform.position - this.transform.position).normalized * move_speed, ForceMode2D.Force);
    }
}
   /* private GameObject player;
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
        Vector2 force = (playerposition - enemyposition) * (targetVelocity - rb2D.velocity.x) * move_speed;
        rb2D.AddForce(force,ForceMode2D.Force);
    } */



/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 真っ直ぐ追いかける敵の動きを管理するクラス
/// </summary>
public class EnemyA : MonoBehaviour
{
    private GameObject player;
    public float move_speed;
    public Transform Player;
    private float positionDif;
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
        Vector2 positionDif = playerposition - enemyposition;
        if(positionDif.x < 0){
            positionDif *= -1;
        }
        Vector2 force = (positionDif) * (targetVelocity - rb2D.velocity.x) * move_speed;
        rb2D.AddForce(force,ForceMode2D.Force);
    }
}
*/