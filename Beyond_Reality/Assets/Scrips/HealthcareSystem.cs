using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthcareSystem : MonoBehaviour
{
    public float Health;
    public float Damage = 10f;
    public float HealthRecuperation = 25f;
    //public PlayerController playerController;
    private void Update()
    {
       // Health = Mathf.Min(Health, 100);
       // Health = Mathf.Max(Health, 0);
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
   /// private void OnTriggerStay(Collider collider)
    ///{
       // if (collider.gameObject.CompareTag("Pits"))
       // {
     //       Health += HealthRecuperation * Time.deltaTime;
   //   // }
   // }
}
