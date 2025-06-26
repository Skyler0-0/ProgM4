using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public ScoreManager scoreManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(scoreManager == null)
        {
            Debug.LogError("ScoreManager niet ingesteld!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 move = new Vector3 (moveX, 0f, 0f);
        transform.Translate (move);
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.name == "Coin")
        {
            scoreManager.AddScore(10);
            Debug.Log("Munt Gepakt");
            Destroy(other.gameObject);
        }
    }
}
