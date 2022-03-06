using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnerDusman : MonoBehaviour
{
    [SerializeField] GameObject _dusmanPref;

    private void Start()
    {
        StartCoroutine(DusmanYarat());
    }
    IEnumerator DusmanYarat()
    {
        Instantiate(_dusmanPref, new Vector3(Random.Range(-2.5f, 2.5f), 6f, 0f), Quaternion.identity);
        yield return new WaitForSeconds(3f);
        StartCoroutine(DusmanYarat());
    }
} 
