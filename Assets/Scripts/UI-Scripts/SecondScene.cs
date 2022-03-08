using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondScene : MonoBehaviour
{
    [SerializeField] Text _nameTxt;
    [SerializeField] public Text _scoreTxt;

    private void Start()
    {   
        _nameTxt.text = PlayerPrefs.GetString("name");
        Debug.Log("Aldigin Score: " + PlayerPrefs.GetString("score",_scoreTxt.text));

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            _scoreTxt.text = $"Aldigin Score: {PlayerPrefs.GetString("score")}";
        }
       
    }

    public void DelteSavedButton()
    {
        PlayerPrefs.DeleteKey("score");
        SceneManager.LoadScene("Login");
    }
}
