using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}