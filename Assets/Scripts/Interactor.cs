using UnityEngine;
using TMPro;

interface IInteractable 
{ 
    public void Interact();
    string GetDescription();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange = 3f;

    public GameObject interactionUI;        // UI background/panel
    public TextMeshProUGUI interactionText; // UI text display

    void Update()
    {
        HandleInteractionRay();
    }

    void HandleInteractionRay()
    {
        Ray ray = new Ray(InteractorSource.position, InteractorSource.forward);

        bool hitSomething = false;

        if (Physics.Raycast(ray, out RaycastHit hit, InteractRange))
        {
            
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                hitSomething = true;

                // You can display a generic message or per-object text
                interactionText.text = interactable.GetDescription();

               
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
        }

       
        interactionUI.SetActive(hitSomething);
    }
}

