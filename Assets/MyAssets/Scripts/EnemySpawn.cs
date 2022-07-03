using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private float SpawnTime;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private Transform range1;
    [SerializeField] private Transform range2;
    [SerializeField] private Transform range3;
    [SerializeField] private Transform range4;
    [SerializeField] private Transform player;
    private float time,x,y,z;
    void Update()
    {
        time += Time.deltaTime;
        if(time>SpawnTime)
        {
            x = Random.Range(range1.position.x, range2.position.x);
            y = Random.Range(range3.position.y, range4.position.y);
            z = 0;
            if(new Vector3(x,y,z) != player.position)
            {
                Spawn();
            }
            time = 0;
        }
    }

    void Spawn()
    {
        Instantiate(Enemy,new Vector3(x,y,z),Quaternion.Euler(0,0,0));
    }
}
