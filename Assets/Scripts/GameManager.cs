using Unity.VisualScripting;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float speed = 5f;
    public float timeLeft = 20f;
    private int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ) * Time.deltaTime;
        transform.Translate(move);

        if(timeLeft <= 0)
        {
            Debug.Log("Game Over");
            enabled = false;
            return;
        }

        timeLeft -= Time.deltaTime;
        Debug.Log("Tijd over: " + Mathf.CeilToInt(timeLeft) + " | Score: " + score);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score += 10;
            Debug.Log("Yay 10 Points");
            Destroy(other.gameObject);
        }
    }
}
