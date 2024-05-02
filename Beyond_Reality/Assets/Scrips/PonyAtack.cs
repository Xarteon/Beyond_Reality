using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PonyAtack : MonoBehaviour
{
    private GameObject PointReference;
    [SerializeField] private float Speed;
    // Start is called before the first frame update
    void Start()
    {
        PointReference = GameObject.FindWithTag("Point");
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, PointReference.transform.position, Speed* Time.deltaTime);
    }
}
