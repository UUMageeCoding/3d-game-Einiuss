using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMill : MonoBehaviour, IInteractable

{
    public string GetDescription()
    {
        return "Exit Mill.";
    }

    public void Interact()
    {
        SceneManager.LoadScene(0);
    }
}
