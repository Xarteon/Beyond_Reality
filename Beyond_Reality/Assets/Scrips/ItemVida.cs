using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemVida : MonoBehaviour
{
    
    private GameObject PlayerHealt;

    void Start()
    {
        PlayerHealt = GameObject.FindWithTag("Player");

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealt.GetComponent<HealthcareSystem>().Health += 10;

            Destroy(gameObject);
        }
    }
}
    