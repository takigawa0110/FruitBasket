using UnityEngine;

public class Basket : MonoBehaviour
{
    // バスケットのY位置を固定したい場合
    [SerializeField] float fixedY = -2f;

    void Update()
    {
        MoveWithMouse();
    }

    void MoveWithMouse()
    {
        // マウスのスクリーン座標 → ワールド座標に変換
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f; // カメラからの距離（2Dでは重要）

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        // Xだけマウスに追従、Yは固定
        transform.position = new Vector3(
            worldPos.x,
            fixedY,
            transform.position.z
        );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fruit"))
        {
            Debug.Log("果物キャッチ！");
            Destroy(other.gameObject);
        }
    }
}