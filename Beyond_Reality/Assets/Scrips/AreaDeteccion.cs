using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class AreaDeteccion : MonoBehaviour
{

    [SerializeField] private GameObject[] ObjectSystem;
    private int DatoIndex;
    private GameObject PLayer;
    private Vector3 Positionz;
    private float Positionz2;
    private float postionPl;
    // Start is called before the first frame update
    void Start()
    {
        PLayer = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        Positionz = PLayer.transform.forward + PLayer.transform.position;
        DatoIndex = Random.Range(0, ObjectSystem.Length);
        Positionz2 = Random.Range(-10,10)
;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) { 

            Instantiate(ObjectSystem[DatoIndex], new Vector3(Positionz2, 0, Positionz2) + Positionz, Quaternion.identity);
            //Instantiate(ObjectSystem[DatoIndex], new Vector3(0, 1,PLayer.transform.position), Quaternion.identity);
        }
    }
}
