using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class GameUIController : MonoBehaviour
{
    public TextMeshProUGUI gameText;

    private bool introActive = true;

    void Update()
    {
        if (introActive && Keyboard.current.anyKey.wasPressedThisFrame)
        {
            gameText.text = "";
            introActive = false;
        }
    }

    public void ShowWinText()
    {
        gameText.text = "¡Has ganado!";
    }
}