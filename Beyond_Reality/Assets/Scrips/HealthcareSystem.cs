using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthcareSystem : MonoBehaviour
{
    public float Health;
    public float Damage = 10f;
    private void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Health -= Damage;
        }
    }
}
