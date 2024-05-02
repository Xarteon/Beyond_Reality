using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class InvokeAtack : MonoBehaviour
{
    public GameObject PonyObject;
    int xPoint;
    int zPoint;
    int EnemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (EnemyCount < 5)
        {
            xPoint = Random.Range(-5, 6);
            zPoint = Random.Range(-5, 6);
            Instantiate(PonyObject, new Vector3(xPoint, 0, zPoint), Quaternion.identity);
            yield return new WaitForSeconds(1);
            EnemyCount++;
        }
    }
}
