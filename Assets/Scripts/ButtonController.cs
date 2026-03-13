using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private bool activated = false;

    public void ActivateObject()
    {
        if (!activated)
        {
            activated = true;

            GetComponent<Renderer>().material.color = Color.green;

            FindObjectOfType<PuzzleManager>().ButtonPressed();
        }
    }
}