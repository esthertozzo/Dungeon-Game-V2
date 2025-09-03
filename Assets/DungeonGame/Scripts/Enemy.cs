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
        Debug.Log("Meu nome � " + nome + " minha vida � " + vida + " meu m�ximo de vida � " + maxVida);
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
