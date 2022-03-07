using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveName : MonoBehaviour
{
    [SerializeField] InputField _nameIF;

    public void SaveButton()
    {
        PlayerPrefs.SetString("name", _nameIF.text); 
        Debug.Log("Senin adin : " + PlayerPrefs.GetString("name"));
        SceneManager.LoadScene("Level1");
    }
   
}
