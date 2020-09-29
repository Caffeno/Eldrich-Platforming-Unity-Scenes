
using UnityEngine;

public class simpleCameraMover : MonoBehaviour
{
    // Start is called before the first frame update

    private Camera mainCamera;

    void Start()
    {
        mainCamera = gameObject.GetComponent<Camera>();
        mainCamera.velocity.Set(100f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.velocity.Set(100f, 0f, 0f);

        Debug.Log(mainCamera.velocity);
    }
}
