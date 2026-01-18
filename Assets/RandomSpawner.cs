using UnityEngine;
using System.Collections; // コルーチンを使うために必要

public class RandomSpawner : MonoBehaviour
{
    [Header("設定")]
    // GameObjectのあとに [] を付けると、複数のオブジェクトを入れられる「配列」になります
    public GameObject[] prefabsToSpawn;

    public float spawnInterval = 1.0f;

    [Header("生成範囲")]
    public float minX = -8f;
    public float maxX = 8f;
    public float spawnY = 6f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnObject();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnObject()
    {
        // 配列が空っぽの場合は何もしない
        if (prefabsToSpawn.Length == 0) return;

        // 0番目から「配列の数」の間でランダムな数字（インデックス）を決定
        int randomIndex = Random.Range(0, prefabsToSpawn.Length);

        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);

        // ランダムに選ばれたプレハブを生成
        Instantiate(prefabsToSpawn[randomIndex], spawnPosition, Quaternion.identity);
    }
}