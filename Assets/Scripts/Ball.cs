using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    [SerializeField] private Score scoreScript;
    private Rigidbody2D rb;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized;
        scoreScript = FindObjectOfType<Score>();
    }

    private void FixedUpdate() {
        Movement();
    }

    void Movement() {
        rb.velocity = direction * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Border")){
            direction.y = -direction.y;
        }
        else if (other.gameObject.CompareTag("Player")) {
            direction.x = -direction.x;
        }
        else if (other.gameObject.CompareTag("LeftGoal")) {
            scoreScript.IncreaseScore("Right");            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (other.gameObject.CompareTag("RightGoal")) {
            scoreScript.IncreaseScore("Left");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
