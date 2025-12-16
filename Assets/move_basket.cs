using UnityEngine;
using UnityEngine.UIElements;

public class move_basket : MonoBehaviour
{
    public float fixedY = -3f;
    void Start()
    {
        
    }
    public float minX = -8f;
    public float maxX = 8f;
    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mouse);
        float clampedX = Mathf.Clamp(worldPos.x, minX, maxX);
        transform.position = new Vector3(worldPos.x, fixedY, 0f);
    }
}
