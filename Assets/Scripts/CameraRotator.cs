using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public float autospeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, autospeed * Time.deltaTime, 0);
    }

  
}