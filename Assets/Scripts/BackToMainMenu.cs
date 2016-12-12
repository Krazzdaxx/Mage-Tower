using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour {

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
