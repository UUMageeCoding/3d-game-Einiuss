using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterMill : MonoBehaviour, IInteractable 

{
    public string GetDescription()
    {
        return "Enter Mill.";
    }

    public void Interact()
    {
        SceneManager.LoadScene(1);
    }
}
