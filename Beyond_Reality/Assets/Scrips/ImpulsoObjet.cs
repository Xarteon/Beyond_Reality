using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsoObjet : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject Canicas;
    private GameObject ReduccionForce;
    // Start is called before the first frame update
    void Start()
    {
       Canicas = GameObject.FindWithTag("Canicas");
      // ReduccionForce = GameObject.FindWithTag("Suelo");
       rb = GetComponent<Rigidbody>();


        if (gameObject.CompareTag("Canicas")) 
        {
            rb.AddForce(transform.right * 20f, ForceMode.Impulse);
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
        rb.AddForce(collision.contacts[0].normal * 10f, ForceMode.Impulse);

        if (collision.gameObject.CompareTag("Suelo")) 
        {
           // Destroy(rb); // despues de 2 segundos
            //Quitar Fuerza y que se quede quieto
        }
    }
    private void ReboteCanicas() 
    {

        rb.AddForce(transform.right * 20f, ForceMode.Impulse);
    }
}
