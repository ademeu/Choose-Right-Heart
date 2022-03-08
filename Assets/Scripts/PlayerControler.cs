using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] Text _textSayac;
    [SerializeField] float _speed;

    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] Sprite _kalpliSprite;

    void ChangeSprite()
    {
        if (GameManager._instance._skor == 50)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = _kalpliSprite;
           // _spriteRenderer.sprite = _kalpliSprite;
        }
        
    }
    private void Update()
    {
        ChangeSprite();
    }

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


    #region Kirmizi Kalp OnTriggerEnter2D
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
    #endregion
    #region Siyah Kalp OnCollisionEnter2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PlayerPrefs.SetString("score", _textSayac.text);
            SceneManager.LoadScene("EndGame");
        }
    } 
    #endregion
}
