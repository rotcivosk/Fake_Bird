using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float pipeSpeed;
    public float leftBorderPosition;
    public float rightBorderPosition;
    private float heightNewBorder;
    public Sprite[] pipeSprites; // Lista de sprites para alterar
    [SerializeField] float porcentagemItensComFalha = 0.5f;

    private SpriteRenderer pipeOneUpRenderer;
    private SpriteRenderer pipeOneDownRenderer;

        void Start()
    {
        pipeOneUpRenderer = transform.Find("PipeOneUp").GetComponent<SpriteRenderer>();
        pipeOneDownRenderer = transform.Find("PipeOneDown").GetComponent<SpriteRenderer>();

    }

    private void Update()
    {
        transform.Translate(Vector3.left * pipeSpeed * Time.deltaTime);

        if (transform.position.x < leftBorderPosition) {
            heightNewBorder = Random.Range(11, 15); 
            transform.position = new Vector2(rightBorderPosition, heightNewBorder);
            Debug.Log ("Alterando para :" + rightBorderPosition + " / " + heightNewBorder);

            if (Random.Range(0f, 1f) < porcentagemItensComFalha){
                pipeOneUpRenderer.sprite = pipeSprites[Random.Range(0, pipeSprites.Length)];
            }
            else{
                pipeOneUpRenderer.sprite = pipeSprites[0];
            }
            if (Random.Range(0f, 1f) < porcentagemItensComFalha){
                pipeOneDownRenderer.sprite = pipeSprites[Random.Range(0, pipeSprites.Length)];
            }
            else{
                pipeOneDownRenderer.sprite = pipeSprites[0];
            }
         }
    }

}
