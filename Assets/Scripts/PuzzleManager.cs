using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public int buttonsNeeded = 3;

    private int buttonsPressed = 0;

    public GameObject door;

    public void ButtonPressed()
    {
        buttonsPressed++;

        if (buttonsPressed >= buttonsNeeded)
        {
            door.SendMessage("ActivateObject");
        }
    }
}