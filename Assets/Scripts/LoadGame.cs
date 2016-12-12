using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{

    public void LoadLevel()
    {
        SceneManager.LoadScene("AI Game");
    }
}
