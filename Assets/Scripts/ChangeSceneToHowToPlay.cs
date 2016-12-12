using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeSceneToHowToPlay : MonoBehaviour {

    public void LoadHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
