using UnityEngine;

public class TreasureController : MonoBehaviour
{
    public void ActivateObject()
    {
        FindObjectOfType<GameUIController>().ShowWinText();
        Destroy(gameObject);
    }
}