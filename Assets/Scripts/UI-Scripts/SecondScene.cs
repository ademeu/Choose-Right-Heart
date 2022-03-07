using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondScene : MonoBehaviour
{
    [SerializeField] Text _nameTxt;
    [SerializeField] Text _scoreTxt;

    private void Start()
    {
        _nameTxt.text = PlayerPrefs.GetString("name");
        _scoreTxt.text = PlayerPrefs.GetString("score");
        
    }

    public void DelteSavedButton()
    {
        //PlayerPrefs.DeleteKey("name");
        SceneManager.LoadScene("Login");
    }
}
