using Complete;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static LevelManager Inst
    {
        get
        {
            if (_inst == null)
            {
                GameObject obj = new GameObject("GameManager");
                return obj.AddComponent<LevelManager>();
            }
            return _inst;
        }
    }


    private static LevelManager _inst;

    private void Awake()
    {
        if (_inst != null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;
        
    }
    private AsyncOperation _currentLoadingScene;
    public void LateUpdate()
    {
        if (_currentLoadingScene != null)
        {
            _currentLoadingScene = null;
        }
    }

    public bool IsLoadingScene()
    {
        return _currentLoadingScene != null && !_currentLoadingScene.isDone;
    }


    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadSceneAsync(string name)
    {
        _currentLoadingScene = SceneManager.LoadSceneAsync(name);
    }

    public void LoadSceneAsyncAdditive(string name)
    {
        _currentLoadingScene = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
        //Debug.Log("Quit!!");
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetString("QuitTime", "The application last closed at: " + System.DateTime.Now);
    }



}
