using UnityEngine;

[RequireComponent(typeof(Camera))]
public class SideScrolling : MonoBehaviour
{
    private new Camera camera;
    private Transform player;

    public float height = 6.5f;
    public float undergroundHeight = -9.5f;
    public float undergroundThreshold = 0f;

    internal static float currentHeight;

    private void Awake()
    {
        camera = GetComponent<Camera>();
        player = GameObject.FindWithTag("Player").transform;
        currentHeight = height;
    }

    private void LateUpdate()
    {
        // track the player moving to the right
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = Mathf.Max(cameraPosition.x, player.position.x);
        cameraPosition.y = currentHeight;
        transform.position = cameraPosition;
    }

    public void SetUnderground(bool underground)
    {
        currentHeight = underground ? undergroundHeight : height;
    }

}


