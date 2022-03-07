using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControl : MonoBehaviour
{
    [SerializeField] GameObject _dusenEnemy;
    void Start()
    {
        StartCoroutine(EnemyYarat());
    }
     
   
    IEnumerator EnemyYarat()
    {
        Instantiate(_dusenEnemy, new Vector3(Random.Range(-2.5f, 2.5f), 6f, 0f), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(EnemyYarat());
    }
}
