using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // 何かがこのオブジェクト（トリガー）に触れた瞬間に実行される
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 触れた相手（果物など）を削除する
        Destroy(collision.gameObject);
    }
}