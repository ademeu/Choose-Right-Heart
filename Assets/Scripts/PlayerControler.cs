using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] Text _textSayac;
    [SerializeField] float _speed;

    private void Start()
    {
        GameManager._instance.ScoreSifir();
    }
    private void FixedUpdate()
    {
        PlayerHaraket();
    }
    void PlayerHaraket()
    {
        float yatay = Input.GetAxis("Horizontal") * _speed;
        float dikey = Input.GetAxis("Vertical") * _speed;
        yatay *= Time.deltaTime;
        dikey *= Time.deltaTime;
        transform.position += new Vector3(yatay, dikey);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Top":
                Destroy(collision.gameObject);
                _textSayac.text = GameManager._instance._skor.ToString();
                 GameManager._instance.UpdateScore();
                break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PlayerPrefs.SetString("score",_textSayac.text);
            SceneManager.LoadScene("EndGame");
        }
    }
}
