using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsoObjet : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject Canicas;
    private GameObject ReduccionForce;
    private bool Contac;
    void Start()
    {
       Canicas = GameObject.FindWithTag("Canicas");
      // ReduccionForce = GameObject.FindWithTag("Suelo");
       rb = GetComponent<Rigidbody>();
        if (gameObject.CompareTag("Canicas")) 
        {
            rb.AddForce(transform.right * 20f, ForceMode.Impulse);
        }
        else 
        {
            rb.AddForce(transform.right * 1f, ForceMode.Impulse);
        }
    }
    private void Update()
    {
        // e
        //if (gameObject.CompareTag("Canicas"))
        //{
        //    // el objeto rebote y mantenga la fuerza constatnte
        //    rb.AddForce(transform.right * 5f, ForceMode.Impulse);

        //}
        //else { rb.AddForce(transform.right * 0.5f, ForceMode.Impulse); }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Canicas")) { rb.AddForce(collision.contacts[0].normal * 10f, ForceMode.Impulse); }
        else 
        { 
            Contac = false;
            StartCoroutine(Freezyn());
        }
    }
    private void ReboteCanicas() 
    {
        rb.AddForce(transform.right * 20f, ForceMode.Impulse);
    }
    IEnumerator Freezyn() 
    {
        if(!Contac)
        {
            yield return new WaitForSeconds(1.5f);
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            Contac=true;
        }
    }
}
