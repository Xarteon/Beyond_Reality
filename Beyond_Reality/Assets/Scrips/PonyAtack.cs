using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PonyAtack : MonoBehaviour
{
    private GameObject PointReference;
    private GameObject Player;
    [SerializeField] private float Speed; 
    void Start()
    {

        PointReference = GameObject.FindWithTag("Point");
        Player = GameObject.FindWithTag("Player");
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
        if (other.gameObject.CompareTag("Point")|| other.gameObject.CompareTag("Player")) 
        {
            Destroy(gameObject);
        }
    }
}