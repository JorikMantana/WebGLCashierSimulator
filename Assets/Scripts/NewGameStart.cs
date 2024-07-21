using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameStart : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadSceneAsync("MainGame");
    }
}
