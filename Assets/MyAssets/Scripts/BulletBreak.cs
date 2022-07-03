using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBreak : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet_object;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(Bullet_object);
        }
    }
}
