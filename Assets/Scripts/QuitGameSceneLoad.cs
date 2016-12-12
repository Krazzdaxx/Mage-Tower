using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class QuitGameSceneLoad : MonoBehaviour {

    public void LoadQuitGame()
    {
        SceneManager.LoadScene("Quit");
    }
}
