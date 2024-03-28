using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JetEngineInteraction : MonoBehaviour
{
    public Behaviour[] components;
    [SerializeField]private Animator animator;
    public void OnHandButtonClick(bool value)
    {
        foreach (Behaviour component in components)
        {
            component.enabled = value;
        }
    }

    public void SplitViewButtonClick(bool status)
    {
        
       
    }
    public void PlayAnimationButtonClick(bool status)
    {
        if (animator != null)
        {
            animator.SetBool("Rotate", status);
        }
        else
        {
            Debug.Log("animator is empty");
        }

    }

    public void TranslateButtonClick(bool status)
    {
        components[0].enabled = status;
    }

    public void ScaleButtonClick(bool status)
    {
        components[1].enabled = status;
    }

    public void RotateButtonClick(bool status)
    {
        components[2].enabled = status;
    }

    public void OnBackButtonClick()
    {
        SceneManager.LoadScene(0);
    }
}
