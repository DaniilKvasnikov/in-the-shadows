using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Button normalModeButton;
    [SerializeField] private Button testModeButton;
    [SerializeField] private int nextSceneNum = 1;

    private void Awake()
    {
        normalModeButton.onClick.AddListener(OpenLvl);
        testModeButton.onClick.AddListener(OpenLvl);
    }

    private void OnDestroy()
    {
        normalModeButton.onClick.RemoveListener(OpenLvl);
        testModeButton.onClick.RemoveListener(OpenLvl);
    }

    private void OpenLvl()
    {
        SceneManager.LoadScene(nextSceneNum);
    }
}
