using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの動きの処理
/// </summary>
public class Player : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 6f;

    [SerializeField]
    private float playerSlowSpeed = 3f;

    [SerializeField]
    private GameObject Bullet;

    float playerNowSpeed;

    void FixedUpdate()
    {
        MovePlayer();
        MoveSlowPlayer();
        Fire();
    }

    /// <summary>
    /// プレイヤーの移動
    /// </summary>
    void MovePlayer()
    {
        Vector3 playerPos = transform.position;

        if(Input.GetKey(KeyCode.W))
        {
            playerPos.y += playerNowSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,0,0);
        } 
        if(Input.GetKey(KeyCode.S))
        {
            playerPos.y -= playerNowSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,0,180);
        }

        if(Input.GetKey(KeyCode.D))
        {
            playerPos.x += playerNowSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,0,270);
        } 
        if(Input.GetKey(KeyCode.A))
        {
            playerPos.x -= playerNowSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,0,90);
        }

        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0,0,45);
        }
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0,0,315);
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0,0,135);
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0,0,225);
        }

        transform.position = playerPos;
    }

    void MoveSlowPlayer()
    {
        playerNowSpeed = (Input.GetKey(KeyCode.LeftShift)) ? playerSlowSpeed : playerSpeed;
    }

    void Fire()
    {
        
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(Bullet,this.transform.position,this.transform.rotation * Bullet.transform.rotation);
        }
    }

}
