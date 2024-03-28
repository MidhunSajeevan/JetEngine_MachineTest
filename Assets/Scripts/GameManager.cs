using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    private static GameManager _instance;

    void Awake()
    {
        // Ensure that there is only one instance of GameManager
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
   
    public void OnQuitButtonClicked()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
 

    public void OnAddButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
