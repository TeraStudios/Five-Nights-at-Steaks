using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadBackToMainMenu : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public string animationName; // Name of the animation to listen for
    public string sceneName; // Name of the scene to load after animation ends

    private bool isAnimationPlayed;

    void Start()
    {
        // Ensure the animator component is assigned
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
        
        // Ensure the animator and animation name are provided
        if (animator == null || string.IsNullOrEmpty(animationName))
        {
            Debug.LogError("Animator or animation name not assigned.");
            return;
        }

        isAnimationPlayed = false;
    }

    void Update()
    {
        if (!isAnimationPlayed)
        {
            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
            if (stateInfo.IsName(animationName) && stateInfo.normalizedTime >= 1.0f)
            {
                isAnimationPlayed = true;
                LoadScene();
            }
        }
    }

    private void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not assigned.");
        }
    }
}
