using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField nameField;

    // Start new game
    public void StartNew()
    {
        string playerName = nameField.GetComponent<TMP_InputField>().text;
        if (!String.IsNullOrWhiteSpace(playerName))
        {
            DataHandler.Instance.playerName = playerName;
            SceneManager.LoadScene(1);
            DataHandler.Instance.LoadScore();
        }
    }
}
