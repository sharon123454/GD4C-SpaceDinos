using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private GameObject _settingWindow;
    [SerializeField] private Button _resumeButton;
    [SerializeField] private Button _menueButton;
    [SerializeField] private Button _quitButton;

    private void Start()
    {
        _resumeButton.onClick.AddListener(() => ResumeGame());
        _menueButton.onClick.AddListener(() => SceneManager.LoadScene(1));
        _quitButton.onClick.AddListener(OnQuitClicked);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_settingWindow.activeInHierarchy)
                ResumeGame();
            else
            {
                _settingWindow.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    private void ResumeGame()
    {
        _settingWindow.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnQuitClicked()//Close/Exit game
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

}