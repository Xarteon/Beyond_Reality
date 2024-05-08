using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PonyAtack : MonoBehaviour
{
    private GameObject PointReference;
    [SerializeField] private float Speed; 
    void Start()
    {

        PointReference = GameObject.FindWithTag("Point");
    }
    void Update()
    {
        PonyPersecusion();
    }
    private void PonyPersecusion() 
    {
        transform.position = Vector3.MoveTowards(transform.position, PointReference.transform.position, Speed * Time.deltaTime);
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point")) 
        {
            Destroy(gameObject);
        }
    }
}