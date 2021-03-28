using UnityEngine;

public class Player_spawn : MonoBehaviour
{
    public float recharge;

    [Header("Objet a spawn")]
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject pyramide;
    [Space]
    [SerializeField] private GameObject particules;

    public static Player_spawn Instance;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (recharge > 0)
        {
            recharge -= Time.deltaTime;
        }
        else
        {
            if (Input.GetButtonDown("Cube"))
            {
                Instantiate(cube, transform.position, Quaternion.identity);
            }
            if (Input.GetButtonDown("Sphere"))
            {
                Instantiate(sphere, transform.position, Quaternion.identity);
            }
            if (Input.GetButtonDown("Pyramide"))
            {
                Instantiate(pyramide, transform.position, Quaternion.identity);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("mob"))
        {
            GameObject particule =  Instantiate(particules, transform.position, Quaternion.identity);
            Destroy(particule, 2f);
            Destroy(other.gameObject);
        }
    }
}
