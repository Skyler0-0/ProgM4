using UnityEditor;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5f;
    public GameObject coinPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randVal = Random.Range(-10f, 10f);
        Instantiate(coinPrefab, new Vector3(randVal, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * input * Time.deltaTime);
    }
}
