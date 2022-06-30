using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Vector2 firstTap, secondTap;
    public bool click = false;

    void Update()
    {
        if (!click && Input.touchCount > 0)
        {
            click = true;
            firstTap = Input.touches[0].position;
        }
        if (click && Input.touchCount > 0)
        {
            secondTap = Input.touches[0].position;
            Vector3 v = Camera.main.transform.eulerAngles;
            v = new Vector3(v.x, v.y + (firstTap.x - secondTap.x), v.z);

            Camera.main.transform.eulerAngles = v;
            firstTap = secondTap;
        }
        else
        {
            click = false;
        }
    }
}
