using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private Vector3 objetivo;

    [SerializeField] private Camera camara;

    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float anguloInicial;

    private Vector2 direccion;
    private Rigidbody2D rb2D;
    private Vector2 input;

    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        objetivo = camara.ScreenToWorldPoint(Input.mousePosition);

        float anguloRadianes = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x);
        float angulosGrados = (180 / Mathf.PI) * anguloRadianes - anguloInicial;
        transform.rotation = Quaternion.Euler(0,0,angulosGrados);

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        direccion = input.normalized;
       
        
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position+ direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }

    /*  private void OnCollisionEnter2D(Collision2D collision)
      {
          // Si el objeto colisiona con otro objeto, detener su movimiento y desactivar el rebote
          rb2D.velocity = Vector2.zero;
          rb2D.angularVelocity = 0f;
          rb2D.AddForce(Vector2.zero);

          // Ajustar coeficiente de rebote y fricción


         rb2D.sharedMaterial.bounciness = 0f; // Sin rebote
         rb2D.sharedMaterial.friction = 0f; // Sin fricción
      }*/

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag ("Ground"))
        {
            Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<Collider2D>());
        }
    }*/



}
