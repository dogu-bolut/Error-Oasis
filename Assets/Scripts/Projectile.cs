using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 15f;
    [SerializeField] int hitDamage = 50;
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * projectileSpeed);
        //transform.Rotate(0, 0, -359);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        var attacker = collision.GetComponent<Attacker>();
        
        if(attacker && health)
        {
            health.DealDamage(hitDamage);
            Destroy(gameObject);
        }
    }
}
