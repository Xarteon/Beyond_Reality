using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class InvokeAtack : MonoBehaviour
{
    public GameObject[] PonyObject;
    private GameObject ObjetctTag;
    int xPoint;
    int zPoint;
    int EnemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        ObjetctTag = GameObject.FindWithTag("Yaces");
    }
    private IEnumerator Spawn()
    {
        while (EnemyCount < 10)
        {
            xPoint = Random.Range(-10,10);
            zPoint = Random.Range(-10, 10);
            int randomIndex = Random.Range(0, PonyObject.Length);
            if (gameObject.CompareTag("Yaces"))
            {
                Instantiate(PonyObject[randomIndex], new Vector3(xPoint, 8, zPoint), Quaternion.identity);
            }
            else
            { Instantiate(PonyObject[randomIndex], new Vector3(xPoint, 0, zPoint), Quaternion.identity); }
            yield return new WaitForSeconds(0.5f);
            EnemyCount++;
        }
    }
}