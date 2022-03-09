using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] Text _textSayac;
    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] Sprite _kalpliSprite;
    [SerializeField] float _speed;
    
    
    private void Update()
    {
        ChangeSprite();
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchDeltaPosition.x * _speed, 
                touchDeltaPosition.y * _speed, 0);
        }
    }

    private void Start()
    {
        GameManager._instance.ScoreSifir(); 
    }
   
    #region Kirmizi Kalp SpriteRenderer
    void ChangeSprite()
    {
        if (GameManager._instance._skor == 51)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = _kalpliSprite;
            // _spriteRenderer.sprite = _kalpliSprite;
        }
    } 
    #endregion
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
