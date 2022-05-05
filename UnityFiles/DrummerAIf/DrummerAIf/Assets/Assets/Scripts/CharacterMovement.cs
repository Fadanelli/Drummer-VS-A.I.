using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Vector2 direccion;
    //Baquetas
    public Transform baquetas;
    //Notas musicales
    public GameObject MN1;
    //Instancia
    private Rigidbody2D rb;

    //Animator
    private Animator animator;

    //Sprite Renderer
    private SpriteRenderer sprRenderer;

    //Velocity
     public float velocidadX = 0;
     public float velocidadY = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); //Diagrama de estados
        sprRenderer = GetComponent<SpriteRenderer>();
    }
  
    private void FixedUpdate()
    {
        //Debil
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(MN1, baquetas.position, Quaternion.identity);
        }
 
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);
        float movVertical = Input.GetAxis("Jump");
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, velocidadY), ForceMode2D.Impulse);
        }
        float velocidad = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Velocity", velocidad);

        //Direccion de animacion
        sprRenderer.flipX = rb.velocity.x < 0;
    }
}
