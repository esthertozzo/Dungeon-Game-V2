using UnityEngine;

public class Enemy:MonoBehaviour
{
    public string nome;
    public float speed;
    public float vida;
    public float maxVida;
    public Transform target;
    void Start()
    {
        vida = maxVida;
        Introduction();

    }

    void Introduction()
    {
        Debug.Log("Meu nome é " + nome + " minha vida é " + vida + " meu máximo de vida é " + maxVida);
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

   private void Update()
    {
        Move();
    }
}
