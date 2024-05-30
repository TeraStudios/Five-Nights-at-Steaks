using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GotoGame : MonoBehaviour
{
    public Button buttonToClick;
    public string sceneToLoad = "SampleScene";

    void Start()
    {
        // Add a listener to the button's click event
        buttonToClick.onClick.AddListener(LoadSceneOnClick);
    }

    void LoadSceneOnClick()
    {
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
