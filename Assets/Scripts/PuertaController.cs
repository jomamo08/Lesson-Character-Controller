using UnityEngine;

public class PuertaController : MonoBehaviour
{
    [SerializeField] private Transform doorPosition;

    [SerializeField] private Vector3 open;
    [SerializeField] private Vector3 close;
    [SerializeField] private Vector3 final;

    private float path;
    private float startTime;
    private float pathTime;

    private bool opening = false;
    private bool closing = false;

    void Start()
    {
        close = doorPosition.localPosition;

        final = new Vector3(0f, 6f, 0f);

        open = close + final;

        pathTime = 3f;
    }

    void Update()
    {
        if (opening)
        {
            path = (Time.time - startTime) / pathTime;

            doorPosition.localPosition = new Vector3(
                doorPosition.localPosition.x,
                Mathf.Lerp(close.y, open.y, path),
                doorPosition.localPosition.z
            );

            if (doorPosition.localPosition.y >= open.y)
            {
                opening = false;
            }
        }
    }

    public void ActivateObject()
    {
        startTime = Time.time;
        opening = true;
    }
}