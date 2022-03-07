using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverController : MonoBehaviour
{
    Rigidbody2D _rg;
    [SerializeField] float _engelDususHizi;
    //Vector2 _v2;
   // DirectionEnum _directionEnum;

    private void Awake()
    {
        _rg = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        _rg.velocity = Vector2.down * _engelDususHizi;
    }
    //Vector2 DirectionSelect()
    //{
    //    if (_directionEnum == DirectionEnum.Alt)
    //    {
    //        _v2 = Vector2.down;
    //    }
    //    return _v2;
    //}
}
//enum DirectionEnum
//{
//    Alt
//}
