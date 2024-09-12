using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D ballRigidbody;
    public float startVelocity;
    public GameController controller;
    public Vector2 posicaoInicial = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        ResetarPosicaoBola();
    }

    public void ResetarPosicaoBola (){
        ballRigidbody.transform.position = posicaoInicial;
        float playerXDirection = 0;
        float playerYDirection = 0;
        while (playerXDirection == 0){
            playerXDirection = Random.Range(1,-1);
        }
        while (playerYDirection == 0){
            playerYDirection = Random.Range(1,-1);
        }
        ballRigidbody.velocity = new Vector2(playerXDirection * startVelocity, playerYDirection * startVelocity);
    }



    // Update is called once per frame
    void Update()
    {
    }
}
