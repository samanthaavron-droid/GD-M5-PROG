using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float x = Random.Range(-10f, 10f);
            float z = Random.Range(-10f, 10f);
            float y = 0;

            Instantiate(prefab, new Vector3(x,y,z), Quaternion.identity);
        }
    }
}
