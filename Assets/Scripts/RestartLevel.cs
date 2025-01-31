
using UnityEngine;
using UnityEngine.SceneManagement; 

public class RestartLevel : MonoBehaviour

{
    public void RestartCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

