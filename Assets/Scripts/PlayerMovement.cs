using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpPower;
    public GameController controller;
    public AudioClip flapSound;
    
    public AudioClip pointSound;
    [SerializeField] Rigidbody2D rigidbodyFlapBird;
    public AudioClip deathSound;
    void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Pipe"){
            Debug.Log("Tocou no pipe");
            AudioSource.PlayClipAtPoint(deathSound, transform.position);
            controller.LoseGame();
        }
        if (collision.gameObject.tag == "Point"){
            Debug.Log("Ponto para o player");
            AudioSource.PlayClipAtPoint(pointSound, transform.position);
            controller.AddPlayerPoint();
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingJump = false;
        
        isPressingJump = Input.GetKeyDown(KeyCode.Space);
        
        if (isPressingJump) {
            rigidbodyFlapBird.velocity = Vector2.up * jumpPower;
            AudioSource.PlayClipAtPoint(flapSound, transform.position);
        }
    }
}
