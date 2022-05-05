using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    [SerializeField] private Vector2 direccion;
    public MusicalNote ProyectilPrefab;
    public Transform LaunchOffset;

    public float velocidadX = 10;    // Horizontal (para movimiento horizontal)
    public float velocidadY = 10;    // Vertical (para el salto)
    // El componente Rigidbody del personaje (para física)
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private Animator animator;
    private SpriteRenderer sprRenderer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update(){
      if (Input.GetButtonDown("Fire1"))
      {
        Instantiate(ProyectilPrefab, LaunchOffset.position, LaunchOffset.transform.rotation); 
      }
    }
    private void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0 &&  Mathf.Abs(rb.velocity.y) < 0.001)
        {
            rb.AddForce(new Vector2(0, velocidadY), ForceMode2D.Impulse);
        }
        animator.SetFloat("Velocity", Mathf.Abs(rb.velocity.x));
        // Velocidad (parámetro del diagrama de estados)
        sprRenderer.flipX = rb.velocity.x < 0;
    }
}
