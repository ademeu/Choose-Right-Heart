
using UnityEngine;

public class MoverController : MonoBehaviour
{
    Rigidbody2D _rg;
     float _engelDususHizi;

    private void Awake()
    {
        _rg = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _engelDususHizi += GameManager.hizdegis();
    }

    void Update()
    {
        _rg.velocity = Vector2.down * _engelDususHizi;

    }
  
}
    
