using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class SecondScene : MonoBehaviour
{
    [SerializeField] Text _nameTxt;
    [SerializeField] public Text _scoreTxt;

    private void Start()
    {   
        _nameTxt.text = PlayerPrefs.GetString("name");
        Debug.Log("Aldigin Score: " + PlayerPrefs.GetString("score",_scoreTxt.text));
        _scoreTxt.text = $"Aldigin Score: {PlayerPrefs.GetString("score")}";
    }

    public void DelteSavedButton()
    {
        PlayerPrefs.DeleteKey("score");
        SceneManager.LoadScene("Login");
    }
}
