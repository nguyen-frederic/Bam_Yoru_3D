using UnityEngine;

public class Mob : MonoBehaviour
{
    [SerializeField] private string forme;
    [SerializeField] private Material couleur;
    [SerializeField] private float vitesse;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * vitesse * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("spell"))
        {
            Spell spell = other.gameObject.GetComponent<Spell>();

            if (spell.forme == forme)
            {
                Score.Instance.ajout_score(1);
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
            else
            {
                Player_spawn.Instance.recharge += 1f;
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
