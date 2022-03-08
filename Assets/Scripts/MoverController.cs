using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverController : MonoBehaviour
{
    Rigidbody2D _rg;
     float _engelDususHizi;


    private void Awake()
    {
        _rg = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _rg.velocity = Vector2.down * _engelDususHizi;

    }
    private void Start()
    {
        _engelDususHizi += GameManager.hizdegis();
    }
}
    
